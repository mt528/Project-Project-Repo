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
        #region Hiragana Class Methods (1-5)
        //----------------------------------------------------------------------------------------------------------------------
        //----------------------------------------------------------------------------------------------------------------------
        // Class Functions
        public static void Class1() // The japanese hiragana class 1 function
        {
            //------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------
            // REMOVE ADDED THIS INTO A FUNCTION (adding lists elements)
            //------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------
            //------------------------------------------------------------------------------------------
            /// These are two lists - Questions,Answers.
            /// These are parrel lists - Index for question/answer are the same!
            List<string> FirstIterationQuestion = new List<string>(); // Contains Question letters
            List<string> FirstIterationAnswer = new List<string>(); // Contains Answers phrases
            /// Same thing but again so the user will have to get the answer right
            /// for each character twice 
            List<string> SecondIterationQuestion = new List<string>(); // if correct the letter will be moved into here to be tested again
            List<string> SecondIterationAnswer = new List<string>();

            /// A place to store the completed characters and answers when the
            /// MAY NOT NEED THIS!! 
            /// WITHOUT IT THIS FIXES THE CLEANING ISSUE ----------------------------------------------------------------------------------
            List<string> CompletedIteration = new List<string>(); // If the user gets it right again the letter will be moved into here where it wont be shown again

            //-------------------------------------------------
            //-------------------------------------------------
            // NOT FINISHED 
            #region Adding elements to the lists
            /// Adding the elements in the first question and answer list
            /// MAY BE ABLE TO TURN THIS PROCESS INTO A METHOD ----------------------------------------------------------------------------
            FirstIterationQuestion.Add("あ"); // First question element element - Index 0
            FirstIterationAnswer.Add("A");

            FirstIterationQuestion.Add("い"); // Index 1 
            FirstIterationAnswer.Add("I");

            FirstIterationQuestion.Add("う"); // Index 2 
            FirstIterationAnswer.Add("U");

            FirstIterationQuestion.Add("え"); // Index 3 
            FirstIterationAnswer.Add("E");

            FirstIterationQuestion.Add("お"); // Index 4 
            FirstIterationAnswer.Add("O");
            #endregion
            //-------------------------------------------------
            //-------------------------------------------------



            Console.OutputEncoding = System.Text.Encoding.Unicode; // Changing the encoding to unicode to show the hiragana


            //-------------------------------------------------
            //-------------------------------------------------

            Console.WriteLine("The way the answers will be done is that it will require you to enter the romanji version of the letters"); // Explain what romanji is
            Console.WriteLine("Romanji is a method for writing Japanese words/characters with English letters");
            Console.WriteLine("For example:  べんきょうする = benkyousuru");
            Console.WriteLine("              べ = be, etc");
            Console.WriteLine("\n");

            // Delay for 200ms - ADD THIS - NO IDEA HOW THOUGH -------------------------------------------------------------------

            Console.WriteLine("The first lesson will have the first 5 vowels in Japanese");

            bool Loop = true; // To loop until the user has correct input
            string UserInput; // To store the input so the lesson continues when the user is ready

            /// あ Vowel----------------------------------------------------------------------------------------------------------
            while (Loop == true)
            {
                Console.WriteLine("\nThe first vowel we will cover is あ.");
                // Delay for 200ms - ADD THIS - NO IDEA HOW THOUGH -------------------------------------------------------------------
                Console.WriteLine("\nThis vowel is pronunced as 'ah' and is wrote as 'a' within Romanji.");
                Console.WriteLine("Note: japanese is a faster language so this sounds is quite quick!");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper(); // Takes input and makes it uppercase
                UserInput = UserInput.Substring(0, 1); // Replaces that data for the first letter

                switch (UserInput)
                {
                    case "C":
                        Loop = false; // To break the loop - Works
                        break;

                    case "Q":
                        return; // Should break out of the loop - Works
                        break;

                    default:
                        Console.WriteLine("Oops! Looks like the wrong infomation was entered!");
                        break;
                }
            }
            Loop = true; // Reset the variable for next letter

            ///-------------------------------------------------------------------------------------------------------------------
            /// い Vowel----------------------------------------------------------------------------------------------------------
            while (Loop == true)
            {
                Console.WriteLine("\nThe first vowel we will cover is い.");
                // Delay for 200ms - ADD THIS - NO IDEA HOW THOUGH -------------------------------------------------------------------
                Console.WriteLine("\nThis vowel is pronunced as 'i' not as 'eye'.");
                Console.WriteLine("This is wrote in Romanji as 'i'");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper(); // Takes input and makes it uppercase
                UserInput = UserInput.Substring(0, 1); // Replaces that data for the first letter

                switch (UserInput)
                {
                    case "C":
                        Loop = false; // To break the loop - Works
                        break;

                    case "Q":
                        return; // Should break out of the loop - Works
                        break;

                    default:
                        Console.WriteLine("Oops! Looks like the wrong infomation was entered!");
                        break;
                }
            }
            Loop = true; // Reset the variable for next letter

            ///-------------------------------------------------------------------------------------------------------------------
            /// う Vowel----------------------------------------------------------------------------------------------------------
            while (Loop == true)
            {
                Console.WriteLine("\nThe first vowel we will cover is う.");
                // Delay for 200ms - ADD THIS - NO IDEA HOW THOUGH -------------------------------------------------------------------
                Console.WriteLine("\nThis vowel is pronunced as 'uu' or 'muu' without the 'mm' sound");
                Console.WriteLine("This is wrote in Romanji as 'u'");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper(); // Takes input and makes it uppercase
                UserInput = UserInput.Substring(0, 1); // Replaces that data for the first letter

                switch (UserInput)
                {
                    case "C":
                        Loop = false; // To break the loop - Works
                        break;

                    case "Q":
                        return; // Should break out of the loop - Works
                        break;

                    default:
                        Console.WriteLine("Oops! Looks like the wrong infomation was entered!");
                        break;
                }
            }
            Loop = true; // Reset the variable for next letter

            ///-------------------------------------------------------------------------------------------------------------------
            /// え Vowel----------------------------------------------------------------------------------------------------------
            while (Loop == true)
            {
                Console.WriteLine("\nThe first vowel we will cover is え.");
                // Delay for 200ms - ADD THIS - NO IDEA HOW THOUGH -------------------------------------------------------------------
                Console.WriteLine("\nThis vowel is pronunced as 'eh' as if you were shrugging your shoulders");
                Console.WriteLine("This is wrote in Romanji as 'e'");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper(); // Takes input and makes it uppercase
                UserInput = UserInput.Substring(0, 1); // Replaces that data for the first letter

                switch (UserInput)
                {
                    case "C":
                        Loop = false; // To break the loop - Works
                        break;

                    case "Q":
                        return; // Should break out of the loop - Works
                        break;

                    default:
                        Console.WriteLine("Oops! Looks like the wrong infomation was entered!");
                        break;
                }
            }
            Loop = true; // Reset the variable for next letter
            ///-------------------------------------------------------------------------------------------------------------------
            /// う Vowel----------------------------------------------------------------------------------------------------------
            while (Loop == true)
            {
                Console.WriteLine("\nThe first vowel we will cover is お.");
                // Delay for 200ms - ADD THIS - NO IDEA HOW THOUGH -------------------------------------------------------------------
                Console.WriteLine("\nThis vowel is pronunced like the word 'orange' but just the 'o' sound!");
                Console.WriteLine("This is wrote in Romanji as 'o'");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper(); // Takes input and makes it uppercase
                UserInput = UserInput.Substring(0, 1); // Replaces that data for the first letter

                switch (UserInput)
                {
                    case "C":
                        Class1Test(); // Run the test method

                        Loop = false; // To break the loop - Works
                        break;

                    case "Q":
                        return; // Should break out of the loop - Works
                        break;

                    default:
                        Console.WriteLine("Oops! Looks like the wrong infomation was entered!");
                        break;
                }
            }
            Loop = true; // Reset the variable for next letter
        }

        public static void Class2() // The japanese hiragana class 2 function
        {
        }

        public static void Class3() // The japanese hiragana class 3 function
        {
        }

        public static void Class4() // The japanese hiragana class 4 function
        {
        }

        public static void Class5() // The japanese hiragana class 5 function
        {
        }
        //---------------------------------------------------------------
        //---------------------------------------------------------------
        #endregion

        #region Hiragana Class Tests (1-5)
        public static void Class1Test()
        {
            /// These are two lists - Questions,Answers.
            /// These are parrel lists - Index for question/answer are the same!
            /// 
            List<string> FirstIterationQuestion = new List<string>(); // Contains Question letters
            List<string> FirstIterationAnswer = new List<string>(); // Contains Answers phrases

            /// Same thing but again so the user will have to get the answer right
            /// for each character twice 
            List<string> SecondIterationQuestion = new List<string>(); // if correct the letter will be moved into here to be tested again
            List<string> SecondIterationAnswer = new List<string>();

            /// A place to store the completed characters and answers when the
            /// MAY NOT NEED THIS!! 
            /// WITHOUT IT THIS FIXES THE CLEANING ISSUE ----------------------------------------------------------------------------------
            List<string> CompletedIteration = new List<string>(); // If the user gets it right again the letter will be moved into here where it wont be shown again

            //-------------------------------------------------
            //-------------------------------------------------

            #region Adding elements to the lists
            /// Adding the elements in the first question and answer list
            /// MAY BE ABLE TO TURN THIS PROCESS INTO A METHOD ----------------------------------------------------------------------------
            FirstIterationQuestion.Add("あ"); // First question element element - Index 0
            FirstIterationAnswer.Add("A");

            FirstIterationQuestion.Add("い"); // Index 1 
            FirstIterationAnswer.Add("I");

            FirstIterationQuestion.Add("う"); // Index 2 
            FirstIterationAnswer.Add("U");

            FirstIterationQuestion.Add("え"); // Index 3 
            FirstIterationAnswer.Add("E");

            FirstIterationQuestion.Add("お"); // Index 4 
            FirstIterationAnswer.Add("O");
            #endregion
            //-------------------------------------------------
            //-------------------------------------------------

            Random RandomIndexGen = new Random(); // Method to make a random number
            int ListCount; // To store the number of elements within the current list
            int RandomIndex; // To store the random index
            bool ListElementLoop = true; // To keep a loop going

            Console.OutputEncoding = System.Text.Encoding.Unicode; // Changing the encoding to unicode to show the hiragana

            // First List 
            while (ListElementLoop == true)
            {
                ListCount = FirstIterationQuestion.Count; // Counts the number of elements and stores it 

                if (ListCount > 0)
                {
                    /// Picks random number between index 0 and max elements (starts at 4 elements)
                    RandomIndex = RandomIndexGen.Next(0, ListCount); // Not sure why the ".Next" needs to be there 

                    /// Writes a letter within the list depending on what the random index number is 
                    Console.WriteLine("What is this character,{0}?", FirstIterationQuestion[RandomIndex]);

                    string UserInput = Console.ReadLine().ToUpper(); // Store the input in this new variable

                    /// Got the answer right 
                    if (FirstIterationAnswer[RandomIndex] == UserInput)
                    {
                        Console.WriteLine("Well done!");
                        /// Adding the question and answer from the two lists into the second group of lists
                        SecondIterationQuestion.Add(FirstIterationQuestion[RandomIndex]);
                        SecondIterationAnswer.Add(FirstIterationAnswer[RandomIndex]);

                        /// Then remove the question and answer character from the current list
                        FirstIterationQuestion.RemoveAt(RandomIndex);
                        FirstIterationAnswer.RemoveAt(RandomIndex);
                    }

                    /// Got the answer wrong
                    else if (FirstIterationAnswer[RandomIndex] != UserInput)
                    {
                        Console.WriteLine("Incorrect, try again!");
                    }

                    /// Error Condition
                    else
                    {
                        Console.WriteLine("The first iteration answer section has gone wrong - Bug");
                    }

                }
                ///----------------------------------------------------------------------------------------------------
                ///----------------------------------------------------------------------------------------------------
                ///----------------------------------------------------------------------------------------------------
                /// This will run when List 1 is empty 
                /// When this happens List 2 will be iterated
                /// 
                else if (ListCount == 0)
                {
                    Console.WriteLine("You got them all right, now do it again!");
                    // Console.WriteLine("Works btw"); // For testing - Works
                    while (ListElementLoop == true)
                    {
                        ListCount = SecondIterationQuestion.Count; // Counts the number of elements and stores it 

                        if (ListCount > 0)
                        {
                            /// Picks random number between index 0 and max elements (starts at 4 elements)
                            RandomIndex = RandomIndexGen.Next(0, ListCount); // Not sure why the ".Next" needs to be there 

                            /// Writes a letter within the list depending on what the random index number is 
                            Console.WriteLine("What is this character,{0}?", SecondIterationQuestion[RandomIndex]);

                            string UserInput = Console.ReadLine().ToUpper(); // Store the input in this new variable

                            //---------------------------------------------------------------------------------
                            /// Got the answer right 
                            if (SecondIterationAnswer[RandomIndex] == UserInput)
                            {
                                Console.WriteLine("Well done!");
                                /// Adding the question and answer from the two lists into the second group of lists
                                CompletedIteration.Add(SecondIterationQuestion[RandomIndex]);
                                CompletedIteration.Add(SecondIterationAnswer[RandomIndex]);

                                /// Then remove the question and answer character from the current list
                                SecondIterationQuestion.RemoveAt(RandomIndex);
                                SecondIterationAnswer.RemoveAt(RandomIndex);
                            }
                            //---------------------------------------------------------------------------------
                            /// Got the answer wrong
                            else if (SecondIterationAnswer[RandomIndex] != UserInput)
                            {
                                Console.WriteLine("Incorrect, try again!");
                            }

                            //---------------------------------------------------------------------------------
                            /// Error Condition
                            else
                            {
                                Console.WriteLine("The second iteration answer section has gone wrong - Bug");
                            }

                            
                            //ListElementLoop = false; // To break the loop and move onto the next iteration list (list 2)
                        }
                        else if (ListCount == 0)
                        {
                            Console.WriteLine("Well Done, you finished the test!!");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("The second iteration list shuffle has gone wrong!!!! - bug");
                        }
                        
                       
                    }
                    return;
                    

                }
            }
        } 
        #endregion
    }
}