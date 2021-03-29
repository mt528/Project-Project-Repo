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
            Program.TestDone = false; // To restart the state incase the user does more than 1 test

            InitializeComponent();
            SpeedTestPanel.Hide();
            TestDonePanel.Hide();
            
            // Setting up the first question
            Program.Questions = QuestionListInUse();
            Program.Answers = AnswerListInUse();

            Program.IndexInUse = rnd.Next(0, Program.Questions.Count);

            QuestionLabel.Text = "What does " + Program.Questions[Program.IndexInUse] + " mean?";

           // AnswerBox.Select();
           // this.ActiveControl = AnswerBox;
           // AnswerBox.Focus();

        }

        //---------------------------------------------------------------------------------------
        // Error Control Parts
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
        //---------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------
        // Panel Parts
        #region Speed Test Parts

        #region IntroPanel
        private void SpeedTestIntroPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// This will run when the ready button is pressed
        /// This will show the Test Panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadyButton_Click(object sender, EventArgs e)
        {
            SpeedTestPanel.Show(); // To show the test panel

            AnswerBox.Focus(); // Sets the texbox as the cursor focus

            timer1.Start(); // Starts the timer
        }

        #endregion

        #region Main Panel
        private void SpeedTestPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void QuestionLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void AnswerBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckButton_Click(object sender, EventArgs e)
        
        {
            bool AnswerStatus = CheckAnswer(AnswerBox.Text.ToString()); // To store if the answer is correct

            AnswerCorrectWrongCount(AnswerStatus); // Method to update the correct/wrong counters

            AnswerBox.Text = ""; // Empty the text box

            NewQuestionList(Program.Questions, AnswerStatus); // Edits the list (if needed)
            NewAnswerList(Program.Answers, AnswerStatus); // Edits the list (if needed)

            
            
            /// This will happen when the list is empty
            /// It will rebuild the
            if (Program.Questions.Count == 0 && Program.TestDone == false)
            {
                /// To refil the lists ONCE when it is empty
                Program.Questions = QuestionListInUse();
                Program.Answers = AnswerListInUse();

                Program.TestDone = true; // To finish the test when this list is empty

                //AnswerBox.Focus();
            }

            /// This will run when the test if over
            if (Program.Questions.Count == 0 && Program.TestDone == true)
            {
                EndOfTest(); // To build the last panel correctly 

            }

            /// This will run when the conditions are not met
            /// It will generate a new question
            else
            {
                QuestionLabel.Text = NewQuestion();
            }
            

            
            
            

        }

        #region Enter Key code - Text Box
        /// <summary>
        /// This will run the enter key is pressed in the text box
        /// This will activate the check answer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnswerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckButton_Click(this, new EventArgs());
            }
            
        }
        #endregion

        #region Correct/Wrong Answer Count - Labels
        private void SpeedTestCorrectAnswerLabel_Click(object sender, EventArgs e)
        {

        }

        private void SpeedTestWrongAnswerLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Time Taken Label - During Test
        private void TimeTakenLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion 

        #endregion

        #region Test Done Panel Objects
        private void TestDoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void TestDoneButton_Click(object sender, EventArgs e)
        {
            HiraganaMenu Menu = new HiraganaMenu();

            AnswerCountReset(); // This will reset the variables that store the answer 
            

            this.Hide();
            Menu.Show();

            Program.TimerValue = 0; // Resets the value
        }

        #region Statistics Labels
        private void AnswerCorrectCountLabel_Click(object sender, EventArgs e)
        {

        }

        private void WrongCorrectCountLabel_Click(object sender, EventArgs e)
        {

        }
        private void AnswerAccuracyLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Time Result Label
        //---------------------------------------------------------------------------------------
        private void TimeResultLabel_Click(object sender, EventArgs e)
        {
            
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
            HiraganaMenu Menu = new HiraganaMenu();

            AnswerCountReset(); // Resets the answer count vars

            this.Hide();
            Menu.Show();

            Program.TimerValue = 0; // Reset the value of the timer
        }
        #endregion

        #endregion
        //---------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------
        // Methods that do test functions
        #region Test Tools

        #region Random Index

        Random rnd = new Random();

        #endregion


        #region List Selector
        //---------------------------------------------------------------------------------------
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

                case ("L2"):
                    Lesson2QuestionContent(Program.Lesson2Questions);// Adding content to the list

                    Questions = Program.Lesson2Questions;
                    break;

                case ("L3"):
                    Lesson3QuestionContent(Program.Lesson3Questions);// Adding content to the list

                    Questions = Program.Lesson3Questions;
                    break;

                case ("L4"):
                    Lesson4QuestionContent(Program.Lesson4Questions);// Adding content to the list

                    Questions = Program.Lesson4Questions;
                    break;

                case ("L5"):
                    Lesson5QuestionContent(Program.Lesson5Questions);// Adding content to the list

                    Questions = Program.Lesson5Questions;
                    break;

                case ("L6"):
                    Lesson6QuestionContent(Program.Lesson6Questions);// Adding content to the list

                    Questions = Program.Lesson6Questions;
                    break;

                case ("L7"):
                    Lesson7QuestionContent(Program.Lesson7Questions);// Adding content to the list

                    Questions = Program.Lesson7Questions;
                    break;

                case ("L8"):
                    Lesson8QuestionContent(Program.Lesson8Questions);// Adding content to the list

                    Questions = Program.Lesson8Questions;
                    break;

                case ("TEST"):
                    TestQuestionContent(Program.TestQuestions);// Adding content to the list

                    Questions = Program.TestQuestions;
                    break;
            }
            return Questions;
            
        }

        //---------------------------------------------------------------------------------------
        // Answer List
        public List<string> AnswerListInUse() 
        {
            string LessonContent = Program.UserCameFrom;

            
            List<string> Answers = new List<string>();

            switch (LessonContent)
            {
                case ("L1"):
                    Lesson1AnswerContent(Program.Lesson1Answers);// Adding content to the list
                    Answers = Program.Lesson1Answers;
                    break;

                case ("L2"):
                    Lesson2AnswerContent(Program.Lesson2Answers);// Adding content to the list
                    Answers = Program.Lesson2Answers;
                    break;

                case ("L3"):
                    Lesson3AnswerContent(Program.Lesson3Answers);// Adding content to the list
                    Answers = Program.Lesson3Answers;
                    break;

                case ("L4"):
                    Lesson4AnswerContent(Program.Lesson4Answers);// Adding content to the list
                    Answers = Program.Lesson4Answers;
                    break;

                case ("L5"):
                    Lesson5AnswerContent(Program.Lesson5Answers);// Adding content to the list
                    Answers = Program.Lesson5Answers;
                    break;

                case ("L6"):
                    Lesson6AnswerContent(Program.Lesson6Answers);// Adding content to the list
                    Answers = Program.Lesson6Answers;
                    break;

                case ("L7"):
                    Lesson7AnswerContent(Program.Lesson7Answers);// Adding content to the list
                    Answers = Program.Lesson7Answers;
                    break;

                case ("L8"):
                    Lesson8AnswerContent(Program.Lesson8Answers);// Adding content to the list
                    Answers = Program.Lesson8Answers;
                    break;

                case ("TEST"):
                    TestAnswerContent(Program.TestAnswers);// Adding content to the list
                    Answers = Program.TestAnswers;
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
        
        #region Lesson 2
        List<string> Lesson2QuestionContent(List<string> QuestionContent)
        {
            // K's ------------------------
            QuestionContent.Add("か");
            QuestionContent.Add("き");
            QuestionContent.Add("く");
            QuestionContent.Add("け");
            QuestionContent.Add("こ");
            //-----------------------------
            // S's ------------------------
            QuestionContent.Add("さ");
            QuestionContent.Add("し");
            QuestionContent.Add("す");
            QuestionContent.Add("せ");
            QuestionContent.Add("そ");
            //-----------------------------
            return QuestionContent;
        }

        List<string> Lesson2AnswerContent(List<string> AnswerContent)
        {
            // K's ------------------------
            AnswerContent.Add("KA");
            AnswerContent.Add("KI");
            AnswerContent.Add("KU");
            AnswerContent.Add("KE");
            AnswerContent.Add("KO");
            //-----------------------------
            // S's ------------------------
            AnswerContent.Add("SA");
            AnswerContent.Add("SHI");
            AnswerContent.Add("SU");
            AnswerContent.Add("SE");
            AnswerContent.Add("SO");
            //-----------------------------
            return AnswerContent;
        }
        //-----------------------------------------------------------
        //-----------------------------------------------------------
        //-----------------------------------------------------------
        #endregion

        #region Lesson 3
        List<string> Lesson3QuestionContent(List<string> QuestionContent)
        {
            // T's ------------------------
            QuestionContent.Add("た");
            QuestionContent.Add("ち");
            QuestionContent.Add("つ");
            QuestionContent.Add("て");
            QuestionContent.Add("と");
            //-----------------------------
            // N's ------------------------
            QuestionContent.Add("な");
            QuestionContent.Add("に");
            QuestionContent.Add("ぬ");
            QuestionContent.Add("ね");
            QuestionContent.Add("の");
            //-----------------------------
            return QuestionContent;
        }

        List<string> Lesson3AnswerContent(List<string> AnswerContent)
        {
            // T's ------------------------
            AnswerContent.Add("TA");
            AnswerContent.Add("CHI");
            AnswerContent.Add("TSU"); // FIXED
            AnswerContent.Add("TE");
            AnswerContent.Add("TO");
            //-----------------------------
            // N's ------------------------
            AnswerContent.Add("NA");
            AnswerContent.Add("NI");
            AnswerContent.Add("NU");
            AnswerContent.Add("NE");
            AnswerContent.Add("NO");
            //-----------------------------
            return AnswerContent;
        }
        #endregion

        #region Lesson 4
        List<string> Lesson4QuestionContent(List<string> QuestionContent)
        {
            // H's ------------------------
            QuestionContent.Add("は");
            QuestionContent.Add("ひ");
            QuestionContent.Add("ふ");
            QuestionContent.Add("へ");
            QuestionContent.Add("ほ");
            //-----------------------------
            // M's ------------------------
            QuestionContent.Add("ま");
            QuestionContent.Add("み");
            QuestionContent.Add("む");
            QuestionContent.Add("め");
            QuestionContent.Add("も");
            //-----------------------------
            return QuestionContent;
        }

        List<string> Lesson4AnswerContent(List<string> AnswerContent)
        {
            // H's ------------------------
            AnswerContent.Add("HA");
            AnswerContent.Add("HI");
            AnswerContent.Add("FU");
            AnswerContent.Add("HE");
            AnswerContent.Add("HO");
            //-----------------------------
            // M's ------------------------
            AnswerContent.Add("MA");
            AnswerContent.Add("MI");
            AnswerContent.Add("MU");
            AnswerContent.Add("ME");
            AnswerContent.Add("MO");
            //-----------------------------
            return AnswerContent;
        }
        #endregion

        #region Lesson 5

        List<string> Lesson5QuestionContent(List<string> QuestionContent)
        {
            // Y's ------------------------
            QuestionContent.Add("や");
            QuestionContent.Add("ゆ");
            QuestionContent.Add("よ");
            //-----------------------------
            // R's ------------------------
            QuestionContent.Add("ら");
            QuestionContent.Add("り");
            QuestionContent.Add("る");
            QuestionContent.Add("れ");
            QuestionContent.Add("ろ");
            //-----------------------------
            // Wa's -----------------------
            QuestionContent.Add("わ");
            QuestionContent.Add("を");
            //-----------------------------
            // N --------------------------
            QuestionContent.Add("ん");
            return QuestionContent;
        }

        List<string> Lesson5AnswerContent(List<string> AnswerContent)
        {
            // Y's ------------------------
            AnswerContent.Add("YA");
            AnswerContent.Add("YU");
            AnswerContent.Add("YO");
            //-----------------------------
            // R's ------------------------
            AnswerContent.Add("RA");
            AnswerContent.Add("RI");
            AnswerContent.Add("RU");
            AnswerContent.Add("RE");
            AnswerContent.Add("RO");
            //-----------------------------
            // Wa's -----------------------
            AnswerContent.Add("WA");
            AnswerContent.Add("WO");
            //-----------------------------
            // N --------------------------
            AnswerContent.Add("N");

            return AnswerContent;
        }
        #endregion

        #region Lesson 6
        List<string> Lesson6QuestionContent(List<string> QuestionContent)
        {
            // G's ------------------------
            QuestionContent.Add("が");
            QuestionContent.Add("ぎ");
            QuestionContent.Add("ぐ");
            QuestionContent.Add("げ");
            QuestionContent.Add("ご");
            //-----------------------------
            // Z's ------------------------
            QuestionContent.Add("ざ");
            QuestionContent.Add("じ");
            QuestionContent.Add("ず");
            QuestionContent.Add("ぜ");
            QuestionContent.Add("ぞ");
            //-----------------------------
            // D's -----------------------
            QuestionContent.Add("だ");
            QuestionContent.Add("ぢ");
            QuestionContent.Add("づ");
            QuestionContent.Add("で");
            QuestionContent.Add("ど");

            return QuestionContent;
        }

        List<string> Lesson6AnswerContent(List<string> AnswerContent)
        {
            // G's ------------------------
            AnswerContent.Add("GA");
            AnswerContent.Add("JI"); // FIXED
            AnswerContent.Add("GU");
            AnswerContent.Add("GE");
            AnswerContent.Add("GO");
            //-----------------------------
            // Z's ------------------------
            AnswerContent.Add("ZA");
            AnswerContent.Add("JI");
            AnswerContent.Add("ZU");
            AnswerContent.Add("ZE");
            AnswerContent.Add("ZO");
            //-----------------------------
            // D's -----------------------
            AnswerContent.Add("DA");
            AnswerContent.Add("DI");
            AnswerContent.Add("DU");
            AnswerContent.Add("DE");
            AnswerContent.Add("DO");

            return AnswerContent;

        }

        #endregion

        #region Lesson 7
        List<string> Lesson7QuestionContent(List<string> QuestionContent)
        {
            // BA's ------------------------
            QuestionContent.Add("ば");
            QuestionContent.Add("び");
            QuestionContent.Add("ぶ");
            QuestionContent.Add("べ");
            QuestionContent.Add("ぼ");
            //-----------------------------
            // PO's ------------------------
            QuestionContent.Add("ぱ");
            QuestionContent.Add("ぴ");
            QuestionContent.Add("ぷ");
            QuestionContent.Add("ぺ");
            QuestionContent.Add("ぽ");

            return QuestionContent;
        }

        List<string> Lesson7AnswerContent(List<string> AnswerContent)
        {
            // BA's ------------------------
            AnswerContent.Add("BA");
            AnswerContent.Add("BI");
            AnswerContent.Add("BU");
            AnswerContent.Add("BE");
            AnswerContent.Add("BO");
            //-----------------------------
            // PO's ------------------------
            AnswerContent.Add("PA");
            AnswerContent.Add("PI");
            AnswerContent.Add("PU");
            AnswerContent.Add("PE");
            AnswerContent.Add("PO");

            return AnswerContent;

        }
        #endregion

        #region Lesson 8
        List<string> Lesson8QuestionContent(List<string> QuestionContent)
        {
            // K's ------------------------
            QuestionContent.Add("きゃ");
            QuestionContent.Add("きゅ");
            QuestionContent.Add("きょ");
            //-----------------------------
            // SH's ------------------------
            QuestionContent.Add("しゃ");
            QuestionContent.Add("しゅ");
            QuestionContent.Add("しょ");
            //-----------------------------
            // CH's ------------------------
            QuestionContent.Add("ちゃ");
            QuestionContent.Add("ちゅ");
            QuestionContent.Add("ちょ");
            //-----------------------------
            // NI's ------------------------
            QuestionContent.Add("にゃ");
            QuestionContent.Add("にゅ");
            QuestionContent.Add("にょ");
            //-----------------------------
            // HI's ------------------------
            QuestionContent.Add("ひゃ");
            QuestionContent.Add("ひゅ");
            QuestionContent.Add("ひょ");
            //-----------------------------
            // MI's ------------------------
            QuestionContent.Add("みゃ");
            QuestionContent.Add("みゅ");
            QuestionContent.Add("みょ");
            //-----------------------------
            // RI's ------------------------
            QuestionContent.Add("りゃ");
            QuestionContent.Add("りゅ");
            QuestionContent.Add("りょ"); // FIXED
            //-----------------------------
            // GI's ------------------------
            QuestionContent.Add("ぎゃ");
            QuestionContent.Add("ぎゅ");
            QuestionContent.Add("ぎょ");            
            //-----------------------------
            // JI's ------------------------
            QuestionContent.Add("じゃ");
            QuestionContent.Add("じゅ");
            QuestionContent.Add("じょ");
            //-----------------------------
            // BI's ------------------------
            QuestionContent.Add("びゃ");
            QuestionContent.Add("びゅ");
            QuestionContent.Add("びょ");
            //-----------------------------
            // PI's ------------------------
            QuestionContent.Add("ぴゃ");
            QuestionContent.Add("ぴゅ");
            QuestionContent.Add("ぴょ");
            

            return QuestionContent;
        }

        List<string> Lesson8AnswerContent(List<string> AnswerContent)
        {
            // K's ------------------------
            AnswerContent.Add("KYA");
            AnswerContent.Add("KYU");
            AnswerContent.Add("KYO");
            //-----------------------------
            // SH's ------------------------
            AnswerContent.Add("SHA");
            AnswerContent.Add("SHU");
            AnswerContent.Add("SHO");
            //-----------------------------
            // CH's ------------------------
            AnswerContent.Add("CHA");
            AnswerContent.Add("CHU");
            AnswerContent.Add("CHO");
            //-----------------------------
            // NI's ------------------------
            AnswerContent.Add("NYA");
            AnswerContent.Add("NYU");
            AnswerContent.Add("NYO");
            //-----------------------------
            // HI's ------------------------
            AnswerContent.Add("HYA");
            AnswerContent.Add("HYU");
            AnswerContent.Add("HYO");
            //-----------------------------
            // MI's ------------------------
            AnswerContent.Add("MYA");
            AnswerContent.Add("MYU");
            AnswerContent.Add("MYO");
            //-----------------------------
            // RI's ------------------------
            AnswerContent.Add("RYA");
            AnswerContent.Add("RYU");
            AnswerContent.Add("RYO");
            //-----------------------------
            // GI's ------------------------
            AnswerContent.Add("GYA");
            AnswerContent.Add("GYU");
            AnswerContent.Add("GYO");
            //-----------------------------
            // JI's ------------------------
            AnswerContent.Add("JYA");
            AnswerContent.Add("JYU");
            AnswerContent.Add("JYO");
            //-----------------------------
            // BI's ------------------------
            AnswerContent.Add("BYA");
            AnswerContent.Add("BYU");
            AnswerContent.Add("BYO");
            //-----------------------------
            // PI's ------------------------
            AnswerContent.Add("PYA");
            AnswerContent.Add("PYU");
            AnswerContent.Add("PYO");


            return AnswerContent;

        }

        #endregion

        #region Test
        List<string> TestQuestionContent(List<string> QuestionContent)
        {
            // Adding the previous lesson constuctior to make the test elements
            Lesson1QuestionContent(QuestionContent);

            Lesson2QuestionContent(QuestionContent);

            Lesson3QuestionContent(QuestionContent);

            Lesson4QuestionContent(QuestionContent);

            Lesson5QuestionContent(QuestionContent);

            Lesson6QuestionContent(QuestionContent);

            Lesson7QuestionContent(QuestionContent);

            Lesson8QuestionContent(QuestionContent);

            return QuestionContent;
        }

        List<string> TestAnswerContent(List<string> AnswerContent)
        {
            // Adding the previous lesson constuctor to make the test elements
            Lesson1AnswerContent(AnswerContent);

            Lesson2AnswerContent(AnswerContent);

            Lesson3AnswerContent(AnswerContent);

            Lesson4AnswerContent(AnswerContent);

            Lesson5AnswerContent(AnswerContent);

            Lesson6AnswerContent(AnswerContent);

            Lesson7AnswerContent(AnswerContent);

            Lesson8AnswerContent(AnswerContent);
            return AnswerContent;
        }

        #endregion

        #endregion

        #region List Editors
        List<string> NewQuestionList(List<string> CurrentQuestionList,bool AnswerStatus)
        {
            if (AnswerStatus == true)
            {
                Program.QuestionsSecondIteration.Add(CurrentQuestionList[Program.IndexInUse]); // Adding the correct Question into the second list

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
                Program.AnswerSecondIteration.Add(CurrentAnswerList[Program.IndexInUse]); // Adding the correct answer into the second list

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

        #region Correct/Wrong Answer Count Method
        /// <summary>
        /// This is run evertime an answer has been inputted
        /// This will either incrament the correct answer count or the wrong answer count
        /// </summary>
        /// <param name="AnswerState"></param>
         void AnswerCorrectWrongCount(bool AnswerState) // Works
        {
            if (AnswerState == true) // Correct Answer
            {
                Program.CorrectAnswerCount = Program.CorrectAnswerCount + 1; // Adding one to the variable that store the answers count
                SpeedTestCorrectAnswerLabel.Text = "Answers Correct: " + Program.CorrectAnswerCount.ToString(); // Setting that var value into the text box and writting it to a string
            }

            else if (AnswerState == false) // Incorrect Answer
            {
                Program.WrongAnswerCount = Program.WrongAnswerCount + 1;
                SpeedTestWrongAnswerLabel.Text = "Answers Wrong: " + Program.WrongAnswerCount.ToString();
            }
        }


        /// <summary>
        /// This will be run when the user click out of the test page via the x or click the button that is shown when
        /// the test is complete
        /// 
        /// This will reset the variables containing the count of how many wrong or correct answers have been given 
        /// during the test. Reseting it means the user can do multiply tests without causing any issues
        /// </summary>
        void AnswerCountReset()
        {
            Program.CorrectAnswerCount = 0;
            Program.WrongAnswerCount = 0;
        }




        #endregion

        #region Time Tracker and Time Result Methods
        //---------------------------------------------------------------------------------------
        //Tick
        //---------------------------------------------------------------------------------------
        /// <summary>
        /// This is the timer from the toolbox 
        /// First we set the interval to 1 second 
        /// Then we write that value into a inter within the program.cs
        /// Lastly we write that value as well as a phrase to the label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // 1000ms = 1 second 
            Program.TimerValue = Program.TimerValue + 1;
            TimeTakenLabel.Text = "Time Taken: " + Program.TimerValue.ToString();
        }

        //---------------------------------------------------------------------------------------

        /// <summary>
        /// This is generating the text needed to be shown to the time result label
        /// It is just getting the value then setting it 
        /// </summary>
        /// <param name="TimeTaken"></param>
         public void TimeResult(int TimeTaken)
        {
            TimeResultLabel.Text = "You took " + TimeTaken.ToString() + " seconds to complete the test!";
        }




        #endregion

        #region Accuracy Calculator
        /// <summary>
        /// This will be run when the test is over
        /// This will take the count of wrong and correct answers and divide correct/wrong to
        /// make a percentage
        /// It will then print this to a label in the last screen
        /// </summary>
        public void AccuracyCalc()
        {
            double Wrong = Program.WrongAnswerCount;
            double Correct = Program.CorrectAnswerCount;
            double Sum = Correct + Wrong;

            // Incase there is nothing wrong - Error Control
            if (Wrong == 0)
            {
                AnswerAccuracyLabel.Text = "Accuracy: 100%";
            }

            else
            {
                //double Accuracy = (Correct / Wrong) * 100;
                double Accuracy = (Correct / Sum) * 100; 
                Accuracy = Math.Round(Accuracy, 2); // Rounds the number to two decimal places
                AnswerAccuracyLabel.Text = "Accuracy: " + Accuracy.ToString() + "%";
            }
        }
        #endregion

        #region Contructor for end of test
        public void EndOfTest()
        {
            TestDonePanel.Show(); // Shows the a panel to show the user they have done with this test
            TestDoneButton.Focus();
            timer1.Stop(); // Stops the timer
            TimeResult(Program.TimerValue); // Print the time taken to the result label

            /// Printing the results into to label in the last page
            AnswerCorrectCountLabel.Text = "Answers Correct: " + Program.CorrectAnswerCount.ToString();
            WrongCorrectCountLabel.Text = "Answers Wrong: " + Program.WrongAnswerCount.ToString();
            AccuracyCalc(); // To calc the accuracy during the test
        }

        #endregion

        #endregion
        //---------------------------------------------------------------------------------------



    }
}
