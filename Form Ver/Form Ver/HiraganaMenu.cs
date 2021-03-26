﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class HiraganaMenu : Form
    {
        #region Form Components
        public HiraganaMenu()
        {
            InitializeComponent();
        }
        private void HiraganaMenu_Load(object sender, EventArgs e)
        {

        }
        private void HiraganaMenu_FormClosed(object sender, FormClosedEventArgs e) // This runs when the x is pressed on the form
        {
            Application.Exit(); // Close the programe
        }
        #endregion 
        private void ExplanationLabel_Click(object sender, EventArgs e)
        {

        }


        #region Lesson and Test Components
        #region Lesson 1 
        private void Lesson1Label_Click(object sender, EventArgs e) // Lesson 1 label
        {

        }

        /// <summary>
        /// This is the button that will lead to the lesson 1 for Hiragana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lesson1Button_Click(object sender, EventArgs e) // Lesson 1 Button
        {
            HiraganaLesson1 Lesson1 = new HiraganaLesson1(); // Initalising the new form 
            this.Hide(); // Hide the current form
            Lesson1.Show(); // Show the new form 
        }
        #endregion

        #region Lesson 2
        private void Lesson2Label_Click(object sender, EventArgs e)
        {

        }

        private void Lesson2Button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lesson 3
        private void Lesson3Label_Click(object sender, EventArgs e)
        {

        }

        private void Lesson3Button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lesson 4
        private void Lesson4Label_Click(object sender, EventArgs e)
        {

        }

        private void Lesson4Button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lesson 5
        private void Lesson5Label_Click(object sender, EventArgs e)
        {

        }

        private void Lesson5Button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lesson 6
        private void Lesson6Label_Click(object sender, EventArgs e)
        {

        }

        private void Lesson6Button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lesson 7
        private void Lesson7Label_Click(object sender, EventArgs e)
        {

        }

        private void Lesson7Button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lesson 8
        private void Lesson8Label_Click(object sender, EventArgs e)
        {

        }

        private void Lesson8Button_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Lesson Test
        private void ClassTestLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClassTestButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #endregion



        #region Go Back Button
        /// <summary>
        /// This will take the user to the last form 
        /// Effectively its a 'prevoius' or 'go back' button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            MainMenuForm MainMenu = new MainMenuForm(); // Initialise the main menu form

            this.Hide(); // Hide the current form 
            MainMenu.Show(); // Show the main menu form
        }







        #endregion

        
    }
}
