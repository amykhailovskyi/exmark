using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL.Repository
{
    public class ScheduleRepository : IEntity<Schedule>
    {
        List<Schedule> schedules = new List<Schedule>();

        public List<Schedule> GetAll()
        {
            schedules.Add(new Schedule{Id = 1,SubjectId = 1, SubjectTypeId = 1, SubjectOrder = 1, Day = DayOfWeek.Monday});
            schedules.Add(new Schedule{Id = 2,SubjectId = 1, SubjectTypeId = 2, SubjectOrder = 2, Day = DayOfWeek.Monday});
            schedules.Add(new Schedule{Id = 3,SubjectId = 2, SubjectTypeId = 1, SubjectOrder = 3, Day = DayOfWeek.Monday});
            schedules.Add(new Schedule{Id = 4,SubjectId = 3, SubjectTypeId = 1, SubjectOrder = 4, Day = DayOfWeek.Monday});

            schedules.Add(new Schedule { Id = 5, SubjectId = 4, SubjectTypeId = 1, SubjectOrder = 1, Day = DayOfWeek.Tuesday });
            schedules.Add(new Schedule { Id = 6, SubjectId = 4, SubjectTypeId = 2, SubjectOrder = 2, Day = DayOfWeek.Tuesday });
            schedules.Add(new Schedule { Id = 7, SubjectId = 2, SubjectTypeId = 1, SubjectOrder = 3, Day = DayOfWeek.Tuesday });

            schedules.Add(new Schedule { Id = 8, SubjectId = 3, SubjectTypeId = 1, SubjectOrder = 1, Day = DayOfWeek.Wednesday });
            schedules.Add(new Schedule { Id = 9, SubjectId = 2, SubjectTypeId = 1, SubjectOrder = 2, Day = DayOfWeek.Wednesday });
            schedules.Add(new Schedule { Id = 10, SubjectId = 4, SubjectTypeId = 2, SubjectOrder = 3, Day = DayOfWeek.Wednesday });
            schedules.Add(new Schedule { Id = 11, SubjectId = 1, SubjectTypeId = 1, SubjectOrder = 4, Day = DayOfWeek.Wednesday });

            schedules.Add(new Schedule { Id = 12, SubjectId = 1, SubjectTypeId = 1, SubjectOrder = 1, Day = DayOfWeek.Thursday });
            schedules.Add(new Schedule { Id = 13, SubjectId = 4, SubjectTypeId = 2, SubjectOrder = 2, Day = DayOfWeek.Thursday });
            schedules.Add(new Schedule { Id = 14, SubjectId = 2, SubjectTypeId = 1, SubjectOrder = 3, Day = DayOfWeek.Thursday });

            schedules.Add(new Schedule { Id = 15, SubjectId = 2, SubjectTypeId = 1, SubjectOrder = 1, Day = DayOfWeek.Friday });
            schedules.Add(new Schedule { Id = 16, SubjectId = 2, SubjectTypeId = 2, SubjectOrder = 2, Day = DayOfWeek.Friday });
            schedules.Add(new Schedule { Id = 17, SubjectId = 4, SubjectTypeId = 2, SubjectOrder = 3, Day = DayOfWeek.Friday });
            schedules.Add(new Schedule { Id = 18, SubjectId = 1, SubjectTypeId = 1, SubjectOrder = 4, Day = DayOfWeek.Friday });

            return schedules;
        }

        public List<Schedule> GetByDay(DayOfWeek day)
        {
            return GetAll().Where(r => r.Day == day).ToList();
        }

        public List<Schedule> GetByDate(DateTime date)
        {
            return GetByDay(date.DayOfWeek);
        }

        public Schedule GetById(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        } 
    }
}
