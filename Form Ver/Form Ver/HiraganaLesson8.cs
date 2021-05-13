using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class HiraganaLesson8 : Form
    {
        public HiraganaLesson8()
        {
            InitializeComponent();


            Panel2.Hide(); // Hiding the panels used
            Panel3.Hide();
            Panel4.Hide();
            Panel5.Hide();
            Panel6.Hide();
            Panel7.Hide();
            Panel8.Hide();
            Panel9.Hide();
            Panel10.Hide();
            Panel11.Hide();
            Panel12.Hide();
            Panel13.Hide();
            Panel14.Hide();
            Panel15.Hide();
            Panel16.Hide();
            Panel17.Hide();
            Panel18.Hide();

        }

        #region Lesson Content

        #region Intro Panel
        // Next Button
        private void Panel1NextButton_Click(object sender, EventArgs e)
        {
            Panel2.Show();
        }

        // Back Button
        private void Panel1BackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm Form = new MainMenuForm();
            this.Hide();
            Form.Show();
        }

        #endregion 

        #region Panel 2 - Small Sounds Explanation
        // Next Button
        private void Panel2NextButton_Click(object sender, EventArgs e)
        {
            Panel3.Show();
        }

        // Back Button 
        private void Panel2BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HiraganaMenu Menu = new HiraganaMenu();
            Menu.Show();
        }

        #endregion

        // REMEBER TO UPDATE IS COPIED FORMAT // REMEBER TO UPDATE IS COPIED FORMAT
        #region Example Panel's 3 - 17

        #region Panel 3 - きゃ
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

        #region Panel 4 - しゅ
        // Next Button
        private void Panel4NextButton_Click(object sender, EventArgs e)
        {
            //Panel5.BringToFront();
            Panel5.Show();
            
        }

        // Back Button
        private void Panel4BackButton_Click(object sender, EventArgs e)
        {
            Panel4.Hide();
        }

        #endregion

        #region Panel 5 - ちゅ
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

        #region Panel 6 - にゃ
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

        #region Panel 7 - ひゅ
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

        #region Panel 8 - みょ
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

        #region Panel 9 - りゃ
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

        #region Panel 10 - ぎゅ
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

        #region Panel 11 - じゃ
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

        #region Panel 12 - びょ
        // Next Button
        private void Panel12NextButton_Click(object sender, EventArgs e)
        {
            Panel13.Show();
        }

        // Back Button
        private void Panel12BackButton_Click(object sender, EventArgs e)
        {
            Panel12.Hide();
        }
        
        #endregion

        #region Panel 13 - ぴょ
        // Next Button
        private void Panel13NextButton_Click(object sender, EventArgs e)
        {
            Panel18.Show();
        }

        // Back Button
        private void Panel13BackButton_Click(object sender, EventArgs e)
        {
            Panel13.Hide();
        }
        #endregion

        #region Not used panels
        #region Panel 14 - ぢ
        // Next Button
        private void Panel14NextButton_Click(object sender, EventArgs e)
        {
            Panel15.Show();
        }

        // Back Button
        private void Panel14BackButton_Click(object sender, EventArgs e)
        {
            Panel14.Hide();
        }
        #endregion

        #region Panel 15 - づ
        // Next Button
        private void Panel15NextButton_Click(object sender, EventArgs e)
        {
            Panel16.Show();
        }

        // Back Button
        private void Panel15BackButton_Click(object sender, EventArgs e)
        {
            Panel15.Hide();
        }
        #endregion

        #region Panel 16 - で
        // Next Button
        private void Panel16NextButton_Click(object sender, EventArgs e)
        {
            Panel17.Show();
        }

        // Back Button
        private void Panel16BackButton_Click(object sender, EventArgs e)
        {
            Panel16.Hide();
        }
        #endregion

        #region Panel 17 - ど
        // Next Button
        private void Panel17NextButton_Click(object sender, EventArgs e)
        {
            Panel18.Show();
        }

        // Back Button
        private void Panel17BackButton_Click(object sender, EventArgs e)
        {
            Panel17.Hide();
        }
        #endregion
        #endregion

        #endregion

        // REMEBER TO UPDATE IS COPIED FORMAT // REMEBER TO UPDATE IS COPIED FORMAT

        // REMEBER TO UPDATE IS COPIED FORMAT // REMEBER TO UPDATE IS COPIED FORMAT
        #region Test select Panel
        // Speed Test Button
        private void Panel18SpeedTestButton_Click(object sender, EventArgs e)
        {
            Program.UserCameFrom = "L8"; // Tracking where the user came from - This has to be first - Not sure why

            TestsForm TestForm = new TestsForm();

            this.Hide();

            TestForm.Show();
        }

        // Main Menu Button
        private void Panel18MenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm MenuForm = new MainMenuForm();
            this.Hide();
            MenuForm.Show();
        }

        // Back Button
        private void Panel18BackButton_Click(object sender, EventArgs e)
        {
            Panel18.Hide();
        }
        #endregion 

        #endregion

        // REMEBER TO UPDATE IS COPIED FORMAT // REMEBER TO UPDATE IS COPIED FORMAT
        #region User Closes the form Via the x
        private void HiraganaLesson8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }







        #endregion

        
    }
}
    

    




