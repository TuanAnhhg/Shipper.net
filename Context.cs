using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BooksShopOnline.Models
{
    public class Context : DbContext
    {
        public Context() : base("BooksShopOnline")
        { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<hang> Books { get; set; }
    }
}