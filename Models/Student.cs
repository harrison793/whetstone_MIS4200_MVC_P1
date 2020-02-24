using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace whetstone_MIS4200_MVC_P1.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public DateTime studentSince { get; set; }

        public ICollection<Course> Course { get; set; }

    }

    public class Course
    {
        public int courseID { get; set; }
        public string courseDescription { get; set; }
        public DateTime selectionDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }

    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public int creditAmount { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int orderID { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
    public class Instructor
    {
        public int instructorID { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string email { get; set; }

        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}