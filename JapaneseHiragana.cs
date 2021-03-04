using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Learning_Project
{
    public static class JapaneseHiragana //Not sure why the class HAS to be in "public static"!!
    {

        public static void Menu() // The japanese hiragana menu function
        {
            string userInput; // Var to store the user input
            int LoopCondition = 1; // Used to keep the user within the loop 

            while (LoopCondition == 1)
            {
                Console.WriteLine("We have broken the hiragana intro 5 classes to make it easier to learn"); // Writting the text to explain how the class's work
                Console.WriteLine("Please select one to start learning!");
                Console.WriteLine("Classes:");
                Console.WriteLine("· Class 1"); // Alt code for bullet point = 0183
                Console.WriteLine("· Class 2");
                Console.WriteLine("· Class 3");
                Console.WriteLine("· Class 4");
                Console.WriteLine("· Class 5");
                Console.WriteLine("· Test");
                Console.WriteLine("· Quit - This will make you go back to the main menu.");


                userInput = Console.ReadLine().ToUpper(); // Store the input and change to upper case
                userInput = userInput.Substring(0, 1); // Store the first character of the input
                Console.WriteLine("\n");

                switch (userInput) // Switch statment select which option
                {
                    case "1": // Class 1
                        Class1();
                        break;

                    case "2": // Class 2 - FINISH
                        break;

                    case "3": // Class 3 - FINISH
                        break;

                    case "4": // Class 4 - FINISH
                        break;

                    case "5": // Class 5 - FINISH
                        break;

                    case "T": // Test - FINISH
                        break;

                    case "Q": // Quit - Works
                        Console.WriteLine("This will take you back to the main menu"); 
                        LoopCondition = 0; // To break out of the loop
                        break;
                    
                    default: // Error Control
                        Console.WriteLine("Oops! Looks like the wrong infomation was entered!");
                        break;
                }
            }
            

        }

        public static void Class1() // The japanese hiragana class 1 function
        { 
        }
    }
}
