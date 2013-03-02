using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace DAL.Repository
{
    public class SubjectRepository : IEntity<Subject>
    {
        private readonly List<Subject> subjects = new List<Subject>();

        public List<Subject> GetAll()
        {
            subjects.Add(new Subject {Id = 1, Name = "History"});
            subjects.Add(new Subject {Id = 2, Name = "English"});
            subjects.Add(new Subject {Id = 3, Name = "Mathematics"});
            subjects.Add(new Subject {Id = 4, Name = "Finance"});

            return subjects;
        }

        public Subject GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }
    }
}