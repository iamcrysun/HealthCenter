using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.DTO
{
    public class DoctorDTO
    {
        public int PlaceOfSee { get; set; }
        public string FullName { get; set; }
        public int Id { get; set; }
        public bool Certificate { get; set; }
        public bool Closed { get; set; }
        public SpecializationDTO Specialization { get; set; }
        public List<DoctorSeeDTO> DoctorSees { get; set; }
        public List<ScheduleDTO> Schedules { get; set; }
        public DoctorDTO(Doctor doctor)
        {
            PlaceOfSee = doctor.PlaceOfSee;
            FullName = doctor.FullName;
            Id = doctor.Id;
            Certificate = doctor.Certificate;
            Closed = doctor.Closed;
            Specialization = new SpecializationDTO(doctor.Specialization);
            DoctorSees = doctor.DoctorSees.Select(i => new DoctorSeeDTO(i)).ToList();
            Schedules = doctor.Schedules.Select(i => new ScheduleDTO(i)).ToList();

        }
        public DoctorDTO(Doctor doctor, bool a)
        {

            PlaceOfSee = doctor.PlaceOfSee;
            FullName = doctor.FullName;
            Id = doctor.Id;
            Certificate = doctor.Certificate;
            Closed = doctor.Closed;
            Specialization = new SpecializationDTO(doctor.Specialization);
        }
    }
}
