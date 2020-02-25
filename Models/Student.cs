using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace whetstone_MIS4200_MVC_P1.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string studentFirstName { get; set; }
        public string studentLastName { get; set; }
        public string studentEmail { get; set; }
        public string studentPhone { get; set; }
        public DateTime enrollmentDate { get; set; }

        public ICollection<CourseDetail> CourseDetail { get; set; }
    }
}