using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ver
{
    static class Program
    {
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
        //-------------------------------------------------------------------------------------
        /// Variable to track where the user came from for the test
        public static string UserCameFrom;

        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        /// To store the Random Index value made
        public static int IndexInUse;
        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------
        /// To store the lists in use
        public static List<string> Questions = new List<string>();
        public static List<string> Answers = new List<string>();

        
        /// For the second iteration of the tests
        public static List<string> QuestionsSecondIteration = new List<string>();
        public static List<string> AnswerSecondIteration = new List<string>();

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
        public static int TimerValue;
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
