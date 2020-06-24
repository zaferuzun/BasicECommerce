using BasicECommerce.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicECommerce.DAL.Concrete.EntityFramework.Context
{
    class BasicECommerceContext : DbContext
    {
        public BasicECommerceContext()
            : base("name=BasicECommerceContext")
        {
        }

        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDetails> OrdersDetails { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
