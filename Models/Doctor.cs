using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string SpecializedIn { get; set; }
        public string DoctorEmail { get; set; }
        public string ProfilePic { get; set; }
    }
}
