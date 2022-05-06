using StudentPerformanceSystem.DBClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Course
{
    class CourseService
    {

        DbConnection dbconn = new DbConnection();
        public SqlDataReader GetAllCourse()
        {
            dbconn.getConnection();
            dbconn.getCommand("select *from SCcourse.course ");
          return  dbconn.ExcecuteReader();
            
        }
        public void Add(Course c)
        {

        }
        public void Edit(Course c)
        {

        }
        public void Delete(int courseId)
        {

        }
        public void DisplayCourseWiseAverageMarks()
        {

        }
        public void DisplayCourseWiseHighestMarks()
        {

        }
        public void DisplayCourseWiseTopper()
        {

        }

    }
}
