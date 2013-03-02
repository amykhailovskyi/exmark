using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UnivercityRepository : IEntity<Univercity>
    {
        public List<Univercity> GetAll()
        {
            return new List<Univercity> { new Univercity { Id = 1, Title = "KNU" } };
        }

        public Univercity GetById(int id)
        {
            return GetAll().SingleOrDefault(r => r.Id == id);
        }
    }
}
