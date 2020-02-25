using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace whetstone_MIS4200_MVC_P1.Models
{
    public class Instructor
    {

        public int instructorID { get; set; }
        public string instructorsFirstName { get; set; }
        public string  instructorsLastName { get; set; }
        public string instructorsEmail { get; set; }
        public string instructorsPhone { get; set; }


        public ICollection<Course> Course { get; set; }

        public int schoolIDc { get; set; }
    }
}