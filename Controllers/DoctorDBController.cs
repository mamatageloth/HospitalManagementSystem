using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalManagementSystem.Models;
using Microsoft.Extensions.Configuration;

namespace HospitalManagementSystem.Controllers
{
    public class DoctorDBController : Controller
    {
        private IConfiguration _configuration;
        string connstring = "";
        public DoctorDBController(IConfiguration configuration)
        {

            _configuration = configuration;
            connstring = _configuration.GetConnectionString("dbconn").ToString();
        }
        
        public IActionResult Index()
        {
            DoctorDAL obj = new DoctorDAL();
            List<Doctor> doctors = obj.GetDoctor(connstring);
            return View(doctors);
        }
    }
}
