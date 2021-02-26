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

namespace RedditStockResearcher.Controllers
{
    public class SearchController : Controller
    {
        

        private SearchModel CreateBaseModel()
        {
            SearchModel SearchData = new SearchModel
            {
                // List of reddits to search
                Subreddits = new List<string> { "trakstocks", "pennystocks", "wallstreetbets",
                "investing", "stocks", "amcstock" },
                PostDict = new Dictionary<string, List<Post>>(),
                // Create reddit account using appid, secret, and refreshtoken for my app.
                Reddit = new RedditClient(appId: "MEKMHaarViZPQw",
                                       appSecret: "4aK6wVma-xoeUGhtv9Ph9JsMgCY_hw",
                                       refreshToken: "302160206818-2nuSIHKfKi_gLq8ROMLmlEhEDNANvg"),
                Ticker = new Ticker(),
                SubredditImages = new Dictionary<string, string>(),
                SubredditColors = new Dictionary<string, string>(),
                PostsTimePassedStrings = new Dictionary<Post, Tuple<string, string>>(),
                RGX = new Regex("^[a-zA-Z]{1,6}$")
            };

            return SearchData;
        }
        [HttpGet]
        public IActionResult Index(string ticker)
        {
            
            SearchModel SearchData = CreateBaseModel();
            if (ticker == null)
            {
                SearchData.Ticker.Valid = false;
                return View(SearchData);
            }
            else
            {
                ViewData["Ticker"] = ticker;
                SearchData.Ticker.Name = ticker;
            }

            if (SearchData.RGX.IsMatch(ticker))
            {
                SearchData.Ticker.Valid = true;

            }
            else
            {
                SearchData.Ticker.Valid = false;
                return View(SearchData);
            }


            SearchData = SearchAndPopulate(SearchData, ticker);

            return View(SearchData);
        }

        private SearchModel GetPostsTimePassed(SearchModel BaseModel, List<Post> subPosts)
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
                BaseModel.PostsTimePassedStrings.Add(post, new Tuple<string, string>(timeAgo, localTime.ToString("g")));
  
            }

            return BaseModel;

        }


        private SearchModel SearchAndPopulate(SearchModel BaseModel, string ticker)
        {

            foreach (string sub in BaseModel.Subreddits)
            {
                // Get current subreddit from api
                Subreddit currentSubreddit = BaseModel.Reddit.Subreddit(name: sub);

                SearchGetSearchInput searchQuery = new SearchGetSearchInput(ticker);
                List<Post> subPosts = currentSubreddit.Search(searchQuery);
                BaseModel.PostDict.Add(sub, subPosts);

                BaseModel = GetPostsTimePassed(BaseModel, subPosts);


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
                BaseModel.SubredditImages.Add(sub, backgroundImgUrl);
                BaseModel.SubredditColors.Add(sub, currentSubredditInfo.PrimaryColor);



            }
            return BaseModel;
        }
        [HttpGet]
        public IActionResult AddSubreddit(string addSub, string ticker)
        {
            SearchModel BaseModel = CreateBaseModel();
            BaseModel.Subreddits.Insert(0, addSub);
            SearchModel SearchData = SearchAndPopulate(BaseModel, ticker);
            return PartialView("_FilterPartial", SearchData);
        }

    }
}
