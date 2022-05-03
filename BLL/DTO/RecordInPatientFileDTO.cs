using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.DTO
{
    public class RecordInPatientFileDTO
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
        public string Diagnosis { get; set; }
        public int? DoctorId { get; set; }

        public  DoctorDTO Doctor { get; set; }
        public  PatientDTO Patient { get; set; }
        public  List<DoProcDTO> DoProcs { get; set; }

        public RecordInPatientFileDTO (RecordInPatientFile recordInPatientFile)
        {
            Id = recordInPatientFile.Id;
            PatientId = recordInPatientFile.PatientId;
            Date = recordInPatientFile.Date;
            Result = recordInPatientFile.Result;
            Diagnosis = recordInPatientFile.Diagnosis;
            Doctor = new DoctorDTO(recordInPatientFile.Doctor);
            Patient = new PatientDTO(recordInPatientFile.Patient);
            DoProcs = recordInPatientFile.DoProcs.Select(i => new DoProcDTO(i)).ToList();
            


        }
        
    }
}
