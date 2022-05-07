using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Subject
{
    public class Subject
    {

        private int _subjectId;
        private string _subjectCode;
        private string _subjectTitle;
        private string _subjectDescription;
        private string _courseId;

        public Subject()
        {

        }
        public Subject(string subject_code,string subject_title,string subject_desc,string course_code)
        {
            SubjectCode = subject_code;
            SubjectTitle = subject_title;
            SubjectDescription = subject_desc;
            CourseCode = course_code;
        }

        public int SubjectId { get => _subjectId; set => _subjectId = value; }
        public string SubjectCode { get => _subjectCode; set => _subjectCode = value; }
        public string SubjectTitle { get => _subjectTitle; set => _subjectTitle = value; }
        public string SubjectDescription { get => _subjectDescription; set => _subjectDescription = value; }
        public string CourseCode { get => _courseId; set => _courseId = value; }
    }
}
