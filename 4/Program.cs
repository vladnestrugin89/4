using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack works of following principles: L.I.F.O.  -  Last In First Out
            // .NET Framevorks  has 2 component such as:
            //  - CLR  --- Common Language Runtime
            //  - FCL  --- Framework Class Library
            All_Tasks tasks = new All_Tasks();  // object or class instance
            int choice = 0;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        tasks.Task_1();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t Press any key to continue..");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.Clear();
                        tasks.Task_2();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t Press any key to continue..");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.Clear();
                        tasks.Task_3();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t Press any key to continue..");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                    case 5:
                        Console.Clear();
                        tasks.Task_5();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t Press any key to continue..");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.Clear();
                        tasks.Task_4();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t Press any key to continue..");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                    case 6:
                        Console.Clear();
                        tasks.Task_6();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t Press any key to continue..");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                    case 7:
                        Console.Clear();
                       // tasks.Task_7();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n\n\t Press any key to continue..");
                        Console.ResetColor();
                        Console.ReadKey(true);
                        break;
                }
            } while (choice != 0);
        }

        static int Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Task_1");
            Console.WriteLine("2 - Task_2");
            Console.WriteLine("3 - Task_3");
            Console.WriteLine("4 - Task_4");
            Console.WriteLine("5 - Task_5");
            Console.WriteLine("5 - Task_6");
            Console.WriteLine("5 - Task_7");
            Console.WriteLine("5 - Task_8");
            Console.WriteLine("5 - Task_9");
            Console.Write("Please make your choice..");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}




            //catch(Exception ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine(ex.Message);
            //    Console.ResetColor();
            //}