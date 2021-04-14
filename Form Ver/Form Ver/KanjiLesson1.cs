using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class KanjiLesson1 : Form
    {
        public KanjiLesson1()
        {
            InitializeComponent();
            // Hiding the panels within this form ---- MOVE THIS INTO A METHOD --------------------------------------------------
            //------------------------
            // Lesson 1 forms
            //KanjiLesson1Panel.Hide();
            KanjiLesson1Panel2.Hide();
            KanjiLesson1Panel3.Hide();
            KanjiLesson1Panel4.Hide();
            KanjiLesson1Panel5.Hide();
            KanjiLesson1Panel6.Hide();
            KanjiLesson1Panel7.Hide();
            KanjiLesson1Panel8.Hide();
            KanjiLesson1Panel9.Hide();
            KanjiLesson1Panel10.Hide();
            KanjiLesson1Panel11.Hide();
            KanjiLesson1Panel12.Hide();
            KanjiLesson1Panel13.Hide();
            KanjiLesson1Panel14.Hide();
            KanjiLesson1Panel15.Hide();
            KanjiLesson1Panel16.Hide();
            KanjiLesson1Panel17.Hide();
            KanjiLesson1Panel18.Hide();
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

            KanjiMenu Menu = new KanjiMenu();
            Menu.Show();

        }
        #endregion

        #region Lesson 1 

        #region Panel 1 - Kanji Intro
        #region Panel
        private void KanjiLesson1Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        #region Continue Button
        /// <summary>
        /// This will run when the user selects the continue panel within the panel
        /// 
        /// This will take the user to the next panel at the same time hiding the current panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanjiLesson1Panel1ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel2.Show();
        }
        #endregion

        #region Back Button 
        /// <summary>
        /// This will hide the current panel and show the kanji menu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanjiLesson1Panel1BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            KanjiMenu Menu = new KanjiMenu();
            Menu.Show();
        }
        #endregion

        private void KanjiMenuLesson1Button_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel.Show();
        }
        #endregion

        #region Panel 2 - Kanji Rules
        #region Continue Button
        private void KanjiLesson1Panel2ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel3.Show();
        }
        #endregion

        #region Go back Button
        /// <summary>
        /// This will be run when the user selects the Go Back Button
        /// 
        /// This will take the user to the previous panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KanjiLesson1Panel2GoBackButton_Click(object sender, EventArgs e)
        {
            this.KanjiLesson1Panel2.Hide();
            KanjiLesson1Panel.Show();
        }
        #endregion

        #endregion

        #region Panel 3  - 一

        #region Back Button
        private void KanjiLesson1Panel3BackButton_Click(object sender, EventArgs e)
        {
            this.KanjiLesson1Panel3.Hide();
            KanjiLesson1Panel2.Show();
        }
        #endregion

        #region Continue Button
        private void KanjiLesson1Panel3ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel4.Show();
        }
        #endregion

        #region Panel 4

        #endregion
        #endregion

        #region Panel 4 - 二

        #region Continue Button
        private void KanjiLesson1Panel4ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel5.Show();
        }
        #endregion

        #region Back Button 
        private void KanjiLesson1Panel4BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel4.Hide();
            KanjiLesson1Panel3.Show();
        }
        #endregion

        #endregion

        #region Panel 5 - 三

        #region Continue Button
        private void KanjiLesson1Panel5ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel6.Show();
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel5BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel5.Hide();
            KanjiLesson1Panel4.Show();
        }
        #endregion

        #endregion

        #region Panel 6 - 四

        #region Continue Button
        private void KanjiLesson1Panel6ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel7.Show();

        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel6BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel6.Hide();
            KanjiLesson1Panel5.Show();
        }
        #endregion

        #endregion

        #region Panel 7 - 五

        #region Continue Button
        private void KanjiLesson1Panel7ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel8.Show();
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel7BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel7.Hide();
            KanjiLesson1Panel6.Show();
        }
        #endregion

        #endregion

        #region Panel 8 - 六
        #region Continue Button
        private void KanjiLesson1Panel8ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel9.Show();
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel8BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel8.Hide();
            KanjiLesson1Panel7.Show();
        }
        #endregion

        #endregion

        #region Panel 9 - 七
        #region Continue Button
        private void KanjiLesson1Panel9ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel10.Show();
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel9BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel9.Hide();
            KanjiLesson1Panel8.Show();
        }
        #endregion

        #endregion

        #region Panel 10 - 八
        #region Continue Button
        private void KanjiLesson1Panel10ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel11.Show();
        }
        #endregion
        #region Back Button
        private void KanjiLesson1Panel10BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel10.Hide();
            KanjiLesson1Panel9.Show();
        }
        #endregion
        #endregion

        #region Panel 11 - 九
        #region Continue Button
        private void KanjiLesson1Panel11ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel12.Show();
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel11BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel11.Hide();
            KanjiLesson1Panel10.Show();
        }
        #endregion

        #endregion

        #region Panel 12 - 十
        #region Continue Button
        private void KanjiLesson1Panel12ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel13.Show();
        }
        #endregion
        #region Back Button
        private void KanjiLesson1Panel12BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel12.Hide();
            KanjiLesson1Panel11.Show();
        }
        #endregion
        #endregion

        #region Panel 13 - 百
        #region Continue Button
        private void KanjiLesson1Panel13ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel14.Show();
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel13BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel13.Hide();
            KanjiLesson1Panel12.Show();
        }
        #endregion

        #endregion

        #region Panel 14 - 千
        #region Continue Button
        private void KanjiLesson1Panel14ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel15.Show();
        }

        #endregion

        #region Back Button
        private void KanjiLesson1Panel14BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel14.Hide();
            KanjiLesson1Panel13.Show();
        }
        #endregion
        #endregion

        #region Panel 15 - 万
        #region Continue Button
        private void KanjiLesson1Panel15ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel16.Show();
        }
        #endregion
        #region Back Button
        private void KanjiLesson1Panel15BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel15.Hide();
            KanjiLesson1Panel14.Show();
        }
        #endregion
        #endregion

        #region Panel 16 - 円
        #region Continue Button
        private void KanjiLesson1Panel16ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel17.Show();
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel16BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel16.Hide();
            KanjiLesson1Panel15.Show();
        }
        #endregion

        #endregion

        #region Panel 17 - 時
        #region Continue Button
        private void KanjiLesson1Panel17ContinueButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel18.Show();
        }
        #endregion
        #region Back Button
        private void KanjiLesson1Panel17BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel17.Hide();
            KanjiLesson1Panel16.Show();
        }
        #endregion
        #endregion

        #region Panel 18 - Test Method
        #region Recollection Test
        private void KanjiLesson1Panel18RecollectionTestButton_Click(object sender, EventArgs e)
        {
            // FINISH - TAKE TO NEW FORM
        }
        #endregion
        #region Speed Test
        private void KanjiLesson1Panel18SpeedTestButton_Click(object sender, EventArgs e)
        {
            // FINISH - TAKE TO NEW FORM
        }
        #endregion

        #region Back Button
        private void KanjiLesson1Panel18BackButton_Click(object sender, EventArgs e)
        {
            KanjiLesson1Panel18.Hide();
            KanjiLesson1Panel17.Show();
        }
        #endregion

        #endregion

        #endregion

        #region Lesson 2 
        private void KanjiMenuLesson2Button_Click(object sender, EventArgs e)
        {
            // FINISH
        }

        #region Kanji Test
        private void KanjiMenuTestButton_Click(object sender, EventArgs e)
        {
            // FINISH - SHOW A TEST PANEL DECIDING ON TEST METHOD
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


    }
}

