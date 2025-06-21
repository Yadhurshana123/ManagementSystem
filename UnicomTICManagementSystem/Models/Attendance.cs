using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    internal class Attendance
    {
        public int AttendanceID { get; set; }
        public int TimetableID { get; set; }
        public int StudentID { get; set; }   
        public string Status { get; set; }
        public DateTime? LogIn { get; set; }
        public DateTime? LogOut { get; set; }
    }
}
