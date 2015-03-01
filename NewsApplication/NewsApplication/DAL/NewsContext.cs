using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NewsApplication.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace NewsApplication.DAL
{
    public class NewsContext : DbContext
    {
           
        public NewsContext() : base("NewsContext")
        {

        }
        
        public DbSet<News> NewsItem { get; set; }

       /* protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }*/
    }
}