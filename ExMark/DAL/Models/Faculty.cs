using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int UnivercityId { get; set; }

        public Univercity Univercity { get; set; }
    }
}
