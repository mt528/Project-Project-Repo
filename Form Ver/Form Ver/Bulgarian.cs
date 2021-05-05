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

                    if (TypedInfo == "") // Error handling 
                    {

                    }

                    TypedInfo = TypedInfo.ToUpper();
                    TypedInfo = TypedInfo.Substring(0, 1);

                    if (UserInfo == true)
                    {
                        BulgarianTextBox.Text += "HELOOOOOOOOO";
                        //switch (TypedInfo)
                        //{
                        //    case "1":
                        //        Class1();

                        //        break;

                        //    case "2":
                        //        break;

                        //    case "3":
                        //        break;


                        //    case "T":
                        //        break;

                        //    case "Q":
                        //        Console.WriteLine("This will take you back to the main menu");
                        //        LoopCondition = 0;
                        //        break;

                        //    default:
                        //        Console.WriteLine("Oops! Looks like the wrong information was entered");
                        //        break;
                        //}
                    }

                    break;

             //while (true) // Keep checking user 
             //{
             
            }
        }

        


        public void Class1()
        {
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


            Console.OutputEncoding = System.Text.Encoding.Unicode;


            //Console.WriteLine("The way the answers will be done is that it will require you to enter the latin version of the letters");
            BulgarianTextBox.Text += "\nThe way the answers will be done is that it will require you to enter the latin version of the letters";
            Console.WriteLine("Latin is a method for writing Bulgarian words/characters with English letters");
            Console.WriteLine("For example:  Здравейте = Zdraveite/hello");
            Console.WriteLine("              З = Z, etc");
            Console.WriteLine("\n");

            Console.WriteLine("The first lesson will have the most common word in Bulgarian");

            bool Loop = true;
            string UserInput;

            while (Loop == true)
            {
                Console.WriteLine("\nThe first syllable we will cover is 'Здра'.");
                Console.WriteLine("\nThis syllable is pronunced as 'Zdra' and is wrote as 'Zdra' within Latin.");
                Console.WriteLine("Note: The Bulgarian language has a sound for every letter.");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper();
                UserInput = UserInput.Substring(0, 1);


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
            Loop = true;

            while (Loop == true)
            {
                Console.WriteLine("\nThe second syllable we will cover is 'вей'.");
                Console.WriteLine("\nThis vowel is pronunced as 'вей' ");
                Console.WriteLine("This is wrote in latin as 'vei'");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper();
                UserInput = UserInput.Substring(0, 1);

                switch (UserInput)
                {
                    case "C":
                        Loop = false;
                        break;

                    case "Q":
                        return;
                        break;

                    default:
                        Console.WriteLine("Oops! Looks like the wrong infomation was entered!");
                        break;
                }
            }
            Loop = true;

            while (Loop == true)
            {
                Console.WriteLine("\nThe third syllable we will cover is 'те'.");
                Console.WriteLine("\nThis syllable is pronounced as 'те'.");
                Console.WriteLine("\nThis is wrote in Latin as 'te'.");
                Console.WriteLine("\nPlease write 'C' to continue or 'Q' to quit");
                UserInput = Console.ReadLine().ToUpper();
                UserInput = UserInput.Substring(0, 1);

                switch (UserInput)
                {
                    case "C":
                        Loop = false;
                        break;

                    case "Q":
                        return;
                        break;

                    default:
                        Console.WriteLine("Oops! Looks like the wrong information was entered!");
                        break;
                }
            }
            Loop = true;
        }
            #endregion



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

        private void BulgarianInputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                UserEnterInfo = true;

                TypedInfo = BulgarianInputTextBox.Text;
                TypedInfo = TypedInfo.ToString();

                ProgramStage = 1; // Next stage
                BulgarianMethod(UserEnterInfo, TypedInfo);

                
            }

        }

    }
}
