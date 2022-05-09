using StudentPerformanceSystem.Course;
using StudentPerformanceSystem.MenuMgt;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.Subject
{
    public class SubjectManagement
    {

        SubjectService subjectService;
        Subject s;


        public SubjectManagement()
        {
            subjectService = new SubjectService();
            s = new Subject();
        }
        public void SubjectHeader()
        {
         ConsoleHelper.WriteHeader(120, "Subject Details");
            ConsoleHelper.WriteText(10, "Subject Id");
            ConsoleHelper.WriteText(15, "Subject Code");
            ConsoleHelper.WriteText(30, "Subject Title");
            ConsoleHelper.WriteText(40, "Course_Description");
            ConsoleHelper.WriteText(20, "Course");
            Console.WriteLine();
        }
        public void ShowSubjects()
        {
            ConsoleHelper.DrawLine(120);
            ConsoleHelper.WriteText(10,s.SubjectId.ToString());
            ConsoleHelper.WriteText(15, s.SubjectCode);
            ConsoleHelper.WriteText(30, s.SubjectTitle);
            ConsoleHelper.WriteText(40, s.SubjectDescription);
            ConsoleHelper.WriteText(20,s.CourseCode.ToString());
            Console.WriteLine();
        }
        public void getAllSubjects()
        {
            ConsoleHelper.WriteHeader(120, "Display Operation on Subjects");
            using (SqlDataReader reader = subjectService.GetAllSubjects())
            {
                SubjectHeader();
                while (reader.Read())
                {
                   s.SubjectId = int.Parse(reader[0].ToString());
                    s.SubjectCode = reader[1].ToString();
                    s.SubjectTitle = reader[2].ToString();
                    s.SubjectDescription = reader[3].ToString();
                    s.CourseCode = reader[4].ToString();
                    ShowSubjects();

                }
            }

        }

        public void AddOrEditSubject(string operation = "insert")
        {
            ConsoleHelper.WriteHeader(120, "Add Operation on Subjects");
            ConsoleHelper.WriteLine("Enter you Subject Code");
            string subjectCode = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you Subject Title");
            string subjectTitle = Console.ReadLine();
            ConsoleHelper.WriteLine("Enter you Subject Description");
            string subjectDesc = Console.ReadLine();

            ConsoleHelper.WriteLine("Enter you Course Code");
            string courseCode = Console.ReadLine();

            ConsoleHelper.DrawLine(120);
            if (operation == "insert")
            {
                s = new Subject(subjectCode, subjectTitle, subjectDesc,courseCode);
                ConsoleHelper.WriteLine(subjectService.AddSubject(s));
            }
            else
            {
                s.SubjectCode=subjectCode;
                s.SubjectTitle = subjectTitle;
                s.SubjectDescription=subjectDesc;
                s.CourseCode=courseCode;
                ConsoleHelper.WriteLine(subjectService.EditSubject(s));
            }
        }
        public void GetSubject()
        {

            ConsoleHelper.WriteLine("Enter you Subject Code");
            string subjectCode = Console.ReadLine();
            SqlDataReader reader = subjectService.GetSubjectBySubjectCode(subjectCode);
            SubjectHeader();
            while (reader.Read())
            {
                s.SubjectId = int.Parse(reader[0].ToString());
                s.SubjectCode = reader[1].ToString();
                s.SubjectTitle = reader[2].ToString();
                s.SubjectDescription = reader[3].ToString();
                s.CourseCode = reader[4].ToString();
                ShowSubjects();

            }
        }

        public void DeleteSubject()
        {
            GetSubject();
            ConsoleHelper.WriteLine("Do you want to Delete Course Y/N");
            string Val = Console.ReadLine().ToLower();
            if (Val == "y")
            {
                subjectService.Delete(s.SubjectId);
            }
            else
            {
                ConsoleHelper.WriteLine("Ok Thanks");
            }
        }

        public void EditSubject()
        {
            GetSubject();
            ConsoleHelper.WriteLine("Do you want to Edit Subject Y/N");
            string Val = Console.ReadLine().ToLower();
            if (Val == "y")
            {
                AddOrEditSubject("updtae");
            }
            else
            {
                ConsoleHelper.WriteLine("Ok Thanks");
            }
        }

    }




}
