using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace whetstone_MIS4200_MVC_P1.DAL
{
    public class MIS_4200_Context
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}