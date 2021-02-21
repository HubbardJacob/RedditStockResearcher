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

        // These are the tokens needed to access reddit's api
        private string redditRefreshToken = "302160206818-2nuSIHKfKi_gLq8ROMLmlEhEDNANvg";
        private string redditAppSecret = "4aK6wVma-xoeUGhtv9Ph9JsMgCY_hw";
        private string redditAppID = "MEKMHaarViZPQw";
        private List<string> subreddits = new List<string> { "trakstocks", "pennystocks" };

        //private Subreddit subreddits = new Subreddit() { Name = "trakstocks" };


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
        public IActionResult Search(SearchModel searchModel)
        {

            RedditClient reddit = new RedditClient(appId: redditAppID, appSecret: redditAppSecret, refreshToken: redditRefreshToken);
            string ticker = searchModel.Ticker;
            ViewData["Searched"] = ticker;

            Dictionary<string, List<Post>> postDict = new Dictionary<string, List<Post>>();
            foreach (string sub in subreddits)
            {
                SearchGetSearchInput searchQuery = new SearchGetSearchInput(ticker);

                List<Post> subPosts = reddit.Subreddit(name: sub).Search(searchQuery);
                postDict.Add(sub, subPosts);
                
            }

            ViewData["SubredditSearch"] = postDict;



            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
