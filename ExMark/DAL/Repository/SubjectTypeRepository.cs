using System.Collections.Generic;
using System.Linq;
using DAL.Models;

namespace DAL.Repository
{
    public class SubjectTypeRepository : IEntity<SubjectType>
    {
        List<SubjectType> subjectType = new List<SubjectType>();

        public List<SubjectType> GetAll()
        {
            subjectType.Add(new SubjectType { Id = 1, Name = "Lecture"});
            subjectType.Add(new SubjectType { Id = 2, Name = "Seminar" });
            subjectType.Add(new SubjectType { Id = 3, Name = "Laboratory" });

            return subjectType;
        }

        public SubjectType GetById(int id)
        {
            return GetAll().FirstOrDefault(s => s.Id == id);
        }
    }
}
