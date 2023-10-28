using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class MathWork
    {
        public void Start()
        {
            PrintMultiplicationTable();
            Calculate();
        }

        public void Calculate()
        {
            int startNum = 0;
            int endNum = 0;
            bool repeatLoop = true;

            while (repeatLoop)
            {
                Console.WriteLine("Sum numbers between any two numbers");
                Console.Write("Enter a first number: ");
                startNum = int.Parse(Console.ReadLine());

                Console.Write("Enter a second number: ");
                endNum = int.Parse(Console.ReadLine());
                Console.WriteLine();

                //this if statement swaping the startNum to lower value than endNum
                if (startNum > endNum)
                {
                    int temp = startNum;
                    startNum = endNum;
                    endNum = temp;
                }
                //assigning startNum and endNum to this method
                int sum = SumNumbers(startNum, endNum); 
                Console.WriteLine($"The Sum of numbers between {startNum} and {endNum} is: {sum}");
                Console.WriteLine();

                Console.WriteLine($"**** Even numbers between {startNum} and {endNum}");
                PrintEvenNumbers(startNum, endNum);
                Console.WriteLine();

                Console.WriteLine($"**** Odd numbers between {startNum} and {endNum}");
                PrintOddNumbers(startNum, endNum);

                CalculateSquareRoot(startNum, endNum);

                repeatLoop = ExitCalculation();
            }
        }

        private void CalculateSquareRoot(int num5, int num6)
        {
            Console.WriteLine();
            Console.WriteLine("************** Square Roots **************\n");
            
            for (int i = num5; i <= num6; i++)
            {
                Console.Write("Squaroot ({0,3} to {1,3})", i, num6);
                for (int j = i; j <= num6; j++)
                {
                    double squareRoot = Math.Sqrt(j); // using Sqrt method to display to square root of each loop
                    Console.Write(string.Format("{0,6:f2}", squareRoot));
                }
                Console.WriteLine();
            }
        }

        private bool ExitCalculation()
        {
            bool done = false;

            Console.WriteLine();
            Console.Write("Would you like to continue (y/n): ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y" || answer == "yes")
            { done = true; }
            else if (answer == "n" || answer == "no")
            { done = false; }
            else
            { Console.WriteLine("Invalid input, try again!"); }

            return done;
        }
        //PrintEvenNumber have 2 parameters with integer datatypes
        //this method calculate the even number of two given arguments
        private void PrintEvenNumbers(int number1, int number2)
        {
            for (int evenNum = number1; evenNum <= number2; evenNum++)
            {
                if (evenNum % 2 == 0)
                { Console.Write(evenNum + " "); }
            }
        }
        private void PrintMultiplicationTable()
        {
            Console.WriteLine();
            Console.WriteLine("************** Multiplication Table **************");

            for (int row = 1; row <= 12; row++) //looping for row from 1 to 12
            {
                for (int collum = 1; collum <= 12; collum++) // looping for collum from 1 to 12
                {
                    // Using string format to organize the output 
                    Console.Write(string.Format("{0,4:d} ", row * collum)); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        //PrintOddNumber have 2 parameters with integer datatypes
        //this method calculate the odd number of two given arguments
        private void PrintOddNumbers(int number3, int number4)
        {
            for (int oddNum = number3; oddNum <= number4; oddNum++)
            {
                if (oddNum % 2 != 0)
                {Console.Write(oddNum + " "); }
            }

        }

        //SumNumbers have 2 integer parameters, which will take 2 integer arguments
        private int SumNumbers(int start, int end) 
        {
            int sum = 0;
            //this for loop imitate recursive, where all sum from start to end add together and return sum
            for (int i = start; i <= end; i++)
            {sum += i;}
            return sum;
        }
    }
}
