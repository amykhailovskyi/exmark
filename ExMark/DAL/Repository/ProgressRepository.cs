using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class ProgressRepository : IEntity<Progress>
    {
        private ExMarkDB context = new ExMarkDB();

        public List<Progress> Items
        {
            get
            {
                var list = context.Progresses;
                foreach (var i in list)
                {
                    SetVirtualFields(i);
                }

                return list.ToList();
            }
        }

        public void Save(Progress obj)
        {
            if (obj.Id == 0)
            {
                context.Progresses.Add(obj);
            }
            else
            {
                context.Entry(obj).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        
        public void Delete(Progress obj)
        {
            context.Progresses.Remove(obj);
            context.SaveChanges();
        }

        public Progress GetById(int id)
        {
            var p = context.Progresses.Find(id);
            SetVirtualFields(p);
            return p;
        }

        private void SetVirtualFields(Progress p)
        {
            if (p == null)
            {
                return;
            }

            p.Student = new StudentRepository().GetById(p.StudentId);
            p.Schedule = new ScheduleRepository().GetById(p.SheduleId);
        }

        public List<Progress> GetAll()
        {
            //return Items.ToList();
            return new List<Progress>
            {
                new Progress { Id = 1, SheduleId = 1, StudentId = 1, Mark = 5, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 2, SheduleId = 2, StudentId = 1, Mark = 3, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 3, SheduleId = 3, StudentId = 1, Mark = -1, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 4, SheduleId = 4, StudentId = 1, Mark = 3, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 5, SheduleId = 5, StudentId = 1, Mark = -1, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 6, SheduleId = 6, StudentId = 1, Mark = 5, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 7, SheduleId = 8, StudentId = 1, Mark = 4, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 8, SheduleId = 10, StudentId = 1, Mark = 4, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 9, SheduleId = 11, StudentId = 1, Mark = -1, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 10, SheduleId = 12, StudentId = 1, Mark = 5, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 11, SheduleId = 16, StudentId = 1, Mark = 3, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 12, SheduleId = 17, StudentId = 1, Mark = 4, Date = new DateTime(2013, 2, 25) },
                new Progress { Id = 13, SheduleId = 18, StudentId = 1, Mark = 5, Date = new DateTime(2013, 2, 25) }
            };
        }

        public List<Progress> LoadByDate(DateTime date)
        {
            return GetAll().Where(r => r.Date == date).ToList();
        }
        
        public List<Progress> Load(int? id, DateTime? date)
        {
            return GetAll().Where(r => r.Date == new DateTime(2013, 2, 25) && r.StudentId == id).ToList();
        }
    }
}
