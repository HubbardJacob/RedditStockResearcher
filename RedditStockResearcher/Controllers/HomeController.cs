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

namespace RedditStockResearcher.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        SearchModel SearchData = new SearchModel
        {
            // List of reddits to search
            Subreddits = new List<string> { "trakstocks", "pennystocks", "wallstreetbets", "investing", "stocks" },
            PostDict = new Dictionary<string, List<Post>>(),
            // Create reddit account using appid, secret, and refreshtoken for my app.
            Reddit = new RedditClient(appId: "MEKMHaarViZPQw",
                                       appSecret: "4aK6wVma-xoeUGhtv9Ph9JsMgCY_hw",
                                       refreshToken: "302160206818-2nuSIHKfKi_gLq8ROMLmlEhEDNANvg"),
            SubredditImages = new Dictionary<string, string>(),
            SubredditColors = new Dictionary<string, string>()
        };


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Search(string ticker)
        {

            SearchData.Ticker = ticker;
            ViewData["Searched"] = ticker;

            //Dictionary<string, List<Post>> postDict = new Dictionary<string, List<Post>>();
            foreach (string sub in SearchData.Subreddits)
            {
                // Get current subreddit from api
                Subreddit currentSubreddit = SearchData.Reddit.Subreddit(name: sub);

                SearchGetSearchInput searchQuery = new SearchGetSearchInput(ticker);
                List<Post> subPosts = currentSubreddit.Search(searchQuery);
                SearchData.PostDict.Add(sub, subPosts);


                Subreddit currentSubredditInfo = currentSubreddit.About();

                string dirtyBackgroundImgUrl = currentSubredditInfo.CommunityIcon;
                string backgroundImgUrl = "";
                if (dirtyBackgroundImgUrl.Contains(".png"))
                {
                    backgroundImgUrl = dirtyBackgroundImgUrl.Substring(0, dirtyBackgroundImgUrl.LastIndexOf(".png") + 4);
                }
                else
                {
                    backgroundImgUrl = dirtyBackgroundImgUrl.Substring(0, dirtyBackgroundImgUrl.LastIndexOf(".jpg") + 4);
                }
                
                // Add to the subreddit images
                SearchData.SubredditImages.Add(sub, backgroundImgUrl);
                SearchData.SubredditColors.Add(sub, currentSubredditInfo.PrimaryColor);

                
                
            }

            ViewData["SubredditPosts"] = SearchData.PostDict;
            ViewData["SubredditImages"] = SearchData.SubredditImages;
            ViewData["SubredditColors"] = SearchData.SubredditColors;


            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
