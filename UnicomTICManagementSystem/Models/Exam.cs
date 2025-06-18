using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    class Exam
    {
        public int ExamID { get; set; }
        public string ExamName { get; set; } 
        public int ModuleID { get; set; }
        public string ModuleName { get; set; }
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
