using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class FacultyRepository : IEntity<Faculty>
    {
        public List<Faculty> GetAll()
        {
            return new List<Faculty>
            {
                new Faculty{Id = 1, Title = "Applayed Mathematic", UnivercityId = 1, Univercity = new UnivercityRepository().GetById(1) },
                new Faculty{Id = 2, Title = "Historical", UnivercityId = 1, Univercity = new UnivercityRepository().GetById(1) },
                new Faculty{Id = 3, Title = "Economical", UnivercityId = 1, Univercity = new UnivercityRepository().GetById(1) },
                new Faculty{Id = 4, Title = "Management", UnivercityId = 1, Univercity = new UnivercityRepository().GetById(1) }
            };
        }

        public Faculty GetById(int id)
        {
            return GetAll().FirstOrDefault(r => r.Id == id);
        }
    }
}
