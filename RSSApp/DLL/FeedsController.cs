﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSSApp.DLL {
    class FeedsController {
        private List<RSSFeed> PodcastFeeds = new List<RSSFeed>();


        public FeedsController() {



            //testdata 
            AddFeed(new Uri("https://rss.acast.com/filipandfredrik"));
        }
        public void AddFeed(Uri uri) {
            PodcastFeeds.Add(new RSSFetcher(uri).Fetch());
        }
        public void AddFeed(RSSFeed feed) {
            PodcastFeeds.Add(feed);
        }

        public List<RSSFeed> GetFeeds() {
            return PodcastFeeds;
        }
    }
}
