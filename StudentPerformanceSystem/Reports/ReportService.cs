using StudentPerformanceSystem.DBClass;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Reports
{
    public  class ReportService
    {


        public static SqlDataReader getStudentReportWithMarks()
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("student.StudentReport");
            return DbConnection.ExcecuteReader();

        }
        public static SqlDataReader DisplayCourseWiseAverageMarks()
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.CourseWiseAvgMarks");

            return DbConnection.ExcecuteReader();
        }
        public static SqlDataReader DisplayCourseWiseHighestMarks()
        {
            DbConnection.GetConnection();
            DbConnection.GetStoreProcedure("SCcourse.CourseWiseMaxMarks");

            return DbConnection.ExcecuteReader();
        }
        public static void DisplayCourseWiseTopper()
        {
           
        }


    }
}
