using ecommerceWebiste.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerceWebsite.Database
{
    public class ecommerceWebsiteContext : DbContext , IDisposable
    {
        public ecommerceWebsiteContext() : base("ecommerceWebsiteConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

    }
}
