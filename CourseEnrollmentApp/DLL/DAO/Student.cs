using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrollmentApp.DLL.DAO
{
    class Student
    {
        public Student(int regNo, string name, string email):this()
        {
            RegNo = regNo;
            Name = name;
            Email = email;
        }

        public Student()
        {
        }

        public int RegNo { get; set; }
        public string Name { get; set; }
        public string  Email { get; set; }
    }
}
