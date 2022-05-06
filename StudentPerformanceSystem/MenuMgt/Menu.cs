using StudentPerformanceSystem.Course;
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
        private static void ShowMenu()
        {
            ConsoleHelper.DrawLine(120);
            ConsoleHelper.WriteLine("Choose Operation");
            ConsoleHelper.WriteLine("1.Add Course");
            ConsoleHelper.WriteLine("2.Delete Course");
            ConsoleHelper.WriteLine("3.GetAll Course");
            ConsoleHelper.WriteLine("0.Exit");
        }

        public  void Show()
        {
            int val;
            do
            {
                ShowMenu();
                val= int.Parse(Console.ReadLine());

                switch (val)
                {

                    case 1:
                        coursemanagement.AddCourse();
                        break;

                    case 2:
                        coursemanagement.DeleteCourse();
                        break;

                    case 3:
                        coursemanagement.getAllCourse();
                        break;

                    case 4:
                        break;

                    case 0:
                        return;
                }
       


            }while(val!=0);
        }




    }
}
