using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;

namespace HospitalManagementSystem.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Index()
        {
            List<Doctor> doctors = new List<Doctor>() {
            new Doctor(){ DoctorId=101,DoctorName="Dr. Ankit",SpecializedIn="Cardio",DoctorEmail="ankit@ck.com"},
            new Doctor(){ DoctorId=102,DoctorName="Dr. Faiz",SpecializedIn="Neuro",DoctorEmail="faiz@ck.com"},
            new Doctor(){ DoctorId=103,DoctorName="Dr. Vasundara",SpecializedIn="Neuro",DoctorEmail="vasundara@ck.com"}
            };
            return View(doctors);
        }
    }
}
