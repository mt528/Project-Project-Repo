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