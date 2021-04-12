using Microsoft.AspNetCore.Http;
using Reddit;
using Reddit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RedditStockResearcher.Models
{
    public class SearchModel
    {
        const string SessionKeySubs = "_Subs";
        public Ticker Ticker { get; set; }
        public Dictionary<string, List<Post>> PostDict { get; set; }
        public List<string> Subreddits { get; set; }
        public RedditClient Reddit { get; set; }
        public Dictionary<string, string> SubredditImages { get; set; }
        public Dictionary<string, string> SubredditColors { get; set; }
        public Dictionary<Post, Tuple<string, string>> PostsTimePassedStrings { get; set; }
        public Regex RGX { get; set; }

        public static SearchModel SavedData { get; set; }

    }
}
