using StudentPerformanceSystem.Course;
using StudentPerformanceSystem.Marks;
using StudentPerformanceSystem.Students;
using StudentPerformanceSystem.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceSystem.MenuMgt
{
    public class MainMenu
    {
        static Menu m;

        public static void ShowContext()
        {
            ConsoleHelper.WriteLine("Choose Menu");
            ConsoleHelper.WriteLine("1.Student");
            ConsoleHelper.WriteLine("2.Course");
            ConsoleHelper.WriteLine("3.Subject");
            ConsoleHelper.WriteLine("4.Marks");
            ConsoleHelper.WriteLine("5.Reports");

        }
        public static void Show()
        {
            int val;
            do
            {
                ShowContext();
                val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        m = new Menu(new StudentManagement());
                        m.Show();
                        break;
                    case 2:
                        m = new Menu(new CourseManagement());
                        m.Show();
                        break;
                    case 3:
                        m = new Menu(new SubjectManagement());
                        m.Show();
                        break;
                    case 4:
                        m = new Menu(new MarksManagement());
                        m.Show();
                        break;
                    case 5:
                        m = new Menu();
                        m.Show();
                        break;
                    case 0:
                        break;
                    default:
                        
                        ConsoleHelper.ShowWarning("Wrong Input");
                        
                        break;
                }

            } while (val > 0);
        }


    }
}
