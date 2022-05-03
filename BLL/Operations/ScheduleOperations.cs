using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Operations
{
    public class ScheduleOperations
    {
        DBOperations db = new DBOperations();
        public void Delete (ScheduleDTO schedule)
        {
            var Sees = db.GetDoctorSees().Where(i => (int)(i.DateTime.DayOfWeek + 7) % 7==schedule.DayofWeekNavigation.Id && i.Visited==false).ToList();
            foreach (DoctorSeeDTO s in Sees)
            {
                s.Closed = true;
                db.UpdateDoctorSee(s);

            }
            db.DeleteSchedule(schedule.Id);
        }

        public void Update(ScheduleDTO schedule)
        {
            var Sees = db.GetDoctorSees().Where(i => (int)(i.DateTime.DayOfWeek + 7) % 7 == schedule.DayofWeekNavigation.Id && i.Visited == false).ToList();
            var oldSchedule = db.GetSchedule(schedule.Id);
            if (schedule.Shift.Id != oldSchedule.Shift.Id)
            {
                double raznica = schedule.Shift.TimeofBegin.TotalMinutes - oldSchedule.Shift.TimeofBegin.TotalMinutes;
                foreach (DoctorSeeDTO s in Sees)
                {
                    s.DateTime = s.DateTime.AddMinutes(raznica);
                    db.UpdateDoctorSee(s);
                }
            }
            var old = oldSchedule.DayofWeekNavigation.Id;
            var present = schedule.DayofWeekNavigation.Id;
            if (present != old)
            {
                int raznica = present > old? present - old : 7 - old + present;
                foreach (DoctorSeeDTO s in Sees)
                {
                    s.DateTime = s.DateTime.AddDays(raznica);
                    db.UpdateDoctorSee(s);
                }
            }
            db.UpdateSchedule(schedule);
        }
    }
}
