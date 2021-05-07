using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class Bulgarian : Form
    {
        bool UserEnterInfo = false;
        string TypedInfo = "";
        int ProgramStage = 0; // To seperate the flow of the program
        int Lesson1Stage = 0; // To seperate the flow of lesson 1 

        public Bulgarian()
        {
            InitializeComponent();

            BulgarianMethod(UserEnterInfo, TypedInfo);
        }

        bool CorrectInfo = false;

        #region Kristiyan's Code
        public void BulgarianMethod(bool UserInfo, string TypedInfo)
        {
            
            switch(ProgramStage) // Switch to determind what to do with inputs based on program stage
            {
                case 0: //  Beginging

                //Console.WriteLine("We have broken the zdraveite intro 3 classes to make it easy to learn");
                BulgarianTextBox.Text = "We have broken the zdraveite intro 3 classes to make it easy to learn";
                //Console.WriteLine("Please select one to start learning");
                BulgarianTextBox.Text += "\nPlease select one to start learning";
                //Console.WriteLine("Classes");
                BulgarianTextBox.Text += "\nClasses";
               // Console.WriteLine("· Class 1");
                BulgarianTextBox.Text += "\n· Class 1";

                    break;

                case 1: // After the first lot of text is printed and user input has been done
                    //int UserLessonNumberSelected; // To store the lesson

                    int NumberEntered = -1;

                    Int32.TryParse(TypedInfo, out NumberEntered);

                   // if (Int32.TryParse(TypedInfo, out UserLessonNumberSelected) == true)  not WORK
                   if (NumberEntered != -1) // Error handling 
                    { // Number was entered

                        CorrectInfo = true; // So the text input text box does not do actions that happen when the input is correct
                        TypedInfo = TypedInfo.ToUpper();
                        TypedInfo = TypedInfo.Substring(0, 1);

                        if (UserInfo == true)
                        {

                            switch (TypedInfo)
                            {
                                case "1": // Lesson 1 
                                    Lesson1Stage = 0; // To reset the Stage counter
                                    BulgarianTextBox.Text += "\nYou have selected Lesson 1";
                                    Class1();
                                    break;

                                case "2":// Lesson 2
                                    break;

                                case "3":// Lesson 3 
                                    break;

                                default:
                                    //Console.WriteLine("Oops! Looks like the wrong information was entered");
                                    BulgarianTextBox.Text += "\nOops! Looks like the wrong information was entered";
                                    ProgramStage = 0; // So the user can start again
                                    break;
                            }
                        }
                    }

                    else
                    {
                        
                        ProgramStage = ProgramStage - 1; // So the program does not get stuck
                        
                        BulgarianTextBox.Text += "\nOops! Looks like the wrong information was entered";
                        ScrollToBottom();
                    }
                            

                    break;

             //while (true) // Keep checking user 
             //{
             
            }
        }

        


        public void Class1()
        {
            //

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            switch (Lesson1Stage)
            {
                case 0:

                  
                    //Console.WriteLine("The way the answers will be done is that it will require you to enter the latin version of the letters");
                    BulgarianTextBox.Text += "\nThe way the answers will be done is that it will require you to enter the latin version of the letters";
                    //Console.WriteLine("Latin is a method for writing Bulgarian words/characters with English letters");
                    BulgarianTextBox.Text += "\nLatin is a method for writing Bulgarian words/characters with English letters";
                    //Console.WriteLine("For example:  Здравейте = Zdraveite/hello");
                    BulgarianTextBox.Text += "\nFor example:  Здравейте = Zdraveite/hello";
                    //Console.WriteLine("              З = Z, etc");
                    BulgarianTextBox.Text += "\n              З = Z, etc";

                    //Console.WriteLine("The first lesson will have the most common word in Bulgarian");
                    BulgarianTextBox.Text += "\nThe first lesson will have the most common word in Bulgarian";

                    //bool Loop = true;
                    //string UserInput;

                    BulgarianTextBox.Text += "\n";
                    //while (Loop == true)
                    //{
                    //    Console.WriteLine("\nThe first syllable we will cover is 'Здра'.");
                    BulgarianTextBox.Text += "\nThe first syllable we will cover is 'Здра'.";

                    //    Console.WriteLine("\nThis syllable is pronunced as 'Zdra' and is wrote as 'Zdra' within Latin.");
                    BulgarianTextBox.Text += "\nThis syllable is pronunced as 'Zdra' and is wrote as 'Zdra' within Latin.";
                    //    Console.WriteLine("Note: The Bulgarian language has a sound for every letter.");
                    BulgarianTextBox.Text += "\nNote: The Bulgarian language has a sound for every letter.";
                    //    Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                    BulgarianTextBox.Text += "\nPlease write 'C' to continue or 'Q' to quit";
                    //    UserInput = Console.ReadLine().ToUpper();
                    //    UserInput = UserInput.Substring(0, 1);

                    ScrollToBottom(); // Focuses the test box to the bottom

                    Lesson1Stage = Lesson1Stage + 1;
                    break;

                case 1: // Checking for continuation answer
                    CheckContinueClass1();
                    
                    break;

                case 2:
                    BulgarianTextBox.Text += "\n";
                    //Console.WriteLine("\nThe second syllable we will cover is 'вей'.");
                    BulgarianTextBox.Text += "\nThe second syllable we will cover is 'вей'.";
                    // Console.WriteLine("\nThis vowel is pronunced as 'вей' ");
                    BulgarianTextBox.Text += "\nThis vowel is pronunced as 'вей' ";
                    //Console.WriteLine("This is wrote in latin as 'vei'");
                    BulgarianTextBox.Text += "\nThis is wrote in latin as 'vei'";
                    //Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                    BulgarianTextBox.Text += "\nPlease write 'C' to continue or 'Q' to quit";

                    ScrollToBottom(); // Focuses the test box to the bottom

                    Lesson1Stage = Lesson1Stage + 1;
                    break;

                case 3: // Checking answer
                    CheckContinueClass1();
                    
                    break;

                case 4:

                    BulgarianTextBox.Text += "\n";
                    //Console.WriteLine("\nThe third syllable we will cover is 'те'.");
                    BulgarianTextBox.Text += "\nThe third syllable we will cover is 'те'.";
                    //Console.WriteLine("\nThis syllable is pronounced as 'те'.");
                    BulgarianTextBox.Text += "\nThis syllable is pronounced as 'те'.";
                    //Console.WriteLine("\nThis is wrote in Latin as 'te'.");
                    BulgarianTextBox.Text += "\nThis is wrote in Latin as 'te'.";
                    //Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                    BulgarianTextBox.Text += "\nPlease write 'C' to continue or 'Q' to quit";

                    ScrollToBottom(); // Focuses the test box to the bottom
                    Lesson1Stage = Lesson1Stage + 1;     
                    break;

                case 5://Checking Answer
                    CheckContinueClass1();
                    break;

                case 6:
                    BulgarianTextBox.Text += "\n";
                    BulgarianTextBox.Text += "\n";
                    BulgarianTextBox.Text += "\nNow, are you read for a test?";
                    BulgarianTextBox.Text += "\nPlease write 'C' to continue or 'Q' to quit";
                    ScrollToBottom(); // Focuses the test box to the bottom

                    Lesson1Stage += 1;
                    break;
                    
                case 7: 
                    CheckContinueClass1();
                    break;

                case 8:
                    BulgarianTextBox.Text += "\n"; //To skip a line 
                    BulgarianTextBox.Text += "\nStarting Class 1 Test";
                    ScrollToBottom();
                    Class1Test();
                    Lesson1Stage = 9; // so the test can repeat
                    break;

                case 9:
                    Class1Test();
                    break;
            }

          
        }

        #endregion

        #region Class 1 Test
        bool TestStarting = true;
        List<string> FirstIterationQuestion = new List<string>();
        List<string> FirstIterationAnswer = new List<string>();

        List<string> SecondIterationQuestion = new List<string>();
        List<string> SecondIterationAnswer = new List<string>();


        List<string> CompletedIteration = new List<string>();


        int RandomIndex = -1;

        void Class1Test()
        {
           
            if (TestStarting == true) // So the construction of data is done once
            {
                #region add content to the list
                

                FirstIterationQuestion.Add("Здра");
                FirstIterationAnswer.Add("Zdra");

                FirstIterationQuestion.Add("вей");
                FirstIterationAnswer.Add("vei");

                FirstIterationQuestion.Add("те");
                FirstIterationAnswer.Add("te");
                #endregion 
                TestStarting = false; // It doesnt repeat
                
            }
            Random RandomIndexGen = new Random();
            int ListCount;

            Console.OutputEncoding = System.Text.Encoding.Unicode;

                
            ListCount = FirstIterationQuestion.Count;
            #region First Iteration of lists
            #region Make Quesiton (First Time)
            if (ListCount > 0 && RandomIndex == -1) // Making the quesiton
            {
                RandomIndex = RandomIndexGen.Next(0, ListCount);

                //Console.WriteLine("What is this character,{0}?", FirstIterationQuestion[RandomIndex]);
                BulgarianTextBox.Text += $"\n"; 
                BulgarianTextBox.Text += $"\n"; 
                BulgarianTextBox.Text += $"\nWhat is this character, {FirstIterationQuestion[RandomIndex]}?"; // Works
                ScrollToBottom();
            }
            #endregion

            #region Check Answer
            else if (ListCount > 0 && RandomIndex != -1) // Checking the answer
            {
                if (TypedInfo == FirstIterationAnswer[RandomIndex]) // Correct answer
                {
                    BulgarianTextBox.Text += "\n Correct";
                    ScrollToBottom();

                    // remove the quesiton and answer that was correct
                    FirstIterationQuestion.RemoveAt(RandomIndex);
                    FirstIterationAnswer.RemoveAt(RandomIndex);
                    RandomIndex = -1; // To allow the program to generate a new question
                }

                else // Wrong answer
                {
                    BulgarianTextBox.Text += "\n Wrong";
                    ScrollToBottom();
                    RandomIndex = -1; // To allow the program to generate a new question
                }

                //------------------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------------------
                //------------------------------------------------------------------------------------------------

                if (FirstIterationQuestion.Count > 0) // More question are needed
                {
                    Class1Test();
                }

                else // When the test is done
                {
                    
                    ScrollToBottom();

                    ProgramStage = 0; // To take the user to the main menu
                    TypedInfo = "";

                    BulgarianTextBox.Text += "\n You have finished the test!";

                    BulgarianMethod(UserEnterInfo, TypedInfo);
                }
            }
            #endregion


            #endregion

            //string UserInput = Console.ReadLine().ToUpper();


            //if (FirstIterationAnswer[RandomIndex] == UserInput)
            //{
            //    Console.WriteLine("Well done!");
            //    SecondIterationQuestion.Add(FirstIterationQuestion[RandomIndex]);
            //    SecondIterationAnswer.Add(FirstIterationAnswer[RandomIndex]);

            //    FirstIterationQuestion.RemoveAt(RandomIndex);
            //    FirstIterationAnswer.RemoveAt(RandomIndex);
            //}

            //else if (FirstIterationAnswer[RandomIndex] != UserInput)
            //{
            //    Console.WriteLine("Incorrect, try again!");
            //}

            //else
            //{
            //    Console.WriteLine("The first iteration answer section has gone wrong - Bug");
            //}





            //else if (ListCount == 0)
            //{
            //    Console.WriteLine("You got them all right, now do it again!");
            //    while (ListElementLoop == true)
            //    {
            //        ListCount = SecondIterationQuestion.Count;

            //        if (ListCount > 0)
            //        {
            //            RandomIndex = RandomIndexGen.Next(0, ListCount);

            //            Console.WriteLine("What is this character,{0}?", SecondIterationQuestion[RandomIndex]);

            //            string UserInput = Console.ReadLine().ToUpper();


            //            if (SecondIterationAnswer[RandomIndex] == UserInput)
            //            {
            //                Console.WriteLine("Well done!");
            //                CompletedIteration.Add(SecondIterationQuestion[RandomIndex]);
            //                CompletedIteration.Add(SecondIterationAnswer[RandomIndex]);

            //                /// Then remove the question and answer character from the current list
            //                SecondIterationQuestion.RemoveAt(RandomIndex);
            //                SecondIterationAnswer.RemoveAt(RandomIndex);
            //            }
            //            //---------------------------------------------------------------------------------
            //            /// Got the answer wrong
            //            else if (SecondIterationAnswer[RandomIndex] != UserInput)
            //            {
            //                Console.WriteLine("Incorrect, try again!");
            //            }

            //            //---------------------------------------------------------------------------------
            //            /// Error Condition
            //            else
            //            {
            //                Console.WriteLine("The second iteration answer section has gone wrong - Bug");
            //            }



            //        }
            //        else if (ListCount == 0)
            //        {
            //            Console.WriteLine("Well Done, you finished the test!");
            //            return;
            //        }
            //        else
            //        {
            //            Console.WriteLine("The second iteration list shuffle has gone wrong!! - bug");
            //        }


            //    }
            //    return;


            //}

        }

        #endregion

        #region Go Back Button
        /// <summary>
        /// This will close the form and load the menu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BulgarianBackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm Form = new MainMenuForm();
            this.Hide();
            Form.Show();
        }
        #endregion

        #region Form is closed via cross
        private void Bulgarian_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Closes the programme 
        }
        #endregion

        #region Text Box Scroll to bottom
        // This will scroll to the bottom of the text box
        void ScrollToBottom()
        {
            BulgarianTextBox.SelectionStart = BulgarianTextBox.Text.Length;
            BulgarianTextBox.ScrollToCaret();
        }
        #endregion

        #region Check if continue
        void CheckContinueClass1()
        {
            // Looking for user input
            if (TypedInfo.ToUpper() == "C") // Continue
            {
 
                Lesson1Stage = Lesson1Stage + 1;
                ScrollToBottom(); // Focuses the test box to the bottom 
                Class1();
            }

            else if (TypedInfo.ToUpper() == "Q") // Quit lesson 1
            {
                // Go back to main menu stage
                ProgramStage = 0; // To take the user to the main menu
                TypedInfo = "";


                BulgarianMethod(UserEnterInfo, TypedInfo);
            }

            else // Error
            {
                BulgarianTextBox.Text += "\nOops! Looks like the wrong information was entered";
                ScrollToBottom();
            }
        }
        #endregion

        #region User Inputs
        private void BulgarianInputTextBox_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyData == Keys.Enter)
            {
                switch (ProgramStage) // Switch to determind what to do with inputs based on program stage
                {
                    case 0: // Stage 0 - At begining

                        
                        UserEnterInfo = true;

                        TypedInfo = BulgarianInputTextBox.Text;
                        TypedInfo = TypedInfo.ToString();

                       // if (CorrectInfo == true) // To avoid errors if the user eneter WRONG info
                      //  {
                            ProgramStage = 1; // Next stage
                            BulgarianMethod(UserEnterInfo, TypedInfo);
                            BulgarianInputTextBox.Text = ""; // Clean
                       // }

                        break;

                    case 1: // Stage 1

                        TypedInfo = BulgarianInputTextBox.Text;
                        TypedInfo = TypedInfo.ToString();

                        #region Lesson 1 Stages

                        switch (Lesson1Stage)
                        {
                            case 1:
                                Class1();
                                break;
                            case 3:
                                Class1();
                                break;

                            case 4:
                                Class1();
                                break;
                            case 5:
                                Class1();
                                
                                break;
                            case 6:
                                
                                Class1();
                                break;
                            case 7:
                                Class1();
                                
                                break;

                            case 9:
                                Class1Test();
                                break;

                        }
                        #endregion
  
                        BulgarianInputTextBox.Text = ""; // Clean
                        break;
                }
                
            }

        }

        #endregion

    }
}
