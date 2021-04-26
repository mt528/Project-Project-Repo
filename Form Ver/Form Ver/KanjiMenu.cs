using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class KanjiMenu : Form
    {
        public KanjiMenu()
        {
            InitializeComponent();
            // Hiding the panels within this form ---- MOVE THIS INTO A METHOD --------------------------------------------------
            //------------------------
            // Lesson 1 forms
            
            //------------------------
            // ADD ALL THE FORMS
        }
        // NOTE: You can select the panel you want to edit within the document outline, Select it then bring it to front
        // DOESNT WORK ↑
        #region Menu Elements

        #region Go back button
        /// <summary>
        /// This will run when the Go Back button is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <return> This will take the user back to the main menu </return>
        private void KanjiMenuGoBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            MainMenuForm Menu = new MainMenuForm();
            Menu.Show();

        }
        #endregion

        #region Lesson 1 
        private void KanjiMenuLesson1Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            KanjiLesson1 Lesson1 = new KanjiLesson1();
            Lesson1.Show();
        }
        

        #region Lesson 2 
        private void KanjiMenuLesson2Button_Click(object sender, EventArgs e)
        {
            // FINISH
        }

        #region Kanji Test
        private void KanjiMenuTestButton_Click(object sender, EventArgs e)
        {
            KanjiTestForm Form = new KanjiTestForm();
            this.Hide();
            Form.Show();
            Program.UserCameFrom = "TEST"; // All Kanji content
        }
        #endregion

        #endregion

        #endregion

        #region X button click
        /// <summary>
        /// This will be run when the user hits the x button on the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        ///<return> This will take the user to the main menu form </return>
        private void KanjiMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainMenuForm MainMenu = new MainMenuForm();
            MainMenu.Show();
        }












































        #endregion

        #endregion
    }
}
