using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class TestsForm : Form
    {
        public TestsForm()
        {
            InitializeComponent();
            
            // Setting up the first question
            Program.Questions = QuestionListInUse();
            Program.Answers = AnswerListInUse();

            Program.IndexInUse = rnd.Next(0, Program.Questions.Count);

            QuestionLabel.Text = "What does " + Program.Questions[Program.IndexInUse] + " mean?";
        }

        #region Error Control - Panel not loaded properly label
        /// <summary>
        /// This will show on the form when there has been an error with the panels loading
        /// This should only show if I have not loaded a panel properly
        /// Used for error control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelLoadErrorLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Speed Test Parts

        #region IntroPanel
        private void SpeedTestIntroPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ReadyButton_Click(object sender, EventArgs e)
        {
            SpeedTestIntroPanel.Show();
        }

        #endregion

        #region Main Panel
        private void QuestionLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void AnswerBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            bool AnswerStatus = CheckAnswer(AnswerBox.Text.ToString()); // To store if the answer is correct

            NewQuestionList(Program.Questions, AnswerStatus); // Edits the list (if needed)
            NewAnswerList(Program.Answers, AnswerStatus); // Edits the list (if needed)

            QuestionLabel.Text = NewQuestion();

        }
        #endregion

        #endregion

        #region X button on form
        /// <summary>
        /// This will be run when the user selects the x button on the window
        /// Instead of closing the programm it will take you back to the lesson menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TestsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            HiraganaLesson1 Menu = new HiraganaLesson1();
            this.Hide();
            Menu.Show();
        }
        #endregion


        #region Test Tools

        #region Random Index

        Random rnd = new Random();

        #endregion

        #region List Selector
        /// <summary>
        /// This is find the two lists that the user needs to be tested on the correct infomation
        /// This will take the button set the string var tracking what lesson they came form
        /// and from that using a switch selection return the two appropiate lists
        /// </summary>
        /// <returns></returns>
        public List<string> QuestionListInUse() // Question List
        {
            string LessonContent= Program.UserCameFrom;

            List<string> Questions = new List<string>();
            

            switch (LessonContent)
            {
                case ("L1"):

                    Lesson1QuestionContent(Program.Lesson1Questions);// Adding content to the list

                    Questions = Program.Lesson1Questions;
                    break;
            }
            return Questions;
            
        }

        public List<string> AnswerListInUse() // Answer List
        {
            string LessonContent = Program.UserCameFrom;

            
            List<string> Answers = new List<string>();

            switch (LessonContent)
            {
                case ("L1"):
                    Lesson1AnswerContent(Program.Lesson1Answers);// Adding content to the list
                    Answers = Program.Lesson1Answers;
                    break;
            }
            
            return Answers;
        }
        #endregion
        #region Question Constructor
        /// <summary>
        /// This is will generate a new quesiton based on what is LEFT within the list in use
        /// and return a new question
        /// </summary>
        /// <returns></returns>
        string NewQuestion()
        {
            string NewQuesiton;

            Program.IndexInUse = rnd.Next(0, Program.Questions.Count);

            NewQuesiton = "What does " + Program.Questions[Program.IndexInUse] + " mean?";

            return NewQuesiton;
        }
        #endregion
        #region List Constructors

        #region Lesson 1 

        List<string> Lesson1QuestionContent(List<string>QuestionContent)
        {
            QuestionContent.Add("あ");
            QuestionContent.Add("い");
            QuestionContent.Add("う");
            QuestionContent.Add("え");
            QuestionContent.Add("お");
            return QuestionContent;
        }

        List<string> Lesson1AnswerContent(List<string> AnswerContent)
        {
            AnswerContent.Add("A");
            AnswerContent.Add("I");
            AnswerContent.Add("U");
            AnswerContent.Add("E");
            AnswerContent.Add("O");
            return AnswerContent;
        }
        #endregion

        #endregion

        #region List Editors
        List<string> NewQuestionList(List<string> CurrentQuestionList,bool AnswerStatus)
        {
            if (AnswerStatus == true)
            {
                CurrentQuestionList.RemoveAt(Program.IndexInUse);
                return CurrentQuestionList;
            }

            else // Do nothing
            {
                return CurrentQuestionList;
            }
        }

        // Answer Version
        List<string> NewAnswerList(List<string> CurrentAnswerList, bool AnswerStatus)
        {
            if (AnswerStatus == true)
            {
                CurrentAnswerList.RemoveAt(Program.IndexInUse);
                return CurrentAnswerList;
            }

            else // Do nothing
            {
                return CurrentAnswerList;
            }
        }

        #endregion

        #region Check Answer
        /// <summary>
        /// This taking the answer and seeing if it mathces the 
        /// question in the location that we are using at that time
        /// This returns a boolean output
        /// </summary>
        /// <param name="Answer"></param>
        /// <returns></returns>
        bool CheckAnswer(string Answer)
        {
            Answer = Answer.ToUpper();

            if (Answer == Program.Answers[Program.IndexInUse])
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
        #endregion

        #endregion


    }
}
