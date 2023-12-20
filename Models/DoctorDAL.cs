using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace HospitalManagementSystem.Models
{
    public class DoctorDAL
    {
        //method for fetching data
        public List<Doctor> GetDoctor(string connection) {
            List<Doctor> doctors = new List<Doctor>();
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from doctor", con);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read()) {
                Doctor obj = new Doctor();
                obj.DoctorId =Convert.ToInt32(dr["DoctorId"]);
                obj.DoctorName = dr["DoctorNmae"].ToString();
                obj.SpecializedIn = dr["SpecializedIn"].ToString();
                obj.DoctorEmail = dr["DoctorEmail"].ToString();
                obj.ProfilePic = dr["ProfilePic"].ToString();
                doctors.Add(obj);
            }
            return doctors;
            con.Close();
        }

    }
}
