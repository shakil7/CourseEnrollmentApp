using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CourseEnrollmentApp.DLL.DAO
{
    class Course
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string Score { get; set; }
        public string Grade { get; set; }
       
        public Course(string title, string code, string score, string grade)
        {
            Title = title;
            Code = code;
            Score = score;
            Grade = grade;
        }

        public Course()
        {
        }

       

       
    }
}
