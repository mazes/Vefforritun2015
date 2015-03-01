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
                    newsItem = "´today a man pooped in his pants and ate a banana with the most excitement",
                    category = "Education",
                    newsItemAdded = DateTime.Parse("13:13:13")
                },
                new News{
                    ID = 2,
                    title = "nsdf",
                    newsItem = "´today a man pooped in his pants and ate a banana with the most excitement",
                    category = "Education",
                    newsItemAdded = DateTime.Parse("13:13:13")
                },
                new News{
                    ID = 3,
                    title = "ndsfsfdnews",
                    newsItem = "´today a man pooped in his pants and ate a banana with the most excitement",
                    category = "Education",
                    newsItemAdded = DateTime.Parse("13:13:13")
                },
            };

            news.ForEach(s => context.NewsItem.Add(s));
            context.SaveChanges();
        }
    }
}