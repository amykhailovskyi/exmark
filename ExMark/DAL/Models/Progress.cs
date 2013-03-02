using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SheduleId { get; set; }
        public DateTime Date { get; set; }
        public int Mark { get; set; }

        [NotMapped]
        public Student Student { get; set; }
        [NotMapped]
        public Schedule Schedule { get; set; }
    }
}
