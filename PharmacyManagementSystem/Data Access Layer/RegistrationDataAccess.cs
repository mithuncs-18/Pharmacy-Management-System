using PharmacyManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Data_Access_Layer
{
    class RegistrationDataAccess:DataAccess
    {
        public bool UserRegister(Registration registration)
        {
            string sql = "INSERT INTO Users(Name,Username,Password,Email,DateOfBirth,Gender,BloodGroup) VALUES('" + registration.Name + "','" + registration.Username + "','" + registration.Password + "','" + registration.Email + "','" + registration.DateOfBirth + "','" + registration.Gender + "','" + registration.BloodGroup + "')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";
            SqlDataReader reader = this.GetData(sql);
            if (reader.HasRows)
            {
                return true;
            }
            else
                return false;
        }
    }
}
