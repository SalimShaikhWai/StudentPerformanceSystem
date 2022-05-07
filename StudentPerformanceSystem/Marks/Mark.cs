using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Marks
{
    public class Mark
    {
        private int _markId;
        private int _studentRollNo;
        private string _subjectCode;
        private int marks;

        public Mark()
        {

        }
        public Mark(int studentRollNo,string subjectCode,int marks)
        {
            StudentRollNo = studentRollNo;
            SubjectCode = subjectCode;
            this.Marks= marks;
        }

        public int MarkId { get => _markId; set => _markId = value; }
        public int StudentRollNo { get => _studentRollNo; set => _studentRollNo = value; }
        public string SubjectCode { get => _subjectCode; set => _subjectCode = value; }
        public int Marks { get => marks; set => marks = value; }
    }
}
