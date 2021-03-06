using StudentPerformanceSystem.CollectionOfInterfaces;
using StudentPerformanceSystem.MenuMgt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Students
{
    public class StudentManagement:Icrud
    {


        StudentService studentService;
        Student s;
        public StudentManagement()
        {
            studentService = new StudentService();
            s = new Student();
        }

        public void Header()
        {
            ConsoleHelper.WriteHeader(120, "Student Details");
            ConsoleHelper.WriteText(10, "Roll Number");
            ConsoleHelper.WriteText(20, "Student Name");
            ConsoleHelper.WriteText(30, "Student Email");
            ConsoleHelper.WriteText(40, "Student Address");
            ConsoleHelper.WriteText(20, "Course");
            Console.WriteLine();
        }
        public void ShowDataOneByOne()
        {
            //ConsoleHelper.DrawLine(120);
            ConsoleHelper.WriteText(10, s.StudentRollNo.ToString());
            ConsoleHelper.WriteText(30, s.StudentName);
            ConsoleHelper.WriteText(30, s.StudentEmail);
            ConsoleHelper.WriteText(25, s.StudentAddress);
            ConsoleHelper.WriteText(25, s.CourseCode.ToString());
            ConsoleHelper.WriteLine();
        }
        public void AddOrEdit(string operation = "insert")
        {
            ConsoleHelper.WriteHeader(120, "Add Operation on Student");
            ConsoleHelper.WriteLine("Enter you student Name");
            string studentName = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you Student Email");
            string studentEmail = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you student Address");
            string studentAddress = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you Course Code");
            string courseCode = Console.ReadLine();

            ConsoleHelper.DrawLine(120);
            if (operation == "insert")
            {
                s = new Student(studentName, studentEmail, studentAddress, courseCode);
                ConsoleHelper.WriteLine(studentService.AddStudent(s));
            }
            else
            {
                s.StudentName = studentName;
                s.StudentEmail = studentEmail;
                s.StudentAddress = studentAddress;
                s.CourseCode = courseCode;
                ConsoleHelper.WriteLine(studentService.EditStudent(s));
            }
        }
        public void GetAllData()
        {
            ConsoleHelper.WriteHeader(120, "Display Operation on Subjects");
            using (SqlDataReader reader = studentService.GetAllStudent())
            {
                Header();
                while (reader.Read())
                {
                    s.StudentRollNo = int.Parse(reader[0].ToString());
                    s.StudentName = reader[1].ToString();
                    s.StudentEmail = reader[2].ToString();
                    s.StudentAddress = reader[3].ToString();
                    s.CourseCode = reader[4].ToString();
                    ShowDataOneByOne();

                }
            }

        }


        public void GetSingleData()
        {

            ConsoleHelper.WriteLine("Enter you roll no");
            int rollNo =int.Parse( Console.ReadLine());
            SqlDataReader reader = studentService.GetStudentByRollno(rollNo);
            Header();
            while (reader.Read())
            {
                s.StudentRollNo = int.Parse(reader[0].ToString());
                s.StudentName = reader[1].ToString();
                s.StudentEmail = reader[2].ToString();
                s.StudentAddress = reader[3].ToString();
                s.CourseCode = reader[4].ToString();
                ShowDataOneByOne();

            }
        }
        public void Edit()
        {
            GetSingleData();
            ConsoleHelper.WriteLine("Do you want to Edit Subject Y/N");
            string Val = Console.ReadLine().ToLower();
            if (Val == "y")
            {
                AddOrEdit("updtae");
            }
            else
            {
                ConsoleHelper.WriteLine("Ok Thanks");
            }
        }
        public void Delete()
        {
            GetSingleData();
            ConsoleHelper.WriteLine("Do you want to Delete Course Y/N");
            string Val = Console.ReadLine().ToLower();
            if (Val == "y")
            {
                studentService.Delete(s.StudentRollNo);
            }
            else
            {
                ConsoleHelper.WriteLine("Ok Thanks");
            }
        }

        
    }
}
