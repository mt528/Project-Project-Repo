using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Learning_Project
{
    public static class MainMenu
    {
        public static void MainMenuFunction()
        {
            string userInput = "Nothing"; //To store the user's input
            int errorControl = 1; // This will be used to help avoid errors

            //--------------------------------------------------------------------------------------------------------------
            while (errorControl == 1)
            {
            Console.WriteLine("Please select what language you want to work on");
            Console.WriteLine("Here are the languages available:"); // Write text that shows the languages available
            Console.WriteLine("\n");
            Console.WriteLine("· Japanese - (J)"); // alt key - 0183 for bullet point
            Console.WriteLine("· More Coming!");

            userInput = Console.ReadLine().ToUpper(); // Changes the user input to upper case
            userInput = userInput.Substring(0, 1); // Replaces the data with the first character 

                switch (userInput) // Switch condition for each possible answer - atm only japanese but could expand easier with this method
                {
                    case "J":
                        Console.WriteLine("\n");
                        Console.WriteLine("Nice, lets learn some Japanese!");
                        //--------------------------------------------------------------------------
                        while (errorControl == 1)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("What writing method do you want to learn?");
                            Console.WriteLine("\n");
                            Console.WriteLine("· Hiragana - (Hir)"); // Hir for hiragana
                            Console.WriteLine("· Coming soon! - Katakana - (Kat)"); // Kat for katakan
                            Console.WriteLine("· Coming soon! - Kanji - (Kan)"); // Kan for kanji
                            Console.WriteLine("· Quit - (Quit)"); // To quit
                            userInput = Console.ReadLine().ToUpper();

                            if (userInput == "HIR")
                            {
                                // Console.WriteLine("Test 1 - works"); // Used for testing
                                JapaneseHiragana.Menu(); // Run the hiragana menu function
                                // MAY NOT NEED THIS!  errorControl = 0; // To break out of the loop when the function is finished
                            }

                            else if (userInput == "KAT")
                            {
                                // Console.WriteLine("Test 2 - works"); // Used for testing
                                Console.WriteLine("Unfortunetly Katakana is not finished yet!");
                            }

                            else if (userInput == "KAN")
                            {
                                // Console.WriteLine("Test 3 - works"); // Used for testing
                                Console.WriteLine("Unfortunetly Kanji is not finished yet!");
                            }

                            else if (userInput == "QUIT")
                            {
                                Console.WriteLine("Bye Bye!");
                                Environment.Exit(0); // To end the programme
                            }

                            else // Error control
                            {
                                Console.WriteLine("Looks like something has gone wrong");
                                Console.WriteLine("Remember, its either Hir,Kat, Kan or Quit for what is needed to be typed!");
                            }
                        }
                       
                        break;
                        //--------------------------------------------------------------------------

                    default: // Error Control
                        Console.WriteLine("Looks like you have entered the wrong info, please try again");
                        // This will loop until correct info is inputted
                        break;
                }
            }
        }
    }
}
