using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Student
{
    public class Student
    {
        private int _studentRollNo;
        private string _studentName;
        private string _studentEmail;
        private string _studentAddress;
        private string _courseCode;
          public Student()
        {

        }
        public Student(string studentName,string studentEmail,string studentAddress,string courseCode)
        {
            _studentAddress = studentAddress;
            _studentName = studentName;
            _studentEmail = studentEmail;
            _courseCode = courseCode;
        }

        public int StudentRollNo { get => _studentRollNo; set => _studentRollNo = value; }
        public string StudentName { get => _studentName; set => _studentName = value; }
        public string StudentEmail { get => _studentEmail; set => _studentEmail = value; }
        public string StudentAddress { get => _studentAddress; set => _studentAddress = value; }
        public string CourseCode { get => _courseCode; set => _courseCode = value; }
    }
}
