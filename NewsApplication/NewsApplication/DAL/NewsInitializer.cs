using NewsApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApplication.DAL
{
    public class NewsInitializer : System.Data.Entity.DropCreateDatabaseAlways<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {
            var news = new List<News>
            {
                new News{
                    ID = 1,
                    title = "new news",
                    newsItem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                    category = "Education",
                    newsItemAdded = DateTime.Parse("13:13:13")
                },
                new News{
                    ID = 2,
                    title = "nsdf",
                    newsItem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                    category = "Education",
                    newsItemAdded = DateTime.Parse("13:13:13")
                },
                new News{
                    ID = 3,
                    title = "ndsfsfdnews",
                    newsItem = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                    category = "Education",
                    newsItemAdded = DateTime.Parse("13:13:13")
                },
            };

            news.ForEach(s => context.NewsItem.Add(s));
            context.SaveChanges();
        }
    }
}