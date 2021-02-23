using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Learning_Project
{
    public static class IntroCode
    {
        public static void Intro()
        {
            //------------------------------------------------------------------------------------
            string userInputIntro = "Nothing"; // To store the user's input for the introduction
                                               //The introduction
            Console.WriteLine("Hello!");
            Console.WriteLine("Welcome to our game!");
            Console.WriteLine("The game's goal is help you learn a language!");



            while (userInputIntro == "Nothing") // While loop
            {
                Console.WriteLine("\nAre you ready to begin? (Y/N)");
                userInputIntro = Console.ReadLine().ToUpper(); // Takes the input - stores it in a variable - changes it to upper case

                userInputIntro = userInputIntro.Substring(0, 1); // Takes the string variable and overwrites it with the first letter typed
                // This is done to make sure it still works incase people enter "yes" or "no"

                switch (userInputIntro) // Selection to decidce where to programme needs to go based on user
                {
                    case "Y":

                        break;

                    case "N":
                        string noCaseVar = "Nothing"; // New variable for this scenario

                        while (noCaseVar == "Nothing") // loop to make no input errors break the programme
                        {
                            Console.WriteLine("Would you like to quit (Y/N)?");
                            noCaseVar = Console.ReadLine().ToUpper(); // Takes the input and store it in a new variable

                            if (noCaseVar == "Y")
                            {
                                Console.WriteLine("Bye bye!");
                                Environment.Exit(0); // To end the programme
                                //break; 
                            }

                            else if (noCaseVar == "N")
                            {
                                Console.WriteLine("Ok, This will bring you back to the 'Are you ready' text!");
                                Console.WriteLine("\n\n"); // To space the text out

                            }

                            else
                            {
                                Console.WriteLine("Oh, it looks like a wrong input has been entered!");
                                Console.WriteLine("Remember its only 'yes' or 'no'.");
                                noCaseVar = "Nothing"; // To reset the variable 
                            }

                            userInputIntro = "Nothing"; // Reseting the input so the loop still works
                            //break; // This might need to be here
                        }


                        break;

                    default: // Incase user enters incorrect data 
                        Console.WriteLine("Oh, it looks like what you entered wasn't correct!");
                        Console.WriteLine("Remember to only enter 'Y' or 'N'");
                        userInputIntro = "Nothing"; // Reseting the input so the loop still works

                        break;

                }

            }
                 
        } 

    }

}