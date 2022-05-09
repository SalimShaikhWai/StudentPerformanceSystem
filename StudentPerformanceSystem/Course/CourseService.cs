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

        //DbConnection dbconn = new DbConnection();
        public SqlDataReader GetAllCourse()
        {
            DbConnection.GetConnection();
            DbConnection.GetCommand("select *from SCcourse.course ");
          return DbConnection.ExcecuteReader();
            
        }
        public SqlDataReader GetCourseByCourseCode(string course_code)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.getCourseByCourseCode");
            DbConnection.AddInputParameter("course_code", course_code);
            return DbConnection.ExcecuteReader();

        }
        public string Add(Course c)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.InsertCourse");
            DbConnection.AddInputParameter("course_code", c.Course_code);
            DbConnection.AddInputParameter("course_title", c.Course_title);
            DbConnection.AddInputParameter("course_description", c.Course_description);
            return DbConnection.ExcecuteNonQuery();
        }
        public string Edit(Course c)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.UpdateCourseByCourseCode");
            DbConnection.AddInputParameter("course_id", c.Course_id);
            DbConnection.AddInputParameter("course_code", c.Course_code);
            DbConnection.AddInputParameter("course_title", c.Course_title);
            DbConnection.AddInputParameter("course_description", c.Course_description);
            return DbConnection.ExcecuteNonQuery();

        }
        public void Delete(int courseId)
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.UpdatedStatusOfCourse");
            DbConnection.AddInputParameter("CourseId", courseId);
            DbConnection.ExcecuteNonQuery();

        }
       
      
        

    }
}
