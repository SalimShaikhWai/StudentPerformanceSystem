using StudentPerformanceSystem.MenuMgt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Course
{ 
    public class CourseManagement
    {
        CourseService courseService;
        Course c;
        public CourseManagement()
        {
            courseService = new CourseService();
            c = new Course();
        }
        public void AddCourse()
        { 
            ConsoleHelper.WriteHeader(120, "Add Operation on course");
            ConsoleHelper.WriteLine("Enter you Course Code");
            string courseCode = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you Course Title");
            string courseTitle = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you Course Description");
            string courseDesc = Console.ReadLine();
            c =new Course(courseCode,courseTitle,courseDesc);
            courseService.Add(c);

        }
        public void getAllCourse()
        {
            ConsoleHelper.WriteHeader(120, "Delete Operation on Course");
            using (SqlDataReader reader = courseService.GetAllCourse())
            {
                CourseHeader();
                while (reader.Read())
                {
                    c.Course_id=int.Parse( reader[0].ToString());
                    c.Course_code=reader[1].ToString();
                    c.Course_title=reader[2].ToString();
                    c.Course_description=reader[3].ToString();
                    ShowCourse();

                }
            }

        }
        public void GetCourse()
        {
           
            ConsoleHelper.WriteLine("Enter you Course Code");
            string courseCode = Console.ReadLine();
          

        }
        public void DeleteCourse()
        {
           
          GetCourse();
            CourseHeader();
            ShowCourse();


        }
        public void CourseHeader()
        {
            ConsoleHelper.WriteHeader(120, "Course Details");
            ConsoleHelper.WriteText(10, "Course_Id");
            ConsoleHelper.WriteText(20, "Course_Name");
            ConsoleHelper.WriteText(30, "Course_Title");
            ConsoleHelper.WriteText(40, "Course_Description");
            Console.WriteLine();
           
        }
        public void ShowCourse()
        {
            
            ConsoleHelper.DrawLine(120);
            ConsoleHelper.WriteText(10, c.Course_id.ToString());
            ConsoleHelper.WriteText(20, c.Course_code);
            ConsoleHelper.WriteText(30, c.Course_title);
            ConsoleHelper.WriteText(40, c.Course_description);
            Console.WriteLine();




        }
        public void  EditCourse()
        {

        }

       

    }
}
