using StudentPerformanceSystem.CollectionOfInterfaces;
using StudentPerformanceSystem.MenuMgt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Marks
{
    internal class MarksManagement:Icrud
    {
        MarkManagement markService;
        Mark m;


        public MarksManagement()
        {
            markService = new MarkManagement();
            m = new Mark();
        }
        public void Header()
        {
            ConsoleHelper.WriteHeader(120, "Marks Details");
            ConsoleHelper.WriteText(20, "Roll no");
            ConsoleHelper.WriteText(25, "Student Name");
            ConsoleHelper.WriteText(30, "Subject Name");
            ConsoleHelper.WriteText(40, "Marks");
            Console.WriteLine();
        }
        //public void ShowSubjects()
        //{
        //    ConsoleHelper.DrawLine(120);
        //    //ConsoleHelper.WriteText(10, m.MarkId.ToString());
        //    ConsoleHelper.WriteText(15, m.);
        //    ConsoleHelper.WriteText(30, s.StudentEmail);
        //    ConsoleHelper.WriteText(40, s.StudentEmail);
        //    ConsoleHelper.WriteText(20, s.CourseCode.ToString());
        //    Console.WriteLine();
        //}
        public void GetSingleData()
        {
            ConsoleHelper.WriteLine("Enter you roll no");
            int rollNo = int.Parse(Console.ReadLine());
            SqlDataReader reader = markService.GetmMarksByRollno(rollNo);
            Header();
            while (reader.Read())
            {
                ConsoleHelper.DrawLine(120);
                //ConsoleHelper.WriteText(10, m.MarkId.ToString());
                ConsoleHelper.WriteText(20,reader[0].ToString());
                ConsoleHelper.WriteText(25,reader[1].ToString());
                ConsoleHelper.WriteText(30, reader[2].ToString());
                ConsoleHelper.WriteText(40, reader[3].ToString());
                Console.WriteLine();

            }
        }

        public void AddOrEdit(string operation = "insert")
        {
            ConsoleHelper.WriteHeader(120, "Add Operation on Student");
            ConsoleHelper.WriteLine("Enter you student roll No");
            int studentRollNo = Int32.Parse( Console.ReadLine());
            ConsoleHelper.WriteLine("Enter you Subject Code");
            string subjectCode = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you Subject Marks");
            int marks =Int32.Parse( Console.ReadLine());

            ConsoleHelper.DrawLine(120);
            if (operation == "insert")
            {
                m = new Mark(studentRollNo, subjectCode, marks);
                ConsoleHelper.WriteLine(markService.AddMarks(m));
            }
            else
            {
                //s.StudentName = studentName;
                //s.StudentEmail = studentEmail;
                //s.StudentAddress = studentAddress;
                //s.CourseCode = courseCode;
                //ConsoleHelper.WriteLine(studentService.EditStudent(s));
            }
        }

        public void GetAllData()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void ShowDataOneByOne()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }
    }
}
