using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class HiraganaLesson3 : Form
    {
        public HiraganaLesson3()
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

        #region T's Panel's 2 - 6 

        #region Panel 2 - た
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

        #region Panel 3 - ち
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

        #region Panel 4 - つ
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

        #region Panel 5 - て
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

        #region Panel 6 - と
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

        #region N's Panel's 7 - 11 

        #region Panel 7 - な
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

        #region Panel 8 - に
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

        #region Panel 9 - ぬ
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

        #region Panel 10 - ね
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

        #region Panel 11 - の
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

        #region Test select Panel
        // Speed Test Button
        private void Panel12SpeedTestButton_Click(object sender, EventArgs e)
        {
            Program.UserCameFrom = "L3"; // Tracking where the user came from - This has to be first - Not sure why

            TestsForm TestForm = new TestsForm();

            this.Hide();

            TestForm.Show();
        }

        // Main Menu Button
        private void Panel12MenuButton_Click(object sender, EventArgs e)
        {
            MainMenuForm MenuForm = new MainMenuForm();
            this.Hide();
            MenuForm.Show();
        }

        // Back Button
        private void Panel12BackButton_Click(object sender, EventArgs e)
        {
            Panel12.Hide();
        }
        #endregion

        #endregion

        #region User Closes the form Via the x
        private void HiraganaLesson3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }






        #endregion

        
    }
}
    

    




