using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class KanjiTestForm : Form
    {
        public KanjiTestForm()
        {
            InitializeComponent();
            KanjiTestQuestionPanel.Hide();
            KanjiTestAnswerPanel.Hide();
            KanjiTestDonePanel.Hide();
        }

        #region Kanji Test Intro 
        /// <summary>
        ///  This will start the test
        ///  
        /// If the timed version is enabled it will also start a timer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanjiTestIntroButton_Click(object sender, EventArgs e)
        {
            MakeTest(Program.UserCameFrom);
            KanjiTestQuestionPanel.Show();

            Random rnd = new Random(); // Random method

            Program.IndexInUse = rnd.Next(0, Program.KanjiQuestions.Count); // Generate a random index number

            /*
            KanjiTestPanel1QuestionLabel.Text = "What are the readings for:\n" + Program.KanjiQuestions[Program.IndexInUse];

            KanjiTestPanel2AnswerLabel.Text = "What are the readings for:\n" + Program.KanjiQuestions[Program.IndexInUse];

            KanjiTestPanel2KunYomiLabel.Text = KunYomiReadingText(Program.IndexInUse);
            KanjiTestPanel2OnYomiLabel.Text = OnYomiReadingText(Program.IndexInUse);
            KanjiTestPanel2MeaningLabel.Text = MeaningReadingText(Program.IndexInUse);
            */

            // HAVE A TIMED VERSION
        }
        #endregion

        #region Kanji Test

        #region Kanji Test Label Text
        /// <summary>
        /// This will take the list that contains the kun yomi answers and iterate through it
        /// to add all of the elements to the a string then return that string
        /// </summary>
        /// <param name="KanjiKunYomiAnswers"></param>
        //static string KunYomiReadingText(List<List<List<string>>> KanjiKunYomiAnswers)
        static string KunYomiReadingText(int IndexChosen)
        {

            string TheText = "Kun-Yomi Readings:";
            /*
            for (int i = 0; i < KanjiKunYomiAnswers.Count; i++)
            {
                TheText = TheText + "\n" + KanjiKunYomiAnswers[i].ToString();
            }
            */

            for (int i = 0; i < Program.KanjiAnswers[IndexChosen][0].Count; i++)
            {
                TheText = TheText + "\n" + Program.KanjiAnswers[IndexChosen][0][i];
            }
            return TheText.ToString();
        }
        static string OnYomiReadingText(int IndexChosen)
        {

            string TheText = "On-Yomi Readings:";
            /*
            for (int i = 0; i < KanjiKunYomiAnswers.Count; i++)
            {
                TheText = TheText + "\n" + KanjiKunYomiAnswers[i].ToString();
            }
            */

            for (int i = 0; i < Program.KanjiAnswers[IndexChosen][1].Count; i++)
            {
                TheText = TheText + "\n" + Program.KanjiAnswers[IndexChosen][1][i];
            }
            return TheText.ToString();
        }


        static string MeaningReadingText(int IndexChosen)
        {

            string TheText = "Meaning:";
            /*
            for (int i = 0; i < KanjiKunYomiAnswers.Count; i++)
            {
                TheText = TheText + "\n" + KanjiKunYomiAnswers[i].ToString();
            }
            */

            for (int i = 0; i < Program.KanjiAnswers[IndexChosen][2].Count; i++)
            {
                TheText = TheText + "\n" + Program.KanjiAnswers[IndexChosen][2][i];
            }
            return TheText.ToString();
        }
        #endregion

        static void MakeTest(string UserCameFrom)
        {
            switch (UserCameFrom)
            {
                case "K1":
                    KanjiLesson1Questions();
                    KanjiAnswersListsGeneration(Program.KanjiQuestions);
                    KanjiLesson1Answers();
                    break;
            }
        }
        #endregion

        #region Kanji Test Content
        static void KanjiAnswersListsGeneration(List<string> KanjiQuestions)
        {
            // Generating the lists
            int KanjiQuestionsLength = KanjiQuestions.Count;

            for (int i = 0; i < KanjiQuestionsLength; i++)
            {
                List<string> SayingKunYomi = new List<string>();
                List<string> SayingOnYomi = new List<string>();
                List<string> Meaning = new List<string>();


                List<List<string>> AnswerForCharacter = new List<List<string>>();

                AnswerForCharacter.Add(SayingKunYomi);
                AnswerForCharacter.Add(SayingOnYomi);
                AnswerForCharacter.Add(Meaning);

                Program.KanjiAnswers.Add(AnswerForCharacter);
            }

        }
        #region Lesson 1 
        static void KanjiLesson1Questions()
        {
            Program.KanjiQuestions.Add("一");
            Program.KanjiQuestions.Add("二");
            Program.KanjiQuestions.Add("三");
            Program.KanjiQuestions.Add("四");
            Program.KanjiQuestions.Add("五");
            Program.KanjiQuestions.Add("六");
            Program.KanjiQuestions.Add("七");
            Program.KanjiQuestions.Add("八");
            Program.KanjiQuestions.Add("九");
            Program.KanjiQuestions.Add("十");
            Program.KanjiQuestions.Add("百");
            Program.KanjiQuestions.Add("千");
            Program.KanjiQuestions.Add("万");
            Program.KanjiQuestions.Add("円");
            Program.KanjiQuestions.Add("時");
        }


        #endregion

        #region Lesson 1 Answers
        static void KanjiLesson1Answers()
        {

            // 一
            Program.KanjiAnswers[0][0].Add("ひと"); // Kunyomi readings 

            Program.KanjiAnswers[0][1].Add("いち"); // Onyomi readings 
            Program.KanjiAnswers[0][1].Add("いっ"); // Onyomi readings 

            Program.KanjiAnswers[0][2].Add("One"); // Meanings 
            //---------------------------------------------------------------------------------------
            // 二
            Program.KanjiAnswers[1][0].Add("ふた"); // Kunyomi readings 

            Program.KanjiAnswers[1][1].Add("に"); // Onyomi readings 

            Program.KanjiAnswers[1][2].Add("Two"); // Meanings
            //---------------------------------------------------------------------------------------
            // 三
            Program.KanjiAnswers[2][0].Add("みっ"); // Kunyomi readings 

            Program.KanjiAnswers[2][1].Add("さん"); // Onyomi readings 

            Program.KanjiAnswers[2][2].Add("Three"); // Meanings
            //---------------------------------------------------------------------------------------

            // 四
            Program.KanjiAnswers[3][0].Add("よん"); // Kunyomi readings 
            Program.KanjiAnswers[3][0].Add("よっ"); // Kunyomi readings 

            Program.KanjiAnswers[3][1].Add("し"); // Onyomi readings 

            Program.KanjiAnswers[3][2].Add("Four"); // Meanings
            //---------------------------------------------------------------------------------------
            // 五
            Program.KanjiAnswers[4][0].Add("いつ"); // Kunyomi readings 

            Program.KanjiAnswers[4][1].Add("ご"); // Onyomi readings 

            Program.KanjiAnswers[4][2].Add("Five"); // Meanings
            //---------------------------------------------------------------------------------------
            // 六
            Program.KanjiAnswers[5][0].Add("むっ"); // Kunyomi readings 

            Program.KanjiAnswers[5][1].Add("ろく"); // Onyomi readings 
            Program.KanjiAnswers[5][1].Add("ろっ"); // Onyomi readings

            Program.KanjiAnswers[5][2].Add("Six"); // Meanings
            //---------------------------------------------------------------------------------------
            // 七
            Program.KanjiAnswers[6][0].Add("なな"); // Kunyomi readings 

            Program.KanjiAnswers[6][1].Add("しち"); // Onyomi readings 

            Program.KanjiAnswers[6][2].Add("Seven"); // Meanings
            //---------------------------------------------------------------------------------------
            // 八
            Program.KanjiAnswers[7][0].Add("や"); // Kunyomi readings 
            Program.KanjiAnswers[7][0].Add("やっ"); // Kunyomi readings 
            Program.KanjiAnswers[7][0].Add("よう"); // Kunyomi readings 

            Program.KanjiAnswers[7][1].Add("はち"); // Onyomi readings 
            Program.KanjiAnswers[7][1].Add("はっ"); // Onyomi readings 

            Program.KanjiAnswers[7][2].Add("Eight"); // Meanings
            //---------------------------------------------------------------------------------------
            // 九
            Program.KanjiAnswers[8][0].Add("ここの"); // Kunyomi readings 

            Program.KanjiAnswers[8][1].Add("きゅう"); // Onyomi readings 
            Program.KanjiAnswers[8][1].Add("く"); // Onyomi readings 

            Program.KanjiAnswers[8][2].Add("Nine"); // Meanings
            //---------------------------------------------------------------------------------------
            // 十
            Program.KanjiAnswers[9][0].Add("とお"); // Kunyomi readings 
            Program.KanjiAnswers[9][0].Add("と"); // Kunyomi readings 

            Program.KanjiAnswers[9][1].Add("じゅう"); // Onyomi readings 
            Program.KanjiAnswers[9][1].Add("じゅっ"); // Onyomi readings 
            Program.KanjiAnswers[9][1].Add("じっ"); // Onyomi readings 

            Program.KanjiAnswers[9][2].Add("Ten"); // Meanings
            //---------------------------------------------------------------------------------------
            // 百
            Program.KanjiAnswers[10][0].Add("None"); // Kunyomi readings 

            Program.KanjiAnswers[10][1].Add("ひゃく"); // Onyomi readings 
            Program.KanjiAnswers[10][1].Add("びゃく"); // Onyomi readings 
            Program.KanjiAnswers[10][1].Add("ぴゃく"); // Onyomi readings

            Program.KanjiAnswers[10][2].Add("(One) Hundred"); // Meanings
            //---------------------------------------------------------------------------------------
            // 千
            Program.KanjiAnswers[11][0].Add("None"); // Kunyomi readings 

            Program.KanjiAnswers[11][1].Add("せん"); // Onyomi readings 
            Program.KanjiAnswers[11][1].Add("ぜん"); // Onyomi readings 

            Program.KanjiAnswers[11][2].Add("Thousand (1000)"); // Meanings
            //---------------------------------------------------------------------------------------
            // 万
            Program.KanjiAnswers[12][0].Add("None"); // Kunyomi readings 

            Program.KanjiAnswers[12][1].Add("まん"); // Onyomi readings 

            Program.KanjiAnswers[12][2].Add("Ten Thousand"); // Meanings
            //---------------------------------------------------------------------------------------
            // 円
            Program.KanjiAnswers[13][0].Add("まる"); // Kunyomi readings 

            Program.KanjiAnswers[13][1].Add("えん"); // Onyomi readings 

            Program.KanjiAnswers[13][2].Add("Yen"); // Meanings
            //---------------------------------------------------------------------------------------
            // 時
            Program.KanjiAnswers[14][0].Add("とき"); // Kunyomi readings  

            Program.KanjiAnswers[14][1].Add("じ"); // Onyomi readings 

            Program.KanjiAnswers[14][2].Add("Time"); // Meanings
            //---------------------------------------------------------------------------------------
        }
        #endregion

        #endregion

        #region X button on form
        /// <summary>
        /// Happens when the x button on the form is closed
        /// 
        /// This will take the user to the main menu of the programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanjiTestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenuForm MainMenu = new MainMenuForm();
            this.Hide();
            MainMenu.Show();
        }
        #endregion

        #region Question Panel
        /// <summary>
        ///  This will make the answer panel have the correct info for the answers 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanjiTestPanelCheckButton_Click(object sender, EventArgs e)
        {
            KanjiTestAnswerPanel.Show();

            /*
            Random rnd = new Random(); // Random method

            Program.IndexInUse = rnd.Next(0, Program.KanjiQuestions.Count); // Generate a random index number
            */
            //KanjiTestPanel1QuestionLabel.Text = "What are the readings for:\n" + Program.KanjiQuestions[Program.IndexInUse];

            KanjiTestPanel2AnswerLabel.Text = "What are the readings for:\n" + Program.KanjiQuestions[Program.IndexInUse];

            KanjiTestPanel2KunYomiLabel.Text = KunYomiReadingText(Program.IndexInUse);
            KanjiTestPanel2OnYomiLabel.Text = OnYomiReadingText(Program.IndexInUse);
            KanjiTestPanel2MeaningLabel.Text = MeaningReadingText(Program.IndexInUse);
        }

        #region Labels
        private void KanjiTestPanel1QuestionLabel_Click(object sender, EventArgs e)
        {

        }

        private void KanjiTestPanel1KunYomiLabel_Click(object sender, EventArgs e)
        {

        }

        private void KanjiTestPanel1OnYomiLabel_Click(object sender, EventArgs e)
        {

        }

        private void KanjiMeaningLabel_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region Answer Panel
        /// <summary>
        ///  This will generate a new index number and clean the labels on the question page
        ///  
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanjiTestPanel2WrongButton_Click(object sender, EventArgs e)
        {

            Random rnd = new Random(); // Random method

            Program.IndexInUse = rnd.Next(0, Program.KanjiQuestions.Count); // Generate a random index number
            KanjiTestQuestionPanel.Show();
            KanjiTestAnswerPanel.Hide();
            //-----------------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------
            // Cleaning
            KanjiTestPanel1QuestionLabel.Text = "What are the readings for:\n" + Program.KanjiQuestions[Program.IndexInUse];

            KanjiTestPanel1KunYomiLabel.Text = "Kun-Yomi Readings:";
            KanjiTestPanel1OnYomiLabel.Text = "On-Yomi Readings:";
            KanjiMeaningLabel.Text = "Meaning:";
            //-----------------------------------------------------------------------------------------------

        }

        private void KanjiTestPanel2CorrectButton_Click(object sender, EventArgs e)
        {
            // FINISH
            // Removing the correct answer
            Program.KanjiQuestions.RemoveAt(Program.IndexInUse);
            //-----------------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------
            if (Program.KanjiQuestions.Count == 0) // When the program has ran out of questions
            {
                KanjiTestDonePanel.Show();
            }

            else // When there are questions still left
            {
                //-----------------------------------------------------------------------------------------------
                Random rnd = new Random(); // Random method

                Program.IndexInUse = rnd.Next(0, Program.KanjiQuestions.Count); // Generate a random index number
                KanjiTestQuestionPanel.Show();
                KanjiTestAnswerPanel.Hide();
                //-----------------------------------------------------------------------------------------------
                // Cleaning
                KanjiTestPanel1QuestionLabel.Text = "What are the readings for:\n" + Program.KanjiQuestions[Program.IndexInUse];

                KanjiTestPanel1KunYomiLabel.Text = "Kun-Yomi Readings:";
                KanjiTestPanel1OnYomiLabel.Text = "On-Yomi Readings:";
                KanjiMeaningLabel.Text = "Meaning:";
                //-----------------------------------------------------------------------------------------------
            }
            #endregion
        }
        #region Kanji Test Done Panel Bits
        private void KanjiTestDonePanelButton_Click(object sender, EventArgs e)
        {
            KanjiMenu KanjiMainMenu = new KanjiMenu();
            this.Hide();
            KanjiMainMenu.Show();


        }
        #endregion
    }
}
