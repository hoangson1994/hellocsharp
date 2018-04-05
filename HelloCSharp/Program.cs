using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();

            while (true)
            {
                Console.WriteLine("================ MENU ==================");
                Console.WriteLine("1. List Student.");
                Console.WriteLine("2. Find Student By Rollnumber");
                Console.WriteLine("3. Add Student.");
                Console.WriteLine("4. Edit Student");
                Console.WriteLine("5. Delete Student");
                Console.WriteLine("6. Exit.");

                Console.WriteLine("Please enter your chosie: ");
                int chosie = int.Parse(Console.ReadLine());

                switch (chosie)
                {
                    case 1:
                        controller.PrintListStudent();
                        break;
                    case 2:
                        controller.PrintStudentByRollnumber();
                        break;
                    case 3:
                        controller.AddStudent();
                        break;
                    case 4:
                        controller.UpdateStudent();
                        break;
                    case 5:
                        controller.DeleteStudent();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter your choise from 1 to 6.");
                        break;
                }

                Console.WriteLine("===========================================");
            }            
        }
    }
}
