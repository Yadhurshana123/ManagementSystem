﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    class Mark
    {
        public int MarkID { get; set; }
        public int StudentID { get; set; } 
        public int ExamID { get; set; }    
        public int Score { get; set; }
        public string Results { get; set; }
    }
}
