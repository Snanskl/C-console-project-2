using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class FunFeatures
    {
        private string name = ""; // global scope variable
        private string email= "";

        //Create a "Start" method to "collect" and organize all the other methods
        public void Start()
        {
            //Invoking "Introduce" method to start the programe with
            Introduce();
            //This loop will determine weather a programe will continue or not in do-while loop
            bool repeatLoop = false;

            //create do while loop so that we can atleast run the programe once
            //even if the "while" part is true
            do 
            { 
                PredictMyDay();
                CalculateStringLength();
                repeatLoop = RunAgian();
            }
            while (repeatLoop); //Will contine to be false untill user's input returns true
        }
        public void CalculateStringLength()
        {
            Console.WriteLine();
            Console.WriteLine("******* String Length *********");

            Console.WriteLine("Write a text with any number of characters and press Enter.");
            Console.WriteLine("You can even copy text from a file and paste it here!");
            string textAnwer = Console.ReadLine().ToUpper(); //Convert every character to upper case
            Console.ReadKey();

            Console.WriteLine(textAnwer);
            // Displaying the length of string from user's input
            Console.WriteLine($"Number of characters = {textAnwer.Length}"); 
        }

        private void Introduce()
        {
            Console.WriteLine("My name is Minou and I am a student of the first semester!\n");
            Console.Write("Let me know about yourself!\n");
           
            ReadName(); //Call ReadName method to perform its task
            ReadEmail();//Call ReadEmail method to perform its task

            Console.WriteLine();
            Console.WriteLine($"Nice to meet you {name}");
            Console.WriteLine($"Your email is {email}");  
        }
        public void PredictMyDay()
        {
            Console.WriteLine();
            Console.WriteLine("******* FORTUNE TELLER *********");
            Console.Write("Enter a number from 1 to 7: ");
            int answerNum = int.Parse(Console.ReadLine());

            switch (answerNum) // using switch statement to return back text to user
            {
                case 1:
                    Console.WriteLine("Keep calm on Mondays! You can fall apart!");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("Tuesday and Wednesdays break your heart!");
                    break;
                case 4:
                    Console.WriteLine("Thursday is your lucky day, don't wait for Friday!");
                    break;
                case 5:
                    Console.WriteLine("Friday, you are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default: //default statement to return text when user dont follow instruction
                    Console.WriteLine("No day? is a good day but it doesn't exist!");
                    break;
            }
        }
        public void ReadEmail() // this method sole purpose is to read user's input
        {
            Console.Write("Your email please: ");
            email = Console.ReadLine();
        }
        public void ReadName()
        {
            Console.Write("Your first name please: ");
            string firstName = Console.ReadLine();

            Console.Write("Your last name please: ");
            string lastName = Console.ReadLine();

            // using to upper to convert and substring to connect the rest
            lastName = char.ToUpper(lastName[0]) + lastName.Substring(1); 
            name = lastName + ", " + firstName; // combine last name and first name together
        }
        private bool RunAgian()
        {
            Console.Write("Would you like to continue the loop (y/n): ");
            // Using ToLower method to to simply turn all answer to lower case
            string answer = Console.ReadLine().ToLower(); 
            
            bool repeatingLoop = false;

            //if user return y or yes, preogram continue, otherwise, move to other programe
            if (answer == "y" || answer == "yes")
            { repeatingLoop = true; }
            return repeatingLoop;
        }
    }
}

