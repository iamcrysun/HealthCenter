using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class DoctorSeeDTO
    {
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime DateTime { get; set; }
        public bool? Visited { get; set; }
        public int Id { get; set; }
        public bool Closed { get; set; }

        //public DoctorDTO Doctor { get; set; }
        //public  PatientDTO Patient { get; set; }

        public DoctorSeeDTO(DoctorSee doctorsee)
        {
            Closed = doctorsee.Closed;
            Id = doctorsee.Id;
            Visited = doctorsee.Visited;
            DateTime = doctorsee.DateTime;
            PatientId = doctorsee.PatientId;
            DoctorId = doctorsee.DoctorId;
            //Doctor = new DoctorDTO(doctorsee.Doctor, true);
            //Patient = new PatientDTO(doctorsee.Patient);
        }
    }
}
