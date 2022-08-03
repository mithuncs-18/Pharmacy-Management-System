using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Data_Access_Layer
{
    class AdminDataAccess:DataAccess
    {
        public bool LoginValidation(string username, string password)
        {
            string sql = "SELECT * FROM Admins WHERE Username='" + username + "' AND Password='" + password + "'";
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
