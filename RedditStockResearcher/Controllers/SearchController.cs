using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reddit.Controllers;
using Reddit;
using RedditStockResearcher.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using Reddit.Inputs.Search;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;

namespace RedditStockResearcher.Controllers
{
    public class SearchController : Controller
    {
        const string SessionKeySubs = "_Subs";
        private List<string> BaseSubs = new List<string>()
        { 
            "trakstocks",
            "pennystocks",
            "wallstreetbets",
            "investing",
            "stocks"
        };
        private CookieOptions CookieOpts = new CookieOptions 
        { 
            Path = "/", 
            HttpOnly = false, 
            IsEssential = true, 
            Expires = DateTime.Now.AddYears(100) 
        };
        public int rememberdata;
        
        // Each time the search page is updated (new search, filter, etc.). Create a new model 
        private SearchModel CreateBaseModel()
        {
            SearchModel SearchData = new SearchModel
            {
                PostDict = new Dictionary<string, List<Post>>(),
                // Create reddit account using appid, secret, and refreshtoken for my app.
                Reddit = new RedditClient(appId: "*************",
                                       appSecret: "*************",,
                                       refreshToken: "*************",),
                Ticker = new Ticker(),
                SubredditImages = new Dictionary<string, string>(),
                SubredditColors = new Dictionary<string, string>(),
                PostsTimePassedStrings = new Dictionary<Post, Tuple<string, string>>(),
                RGX = new Regex("^[a-zA-Z]{1,6}$")
            };

            //Checking cookie data, if exists, populate model with it
            string cookieSubs = Request.Cookies[SessionKeySubs];

            // If we have not yet created cookies for the user.
            if (string.IsNullOrEmpty(cookieSubs))
            {
                SearchData.Subreddits = BaseSubs;
                string baseSubsString = String.Join(",", BaseSubs);
                Response.Cookies.Append(SessionKeySubs, baseSubsString, CookieOpts);
            }
            else
            {
                SearchData.Subreddits = cookieSubs.Split(',').ToList<string>();
            }


            return SearchData;
        }
        [HttpGet]
        public IActionResult Index(string ticker)
        {
            rememberdata = 0;
            SearchModel.SavedData = CreateBaseModel();

            if (ticker == null)
            {
                SearchModel.SavedData.Ticker.Valid = false;
                return View(SearchModel.SavedData);
            }
            else
            {
                ViewData["Ticker"] = ticker;
                SearchModel.SavedData.Ticker.Name = ticker;
            }

            // Check if valid ticker.
            if (SearchModel.SavedData.RGX.IsMatch(ticker))
            {
                SearchModel.SavedData.Ticker.Valid = true;

            }
            else
            {
                SearchModel.SavedData.Ticker.Valid = false;
                return View(SearchModel.SavedData);
            }


            SearchAndPopulate(SearchModel.SavedData.Subreddits, ticker);
            return View(SearchModel.SavedData);
        }

        private void GetPostsTimePassed(List<Post> subPosts)
        {
            const int SECOND = 1;
            const int MINUTE = 60 * SECOND;
            const int HOUR = 60 * MINUTE;
            const int DAY = 24 * HOUR;
            const int MONTH = 30 * DAY;

            foreach (Post post in subPosts)
            {
                var ts = new TimeSpan(DateTime.UtcNow.Ticks - post.Created.Ticks);
                double delta = Math.Abs(ts.TotalSeconds);
                string timeAgo;

                if (delta < 1 * MINUTE)
                    timeAgo = ts.Seconds == 1 ? "one second ago" : ts.Seconds + " seconds ago";

                else if (delta < 2 * MINUTE)
                    timeAgo = "a minute ago";

                else if (delta < 45 * MINUTE)
                    timeAgo = ts.Minutes + " minutes ago";

                else if (delta < 90 * MINUTE)
                    timeAgo = "an hour ago";

                else if (delta < 24 * HOUR)
                    timeAgo = ts.Hours + " hours ago";

                else if (delta < 48 * HOUR)
                    timeAgo = "yesterday";

                else if (delta < 30 * DAY)
                    timeAgo = ts.Days + " days ago";

                else if (delta < 12 * MONTH)
                {
                    int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
                    timeAgo = months <= 1 ? "one month ago" : months + " months ago";
                }
                else
                {
                    int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
                    timeAgo = years <= 1 ? "one year ago" : years + " years ago";
                }

                //var easternZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
                var localTime = TimeZoneInfo.ConvertTimeFromUtc(post.Created, TimeZoneInfo.Local);
                SearchModel.SavedData.PostsTimePassedStrings.Add(post, new Tuple<string, string>(timeAgo, localTime.ToString("g")));
  
            }

        }


