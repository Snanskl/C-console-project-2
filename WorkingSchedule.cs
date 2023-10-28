using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class WorkingSchedule
    {
        public void Start()
        {
            ShowMenu();
        }
        private void ShowMenu()
        {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("\tYOUR WORK SCHEDULE\t");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
            do
            {
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine($"   Show a list of the weekends to work. : 1");
                Console.WriteLine($"   Show a list of the nights to work.   : 2");
                Console.WriteLine($"   Exit                                 : 0");
                Console.WriteLine("-------------------------------------------\n");
  
                Console.Write("Your choice: ");
                string answerInStr = Console.ReadLine();
                Console.WriteLine();
                bool exitLoop = false;

                if (int.TryParse(answerInStr, out int answerInNum))
                {
                    if (answerInNum == 1)
                    { WeekendWork(); }
                    else if (answerInNum == 2)
                    { NightWork(); }
                    else if (answerInNum == 0)
                    { exitLoop = true; break; }
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again!");
                    break;
                }
            }
            while (ExitLoop());
        }
        private void WeekendWork()
        {
            for (int i = 1; i <= 52; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write("Week{0, 5}\t\t\t ", i);
                }
            }
            Console.WriteLine();
        }
        private void NightWork()
        {
            for (int j = 1; j <= 52; j+=3)
            {
               Console.Write("Week{0, 5}\t\t\t ", j);
            }
            Console.WriteLine();
        }
        private bool ExitLoop()
        {
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n): ");
            string exitStr = Console.ReadLine().ToLower();
            bool loopAgain = false;

            if (exitStr == "y" || exitStr == "yes")
            { loopAgain = true; }
            else if (exitStr == "n" || exitStr == "no")
            { loopAgain = false; }
            else
            { Console.WriteLine("Invalid input, please try again!"); }
            
            return loopAgain;
        }
    }
}
