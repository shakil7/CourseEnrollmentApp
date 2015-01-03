using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseEnrollmentApp.DLL.DAO;

namespace CourseEnrollmentApp.DLL.Gateway
{
    class StudentGateway
    {
        public string Save(Student aStudent)
        {
            string conn = @"server=BITM-401-PC07\SQLEXPRESS; database=StudentCourse;integrated security=true";
            SqlConnection connection=new SqlConnection();
            connection.ConnectionString = conn;
            connection.Open();
            string query = string.Format("INSERT INTO t_Student VALUES ({0},'{1}','{2}')", aStudent.RegNo, aStudent.Name,
             aStudent.Email);
            SqlCommand command=new SqlCommand(query,connection);
            int affectedRow = command.ExecuteNonQuery();
            connection.Close();
            if (affectedRow > 0)
            {
                return "Insert Success";
            }
            else
            {
                return "Something Wrong";
            }

        }
    }
}
