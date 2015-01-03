using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using CourseEnrollmentApp.DLL.DAO;
using CourseEnrollmentApp.DLL.Gateway;

namespace CourseEnrollmentApp.BLL
{
    internal class StudentBLL
    {
    StudentGateway aStudentGateway = new StudentGateway();

        public string Save(Student aStudent)
        {
            if (aStudent.RegNo == 0 || aStudent.Name == string.Empty || aStudent.Email == string.Empty)

            {
                return "Course has been enrolled";
            }
            else
            {
                return aStudentGateway.Save(aStudent);
            }



        }

       
    }
}