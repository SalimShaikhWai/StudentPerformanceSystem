using StudentPerformanceSystem.CollectionOfInterfaces;
using StudentPerformanceSystem.Course;
using StudentPerformanceSystem.Marks;
using StudentPerformanceSystem.Reports;
using StudentPerformanceSystem.Students;
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

     public  Icrud crudOperation;
        public string menu="Crud";

        ReportManagement reMan = new ReportManagement();
        public Menu(Icrud crudObjecct)
        {
           this. crudOperation = crudObjecct;
        }
        public Menu()
        {
            menu = "Report";
        }
       
        public static void ReportMenu()
        {
            ConsoleHelper.WriteLine("6.Display subject Wise  Marks by Roll No");
            ConsoleHelper.WriteLine("7.Display Avg MArks Of Course");
            ConsoleHelper.WriteLine("8.Display Student Report With Marks");
            ConsoleHelper.WriteLine("9.Display Course Wise Max Marks");
        }
        private static void ShowCrudMenu()
        {
            ConsoleHelper.DrawLine(120);
            ConsoleHelper.WriteLine("Choose Operation");
            ConsoleHelper.WriteLine("1.Add Data");
            ConsoleHelper.WriteLine("2.Delete Data");
            ConsoleHelper.WriteLine("3.GetAll Data");
            ConsoleHelper.WriteLine("4.Updated Data");
            ConsoleHelper.WriteLine("5.Get Single Data");
           
        }

        public  void Show()
        {
            int val;
            do
            {
                Console.WriteLine("Want to Clear Screen");
                if(Console.ReadLine()=="y")
                {
                    Console.Clear();
                }
                 
                if(menu=="Report")
                     ReportMenu();
                else
                    ShowCrudMenu();
                ConsoleHelper.WriteLine("0.Go Back Main Menu");


                val = int.Parse(Console.ReadLine());

                switch (val)
                {

                    case 1:
                        Console.Clear();
                        crudOperation.AddOrEdit();
                        
                        break;

                    case 2:
                        Console.Clear();
                        crudOperation.Delete();
                        break;

                    case 3:
                        crudOperation.GetAllData();
                        break;
                   
                    case 4:
                        Console.Clear();
                        crudOperation.Edit();
                        break;
                    case 5:
                        Console.Clear();
                        crudOperation.GetSingleData();
                        break;

                  
                    case 6:
                        Console.Clear();
                        reMan.getCourseWiseAvgMarks();
                        break;

                    case 7:
                        Console.Clear();
                        reMan.getStudentReportWithMarks();
                        break;

                    case 8:
                        Console.Clear();
                        reMan.GetCourseWiseMaxMarks();
                        break;
                    case 9:
                        Console.Clear();
                        reMan.GetCourseWiseMaxMarks();
                        break;

                    case 0:
                        return;
                    default:
                        ConsoleHelper.ShowWarning("Wrong Input");
                        break;
                }
       


            }while(val!=0);
        }




    }
}
