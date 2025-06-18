using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    class Student
    {
        public int StudentID { get; set; }
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
        public string PhoneNumber { get; set; }
        public int CourseID { get; set; }
        public string CourseName { get; set; } 
    }
}
