using NewsApplication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApplication.Models
{
    public class NewsRepository
    {
        NewsContext newsDB = new NewsContext();

        public IEnumerable<News> GetAllNews()
        {
            var result = from item in newsDB.NewsItem
                         select item;

            return result;
        }
    }
}