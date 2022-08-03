using PharmacyManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyManagementSystem.Data_Access_Layer
{
    class EmpDataAccess:DataAccess
    {
        public List<Employee> ShowEmpInfo()
        {
            string sql = "SELECT * FROM Employees";
            SqlDataReader reader = this.GetData(sql);

            List<Employee> info = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmpId = (int)reader["EmpId"];
                emp.EmpName = reader["EmpName"].ToString();
                emp.Age = (int)reader["Age"];
                emp.Salary = (int)reader["Salary"];
                emp.Location = reader["Location"].ToString();
                info.Add(emp);
            }
            return info;
        }

        public Employee ShowEmpInfoById(int empId)
        {
            string sql = "SELECT * FROM Employees WHERE EmpId=" + empId;
            SqlDataReader reader = this.GetData(sql);

            if (reader.HasRows)
            {
                reader.Read();
                Employee emp = new Employee();
                emp.EmpId = (int)reader["EmpId"];
                emp.EmpName = reader["EmpName"].ToString();
                emp.Age = (int)reader["Age"];
                emp.Salary = (int)reader["Salary"];
                emp.Location = reader["Location"].ToString();
                return emp;
            }
            else
                return null;
        }

        public bool InsertEmp(string empName, int age, int salary,string location)
        {
            string sql = "INSERT INTO Employees(EmpName,Age,Salary,Location) VALUES('" + empName + "'," + age + "," + salary + ",'" + location +"')";
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public bool UpdateEmpInfo(int empId, string empName, int age, int salary, string location)
        {
            string sql = "UPDATE Employees SET EmpName='" + empName + "',Age=" + age + ",Salary=" + salary +",Location='" + location + "'WHERE EmpId=" + empId;

            int result = this.ExecuteQuery(sql);

            if (result > 0)
                return true;
            else
                return false;
        }

        public bool RemoveEmpInfo(int empId)
        {
            string sql = "DELETE FROM Employees WHERE EmpId=" + empId;
            int result = this.ExecuteQuery(sql);
            if (result > 0)
                return true;
            else
                return false;
        }

        public List<Employee> ShowEmpInfoByName(string search)
        {
            string sql = "SELECT * FROM Employees WHERE EmpName LIKE '" + search + "%'";
            SqlDataReader reader = this.GetData(sql);
            List<Employee> info = new List<Employee>();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EmpId = (int)reader["EmpId"];
                emp.EmpName = reader["EmpName"].ToString();
                emp.Age = (int)reader["Age"];
                emp.Salary = (int)reader["Salary"];
                emp.Location = reader["Location"].ToString();
                info.Add(emp);
            }
            return info;
        }
    }


}
