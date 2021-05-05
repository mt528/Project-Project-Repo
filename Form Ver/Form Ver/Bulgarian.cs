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

        

        #region Kristiyan's Code
        public void BulgarianMethod(bool UserInfo, string TypedInfo)
        {
            switch(ProgramStage)
            {
                case 0:
                //Console.WriteLine("We have broken the zdraveite intro 3 classes to make it easy to learn");
                BulgarianTextBox.Text = "We have broken the zdraveite intro 3 classes to make it easy to learn";
                //Console.WriteLine("Please select one to start learning");
                BulgarianTextBox.Text += "\nPlease select one to start learning";
                //Console.WriteLine("Classes");
                BulgarianTextBox.Text += "\nClasses";
               // Console.WriteLine("· Class 1");
                BulgarianTextBox.Text += "\n· Class 1";

                    break;

                case 1:
                    int UserLessonNumberSelected; // To store the lesson

                    if (Int32.TryParse(TypedInfo, out UserLessonNumberSelected) == true) // Error handling 
                    {
                        TypedInfo = TypedInfo.ToUpper();
                        TypedInfo = TypedInfo.Substring(0, 1);

                        if (UserInfo == true)
                        {

                            switch (TypedInfo)
                            {
                                case "1":
                                    BulgarianTextBox.Text += "\nYou have selected Lesson 1";
                                    Class1();
                                    break;

                                case "2":
                                    break;

                                case "3":
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
                        BulgarianTextBox.Text += "\nOops! Looks like the wrong information was entered";
                    }
                            

                    break;

             //while (true) // Keep checking user 
             //{
             
            }
        }

        


        public void Class1()
        {
            

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            switch (Lesson1Stage)
            {
                case 0:

                    #region Creating Lists
                    List<string> FirstIterationQuestion = new List<string>();
                    List<string> FirstIterationAnswer = new List<string>();

                    List<string> SecondIterationQuestion = new List<string>();
                    List<string> SecondIterationAnswer = new List<string>();




                    List<string> CompletedIteration = new List<string>();

                    #region Adding elements to the lists


                    FirstIterationQuestion.Add("Здра");
                    FirstIterationAnswer.Add("Zdra");

                    FirstIterationQuestion.Add("вей");
                    FirstIterationAnswer.Add("vei");

                    FirstIterationQuestion.Add("те");
                    FirstIterationAnswer.Add("te");

                    #endregion
                    #endregion

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
                    
                    //Console.WriteLine("\nThe third syllable we will cover is 'те'.");
                    BulgarianTextBox.Text += "\nThe third syllable we will cover is 'те'.";
                    //Console.WriteLine("\nThis syllable is pronounced as 'те'.");
                    BulgarianTextBox.Text += "\nThis syllable is pronounced as 'те'.";
                    //Console.WriteLine("\nThis is wrote in Latin as 'te'.");
                    BulgarianTextBox.Text += "\nThis is wrote in Latin as 'te'.";
                    //Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                    BulgarianTextBox.Text += "\nPlease write 'C' to continue or 'Q' to quit";

                    ScrollToBottom(); // Focuses the test box to the bottom

                    break;

                case 5://Checking Answer
                    CheckContinueClass1();
                    break;

                case 6:
                    BulgarianTextBox.Text += "\nNow, are you read for a test?";
                    ScrollToBottom(); // Focuses the test box to the bottom
                    break;
                    //----------------------------------------FINISH--------------------------------------
                   // ----------------------------------------FINISH--------------------------------------
                     //   ----------------------------------------FINISH--------------------------------------
                    //    ----------------------------------------FINISH--------------------------------------
                    //    ----------------------------------------FINISH--------------------------------------
                case 7: //Check Answer ----------------------------------------FINISH--------------------------------------

                    break;
            }



            


            //    switch (UserInput)
            //    {
            //        case "C":
            //            Loop = false;
            //            break;

            //        case "Q":
            //            return;
            //            break;

            //        default:
            //            Console.WriteLine("Oops! Looks like the wrong information was entered!");
            //            break;
            //    }
            //}
            //Loop = true;
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
                ProgramStage = ProgramStage - 1; // Go back to main menu stage
                BulgarianMethod(UserEnterInfo, TypedInfo);
            }

            else // Error
            {
                BulgarianTextBox.Text += "\nOops! Looks like the wrong information was entered";
            }
        }
        #endregion

        private void BulgarianInputTextBox_KeyDown(object sender, KeyEventArgs e)
        
        {
            if (e.KeyData == Keys.Enter)
            {
                switch (ProgramStage)
                {
                    case 0: // Stage 0
                        UserEnterInfo = true;

                        TypedInfo = BulgarianInputTextBox.Text;
                        TypedInfo = TypedInfo.ToString();

                        ProgramStage = 1; // Next stage
                        BulgarianMethod(UserEnterInfo, TypedInfo);
                        BulgarianInputTextBox.Text = ""; // Clean


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

                        }
                        #endregion
  
                        BulgarianInputTextBox.Text = ""; // Clean
                        break;
                }
                
            }

        }

    }
}
