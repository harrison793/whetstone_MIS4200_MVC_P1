using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace whetstone_MIS4200_MVC_P1.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        public string courseDescription { get; set; }
        public DateTime  courseTime { get; set; }
        public ICollection<CourseDetail> CourseDetail { get; set; }
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}