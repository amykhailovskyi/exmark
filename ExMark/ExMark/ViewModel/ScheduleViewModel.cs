using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;

namespace ExMark.ViewModel
{
    public class ScheduleViewModel
    {
        public Student Student { get; set; }
        public List<Progress> Progresses { get; set; } 
    }
}