        private void SearchAndPopulate(List<string> subreddits, string ticker, bool sorting = false, string sort = "relevance")
        {
            // If we are sorting, we have to empty our dictionarys as we getting all new data.
            if (sorting)
            {
                SearchModel.SavedData.PostDict = new Dictionary<string, List<Post>>();
                SearchModel.SavedData.SubredditImages = new Dictionary<string, string>();
                SearchModel.SavedData.SubredditColors = new Dictionary<string, string>();
                SearchModel.SavedData.PostsTimePassedStrings = new Dictionary<Post, Tuple<string, string>>();
            }
            foreach (string sub in subreddits)
            {
                // Get current subreddit from api
                Subreddit currentSubreddit = SearchModel.SavedData.Reddit.Subreddit(name: sub);

                SearchGetSearchInput searchQuery = new SearchGetSearchInput(ticker, sort: sort);
                List<Post> subPosts = currentSubreddit.Search(searchQuery);
                SearchModel.SavedData.PostDict.Add(sub, subPosts);

                GetPostsTimePassed(subPosts);


                Subreddit currentSubredditInfo = currentSubreddit.About();

                string dirtyBackgroundImgUrl = currentSubredditInfo.CommunityIcon;
                string backgroundImgUrl;
                if (dirtyBackgroundImgUrl.Contains(".png"))
                {
                    backgroundImgUrl = dirtyBackgroundImgUrl.Substring(0, dirtyBackgroundImgUrl.LastIndexOf(".png") + 4);
                }
                else
                {
                    backgroundImgUrl = dirtyBackgroundImgUrl.Substring(0, dirtyBackgroundImgUrl.LastIndexOf(".jpg") + 4);
                }

                // Add to the subreddit images
                SearchModel.SavedData.SubredditImages.Add(sub, backgroundImgUrl);
                SearchModel.SavedData.SubredditColors.Add(sub, currentSubredditInfo.PrimaryColor);



            }
            
        }

        [HttpGet]
        public IActionResult AddSubreddit(string addSub, string ticker)
        {
            if (SearchModel.SavedData.Subreddits.Contains(addSub))
            {
                return PartialView("_FilterPartial", SearchModel.SavedData);
            }
            // Append new sub to the cookies.
            string pastSubs = Request.Cookies[SessionKeySubs];
            Response.Cookies.Append(SessionKeySubs, pastSubs+","+addSub, CookieOpts);
  
            SearchModel.SavedData.Subreddits.Add(addSub);
            List<string> newSubSingleList = new List<string>(); // This is so we can only pass the new subreddit to search
            newSubSingleList.Add(addSub);

            SearchAndPopulate(newSubSingleList, ticker);
            return PartialView("_FilterPartial", SearchModel.SavedData);
        }


        [HttpGet]
        public IActionResult SortSubreddit(string sortBy, string ticker)
        {

            SearchAndPopulate(SearchModel.SavedData.Subreddits, ticker, sorting: true, sort: sortBy);
            return PartialView("_FilterPartial", SearchModel.SavedData);
        }

        [HttpGet]
        public void RemoveSubreddit(string remSub, string ticker)
        {
            // Get past subs
            string pastSubs = Request.Cookies[SessionKeySubs];

            // Convert to list to remove
            List<string> pastSubList = pastSubs.Split(',').ToList<string>();
            pastSubList.Remove(remSub);

            // Save updated sub list to cookies as string
            string deletedSubString = String.Join(",", pastSubList);
            Response.Cookies.Append(SessionKeySubs, deletedSubString, CookieOpts);

            SearchModel.SavedData.Subreddits.Remove(remSub);


        }

    }
}
