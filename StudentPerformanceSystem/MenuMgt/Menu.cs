using StudentPerformanceSystem.Course;
using StudentPerformanceSystem.Marks;
using StudentPerformanceSystem.Student;
using StudentPerformanceSystem.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.MenuMgt
{
    public class Menu
    {
        CourseManagement coursemanagement = new CourseManagement();

        SubjectManagement subjectManagement = new SubjectManagement();

        StudentManagement studentManagement = new StudentManagement();

        MarksManagementcs markManagement = new MarksManagementcs();
        private static void ShowMenu()
        {
            ConsoleHelper.DrawLine(120);
            ConsoleHelper.WriteLine("Choose Operation");
            ConsoleHelper.WriteLine("1.Add Course");
            ConsoleHelper.WriteLine("2.Delete Course");
            ConsoleHelper.WriteLine("3.GetAll Course");
            ConsoleHelper.WriteLine("4.Updated Course");
            ConsoleHelper.WriteLine("5.Get All Subject");
            ConsoleHelper.WriteLine("6.Add Subject");
            ConsoleHelper.WriteLine("7.Edit Subject");
            ConsoleHelper.WriteLine("8.Delete Subject");
            ConsoleHelper.WriteLine("9.Get Subject By SubjectCode");
            ConsoleHelper.WriteLine("10.Get All Student");
            ConsoleHelper.WriteLine("11.Add Student");
            ConsoleHelper.WriteLine("12.Edit Student");
            ConsoleHelper.WriteLine("13.Get Student By roll No");
            ConsoleHelper.WriteLine("14.Delete Student");
            //ConsoleHelper.WriteLine("12.Get Course By roll No");
            ConsoleHelper.WriteLine("15.Add Marks");
            ConsoleHelper.WriteLine("16.Display subject Wise  Marks by Roll No");
            ConsoleHelper.WriteLine("17.Display Avg MArks Of Course");
            ConsoleHelper.WriteLine("18.Display Student Report With Marks");
            ConsoleHelper.WriteLine("19.Display Course Wise Max Marks");

            ConsoleHelper.WriteLine("0.Exit");
        }

        public  void Show()
        {
            int val;
            do
            {
                if(Console.ReadLine()=="y")
                {
                    Console.Clear();
                }
                 ShowMenu();
                val= int.Parse(Console.ReadLine());

                switch (val)
                {

                    case 1:
                        Console.Clear();
                        coursemanagement.AddOrEditCourse();
                        
                        break;

                    case 2:
                        Console.Clear();
                        coursemanagement.DeleteCourse();
                        break;

                    case 3:
                        coursemanagement.getAllCourse();
                        break;
                    case 33:
                        Console.Clear();
                        coursemanagement.GetCourse();
                        break;
                    case 4:
                        Console.Clear();
                        coursemanagement.EditCourse();
                        break;

                    case 5:
                        subjectManagement.getAllSubjects();
                        break;
                    case 6:
                        Console.Clear();
                        subjectManagement.AddOrEditSubject();
                        break;
                    case 7:
                        Console.Clear();
                        subjectManagement.EditSubject();
                        break;
                    case 8:
                        subjectManagement.DeleteSubject();
                        break;
                    case 9:
                        Console.Clear();
                        subjectManagement.GetSubject();
                        break;

                    case 10:
                        Console.Clear();
                        studentManagement.getAllStudents();
                        break;
                    case 11:
                        Console.Clear();
                        studentManagement.AddOrEditStudent();
                        break;
                       
                        
                    case 12:
                        Console.Clear();
                        studentManagement.EditStudent();
                        break;
                    case 13:
                        studentManagement.GetStudent();
                            break;
                    case 14:
                        Console.Clear();
                        studentManagement.DeleteStudent();
                        break;
                    case 15:
                        markManagement.AddMarks();
                        break;
                    case 16:
                        Console.Clear();
                        markManagement.GetMarkByRollNo();
                        break;
                    case 17:
                        Console.Clear();
                        coursemanagement.getCourseWiseAvgMarks();
                        break;

                    case 18:
                        Console.Clear();
                        studentManagement.getStudentReportWithMarks();
                        break;

                    case 19:
                        Console.Clear();
                        coursemanagement.GetCourseWiseMaxMarks();
                        break;

                    case 0:
                        return;
                }
       


            }while(val!=0);
        }




    }
}
