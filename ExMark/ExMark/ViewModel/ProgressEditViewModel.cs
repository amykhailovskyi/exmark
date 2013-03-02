using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExMark.ViewModel
{
    public class ProgressEditViewModel
    {
        public List<Student> Students { get; set; }
        public List<Schedule> Schedule { get; set; }
        public List<Progress> Progresses { get; set; }
    }
}