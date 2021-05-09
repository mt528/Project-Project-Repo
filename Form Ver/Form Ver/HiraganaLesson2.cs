using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class HiraganaLesson2 : Form
    {
        public HiraganaLesson2()
        {
            InitializeComponent();

            Panel2.Hide(); // Hides panel 2
            Panel3.Hide(); // Hides panel 3 
            Panel4.Hide();
            Panel5.Hide();
            Panel6.Hide();
            Panel7.Hide();
            Panel8.Hide();
            Panel9.Hide();
            Panel10.Hide();
            Panel11.Hide();
            Panel12.Hide();
        }

        #region Lesson Contents

        #region Intro Panel

        #region Next Button
        private void Panel1NextButton_Click(object sender, EventArgs e)
        {
            Panel2.Show();
        }
        #endregion

        #region Back Button
        /// <summary>
        /// This will take the user to the main menu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1BackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm Form = new MainMenuForm();
            this.Hide();
            Form.Show();
        }
        #endregion

        #endregion

        #region K's Panels 2 - 6 

        #region か - Panel 2 
        #region Back Button
        /// <summary>
        /// Hides the current panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel2BackButton_Click(object sender, EventArgs e)
        {
            Panel2.Hide();
        }
        #endregion
        /// <summary>
        /// Shows the next panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Next Button
        private void Panel2NextButton_Click(object sender, EventArgs e)
        {
            Panel3.Show();
        }
        #endregion
        #endregion

        #region き - Panel 3 

        // Next Button
        private void Panel3NextButton_Click(object sender, EventArgs e)
        {
            Panel4.Show();
        }

        // Back Button
        private void Panel3BackButton_Click(object sender, EventArgs e)
        {
            Panel3.Hide();
        }
        #endregion

        #region く- Panel 4
        // Next Button
        private void Panel4NextButton_Click(object sender, EventArgs e)
        {
            Panel5.Show();
        }

        // Back Button
        private void Panel4BackButton_Click(object sender, EventArgs e)
        {
            Panel4.Hide();
        }
        #endregion

        #region け - Panel 5 
        // Next Button
        private void Panel5NextButton_Click(object sender, EventArgs e)
        {
            Panel6.Show();
        }

        // Back Button
        private void Panel5BackButton_Click(object sender, EventArgs e)
        {
            Panel5.Hide();
        }
        #endregion

        #region こ - Panel 6 
        // Next Button
        private void Panel6NextButton_Click(object sender, EventArgs e)
        {
            Panel7.Show();
        }
        
        // Back Button
        private void Panel6BackButton_Click(object sender, EventArgs e)
        {
            Panel6.Hide();
        }
        #endregion

        #endregion

        #region S's 7 - 11 

        #region さ - Panel 7 
        // Next Button
        private void Panel7NextButton_Click(object sender, EventArgs e)
        {
            Panel8.Show();
        }

        // Back Button
        private void Panel7BackButton_Click(object sender, EventArgs e)
        {
            Panel7.Hide();
        }
        #endregion

        #region し - Panel 8 
        // Next Button
        private void Panel8NextButton_Click(object sender, EventArgs e)
        {
            Panel9.Show();
        }
        
        // Back Button
        private void Panel8BackButton_Click(object sender, EventArgs e)
        {
            Panel8.Hide();
        }
        #endregion

        #region す - Panel 9
        // Next Button
        private void Panel9NextButton_Click(object sender, EventArgs e)
        {
            Panel10.Show();
        }

        // Back Button
        private void Panel9BackButton_Click(object sender, EventArgs e)
        {
            Panel9.Hide();
        }
        #endregion

        #region せ - Panel 10 
        // Next Button
        private void Panel10NextButton_Click(object sender, EventArgs e)
        {
            Panel11.Show();
        }

        // Back Button
        private void Panel10BackButton_Click(object sender, EventArgs e)
        {
            Panel10.Hide();
        }
        #endregion

        #region そ - Panel 11
        // Next Button
        private void Panel11NextButton_Click(object sender, EventArgs e)
        {
            Panel12.Show();
        }

        // Back Button
        private void Panel11BackButton_Click(object sender, EventArgs e)
        {
            Panel11.Hide();
        }
        #endregion

        #endregion

        #region End Screen Panel
        // Go to menu button
        private void Panel12MenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm MenuForm = new MainMenuForm();
            this.Hide();
            MenuForm.Show();
        }

        // Speed Test Button
        private void Panel12SpeedTestButton_Click(object sender, EventArgs e)
        {
            Program.UserCameFrom = "L2"; // Tracking where the user came from - This has to be first - Not sure why

            TestsForm TestForm = new TestsForm();

            this.Hide();

            TestForm.Show();
        }

        // Back Button
        private void Panel12BackButton_Click(object sender, EventArgs e)
        {
            Panel12.Hide();
        }
        #endregion

        #endregion

        #region Users closed the form
        /// <summary>
        /// This will be run when the user hits the cross button on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HiraganaLesson2_FormClosed(object sender, FormClosedEventArgs e)
        {
               
            Application.Exit(); // Closes the programme
            
        }














        #endregion

        
    }
}
