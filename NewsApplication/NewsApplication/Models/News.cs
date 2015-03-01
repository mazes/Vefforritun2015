using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsApplication.Models
{
    public class News
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string newsItem { get; set; }
        public string category { get; set; }
        public DateTime newsItemAdded { get; set; }
    }
}