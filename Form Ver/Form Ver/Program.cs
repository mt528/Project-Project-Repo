using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ver
{
    static class Program
    {
        #region Hiragana Lists
        //-------------------------------------------------------------------------------------
        /// Making the Lists
        /// Note: Remember to make it a "public static"
        public static List<string> Lesson1Questions = new List<string>();
        public static List<string> Lesson1Answers = new List<string>();

        public static List<string> Lesson2Questions = new List<string>();
        public static List<string> Lesson2Answers = new List<string>();

        public static List<string> Lesson3Questions = new List<string>();
        public static List<string> Lesson3Answers = new List<string>();

        public static List<string> Lesson4Questions = new List<string>();
        public static List<string> Lesson4Answers = new List<string>();

        public static List<string> Lesson5Questions = new List<string>();
        public static List<string> Lesson5Answers = new List<string>();

        public static List<string> Lesson6Questions = new List<string>();
        public static List<string> Lesson6Answers = new List<string>();

        public static List<string> Lesson7Questions = new List<string>();
        public static List<string> Lesson7Answers = new List<string>();

        public static List<string> Lesson8Questions = new List<string>();
        public static List<string> Lesson8Answers = new List<string>();

        public static List<string> TestQuestions = new List<string>();
        public static List<string> TestAnswers = new List<string>();

        //-------------------------------------------------------------------------------------
        #endregion 



        #region Test Variables 
        //-------------------------------------------------------------------------------------
        /// To store the lists in use
        public static List<string> Questions = new List<string>();
        public static List<string> Answers = new List<string>();


        /// For the second iteration of the tests
        public static List<string> QuestionsSecondIteration = new List<string>();
        public static List<string> AnswerSecondIteration = new List<string>();
        //-------------------------------------------------------------------------------------
        /// Variable to track where the user came from for the test
        public static string UserCameFrom;

        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        /// To store the Random Index value made
        public static int IndexInUse;
        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        /// To help with a if statement 
        /// This will be set to true when the test is done
        public static bool TestDone = false;

        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        /// To store the number of correct/wrong answers given during the test
        public static int CorrectAnswerCount = 0;
        public static int WrongAnswerCount = 0;

        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        /// Timer variable 
        /// To store the number within the timer 
        public static int TimerValue;
        //-------------------------------------------------------------------------------------
        #region Mistake Tracker

        public static bool UserCameFromLesson = false; // This is so the lessons test dont cause crashes

        // To store the lesson content 
        public static List<string> Lesson1Ref = new List<string>();
        public static List<string> Lesson2Ref = new List<string>();
        public static List<string> Lesson3Ref = new List<string>();
        public static List<string> Lesson4Ref = new List<string>();
        public static List<string> Lesson5Ref = new List<string>();
        public static List<string> Lesson6Ref = new List<string>();
        public static List<string> Lesson7Ref = new List<string>();
        public static List<string> Lesson8Ref = new List<string>();

        public static List<List<string>> EveryLessonRef = new List<List<string>>();

        // Mistake Counters
        public static int L1Incorrect = new int();
        public static int L2Incorrect = new int();
        public static int L3Incorrect = new int();
        public static int L4Incorrect = new int();
        public static int L5Incorrect = new int();
        public static int L6Incorrect = new int();
        public static int L7Incorrect = new int();
        public static int L8Incorrect = new int();

        #endregion

        #region Kanji Test 
        public static List<string> KanjiQuestions = new List<string>();

        public static List<List<List<string>>> KanjiAnswers = new List<List<List<string>>>();

        //public static List<List<string>> AnswerForCharacter = new List<List<string>>();

        //public static List<string> SayingOnYomi = new List<string>();
        //public static List<string> SayingKunYomi = new List<string>();

        #endregion

        #region Score
        public static int Score; // Store score

        public static int PrevTime; // To store the last time that score method was used
        #endregion

        #endregion
        //-------------------------------------------------------------------------------------
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new IntroductionForm());
        }

    }
}
