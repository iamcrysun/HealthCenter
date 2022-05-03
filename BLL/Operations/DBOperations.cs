using BLL.DTO;
using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Operations
{
    public class DBOperations
    {
        DBRepos db = new DBRepos();
        public List<ScheduleDTO> GetSchedules()
        {
            return db.Schedule.GetList().Select(i => new ScheduleDTO(i)).ToList();
        }

        public ScheduleDTO GetSchedule(int id)
        {
            Schedule h = db.Schedule.GetItem(id)
;
            return h == null ? null : new ScheduleDTO(h);
        }

        public int AddSchedule(ScheduleDTO Schedule)
        {
            Schedule newSchedule = new Schedule();
            newSchedule.Room = Schedule.Room;
            newSchedule.ShiftId = Schedule.Shift.Id;
            newSchedule.ZamId = -1;
            newSchedule.DoctorId = Schedule.DoctorId;
            newSchedule.DayofWeek = Schedule.DayofWeekNavigation.Id;
            db.Schedule.Create(newSchedule);
            db.Schedule.Save();
            return newSchedule.Id;
        }

        public void UpdateSchedule(ScheduleDTO Schedule)
        {
            Schedule updatedSchedule = db.Schedule.GetItem(Schedule.Id);
            updatedSchedule.Room = Schedule.Room;
            updatedSchedule.ShiftId = Schedule.Shift.Id;
            updatedSchedule.ZamId = -1;
            updatedSchedule.DoctorId = Schedule.DoctorId;
            updatedSchedule.DayofWeek = Schedule.DayofWeekNavigation.Id;
            db.Schedule.Update(updatedSchedule);
            db.Schedule.Save();
        }

        public void DeleteSchedule (int Id)
        {
            db.Schedule.Delete(Id);
            db.Save();
        }

        public List<DoctorSeeDTO> GetDoctorSees()
        {
            return db.DoctorSee.GetList().Select(i => new DoctorSeeDTO(i)).ToList();
        }

        public DoctorSeeDTO GetDoctorSee(int id)
        {
            DoctorSee h = db.DoctorSee.GetItem(id)
;
            return h == null ? null : new DoctorSeeDTO(h);
        }

        public int AddDoctorSee(DoctorSeeDTO DoctorSee)
        {
            DoctorSee newDoctorSee = new DoctorSee();
            newDoctorSee.Closed = false;
            newDoctorSee.DateTime = DoctorSee.DateTime;
            newDoctorSee.DoctorId = DoctorSee.DoctorId;
            newDoctorSee.PatientId = DoctorSee.PatientId;
            newDoctorSee.Visited = false;
            newDoctorSee.ZamId = -1;
            db.DoctorSee.Create(newDoctorSee);
            db.DoctorSee.Save();
            return newDoctorSee.Id;
        }

        public void UpdateDoctorSee(DoctorSeeDTO DoctorSee)
        {
            DoctorSee updatedDoctorSee = db.DoctorSee.GetItem(DoctorSee.Id);
            updatedDoctorSee.Closed = DoctorSee.Closed;
            updatedDoctorSee.DateTime = DoctorSee.DateTime;
            updatedDoctorSee.DoctorId = DoctorSee.DoctorId;
            updatedDoctorSee.PatientId = DoctorSee.PatientId;
            updatedDoctorSee.Visited = DoctorSee.Visited;
            updatedDoctorSee.ZamId = -1;
            db.DoctorSee.Update(updatedDoctorSee);
            db.DoctorSee.Save();
        }
         //CRUD Doctors
        public List<DoctorDTO> GetDoctors()
        {
            return db.Doctor.GetList().Select(i => new DoctorDTO(i)).ToList();
        }

        public DoctorDTO GetDoctor(int id)
        {
            Doctor h = db.Doctor.GetItem(id)
;
            return h == null ? null : new DoctorDTO(h);
        }

        public int AddDoctor(DoctorDTO Doctor)
        {
            Doctor newDoctor = new Doctor();
            newDoctor.Certificate = Doctor.Certificate;
            newDoctor.Closed = false;
            newDoctor.FullName = Doctor.FullName;
            newDoctor.PlaceOfSee = Doctor.PlaceOfSee;
            newDoctor.SpecializationId = Doctor.Specialization.Id;
            db.Doctor.Create(newDoctor);
            db.Doctor.Save();
            return newDoctor.Id;
        }

        public void UpdateDoctor(DoctorDTO Doctor)
        {
            Doctor updatedDoctor = db.Doctor.GetItem(Doctor.Id);
            updatedDoctor.Certificate = Doctor.Certificate;
            updatedDoctor.Closed = false;
            updatedDoctor.FullName = Doctor.FullName;
            updatedDoctor.PlaceOfSee = Doctor.PlaceOfSee;
            updatedDoctor.SpecializationId = Doctor.Specialization.Id;
            db.Doctor.Update(updatedDoctor);
            db.Doctor.Save();
        }

        public void DeleteDoctor(int Id)
        {
            db.Doctor.Delete(Id);
        }

        public List<DayDTO> GetDays()
        {
            return db.Day.GetList().Select(i => new DayDTO(i)).ToList();
        }

        public DayDTO GetDay(int id)
        {
            Day h = db.Day.GetItem(id)
;
            return h == null ? null : new DayDTO(h);
        }

        public List<ShiftDTO> GetShifts()
        {
            return db.Shift.GetList().Select(i => new ShiftDTO(i)).ToList();
        }

        public ShiftDTO GetShift(int id)
        {
            Shift h = db.Shift.GetItem(id)
;
            return h == null ? null : new ShiftDTO(h);
        }
    }
}
