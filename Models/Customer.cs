using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace whetstone_MIS4200_MVC_P1.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime customerSince { get; set; }
        // add any other fields as appropriate
        // a customer can have any number of orders, a 1:M relationship,
        // We represent this in the model with an ICollection
        // The syntax says we are creating an ICollection of Order objects,
        // (the name inside the <> is the object name),
        // and the local name of the collection will be Order
        // (the object name and the local name do not have to be the same)
        public ICollection<Order> Order { get; set; }
    }

    public class Order
    {
        public int orderID { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int customerID { get; set; }
        public virtual Customer Customer { get; set; }
    }

    public class Product
    {
        public int productID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }
    }


    public class orderDetail
    {
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int orderID { get; set; }
        public virtual Order Order { get; set; }
        // the next two properties link the orderDetail to the Product
        public int productID { get; set; }
        public virtual Product Product { get; set; }
    }


}