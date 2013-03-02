using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class StudentRepository : IEntity<Student>
    {
        public List<Student> GetAll()
        {
            var students = new List<Student>();

            var stud = new Student();
            stud.Id = 1;
            stud.FirstName = "Vasiliy";
            stud.LastName = "Pupkin";
            stud.FacultyId = 2;
            stud.Faculty = new FacultyRepository().GetById(stud.FacultyId);
            students.Add(stud);

            return students;
        }

        public Student GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public string GetStudentSchedule(DateTime? dateFrom)
        {

            return "";
        }
    }
}
