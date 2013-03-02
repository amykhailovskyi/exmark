using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int SubjectTypeId { get; set; }
        public int SubjectOrder { get; set; }
        public DayOfWeek Day { get; set; }

        public Subject Subject { get; set; }
        public SubjectType SubjectType { get; set; }
    }
}
