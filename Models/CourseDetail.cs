using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace whetstone_MIS4200_MVC_P1.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public int courseDetailDescription { get; set; }
        public DateTime courseStartTime { get; set; }
        public int courseID { get; set; }
        public virtual Course Course { get; set; }
        public int StudentID { get; set; }
        public virtual Student Student { get; set; }
    }
}