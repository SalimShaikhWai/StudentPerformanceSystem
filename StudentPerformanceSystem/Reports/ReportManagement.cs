using StudentPerformanceSystem.MenuMgt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Reports
{
    public  class ReportManagement
    {
        public void getStudentReportWithMarks()
        {
            SqlDataReader reader = ReportService.getStudentReportWithMarks();

            ConsoleHelper.WriteHeader(120, "Student Report With Marks");
            ConsoleHelper.WriteText(10, "Roll No");
            ConsoleHelper.WriteText(40, "Student NAme");
            ConsoleHelper.WriteText(40, "Course Title");
            ConsoleHelper.WriteText(20, "Marks");
            Console.WriteLine();

            while (reader.Read())
            {
                ConsoleHelper.WriteText(10, reader[0].ToString());
                ConsoleHelper.WriteText(40, reader[1].ToString());

                ConsoleHelper.WriteText(40, reader[2].ToString());
                ConsoleHelper.WriteText(20, reader[3].ToString());
                Console.WriteLine();
            }


        }
        public void getCourseWiseAvgMarks()
        {
            SqlDataReader reader = ReportService.DisplayCourseWiseAverageMarks();
            ConsoleHelper.WriteHeader(120, "Course With Avg Marks");
            ConsoleHelper.WriteText(60, "Course Name");
            ConsoleHelper.WriteText(60, "Avg Marks");
            Console.WriteLine();

            while (reader.Read())
            {
                ConsoleHelper.DrawLine(120);
                ConsoleHelper.WriteText(60, reader[0].ToString());
                ConsoleHelper.WriteText(60, reader[1].ToString());
                Console.WriteLine();
            }

        }

        public  void GetCourseWiseMaxMarks()
        {
            SqlDataReader reader = ReportService.DisplayCourseWiseHighestMarks();
            ConsoleHelper.WriteHeader(120, "Course Wise Max Marks");
            ConsoleHelper.WriteText(60, "Course Name");
            ConsoleHelper.WriteText(60, "Max Marks");
            Console.WriteLine();

            while (reader.Read())
            {
                ConsoleHelper.DrawLine(120);
                ConsoleHelper.WriteText(60, reader[0].ToString());
                ConsoleHelper.WriteText(60, reader[1].ToString());
                Console.WriteLine();
            }
        }


    }
}
