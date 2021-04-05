using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class HiraganaLesson1 : Form
    {

        #region Form Components
        public HiraganaLesson1()
        {
            InitializeComponent();

            // Hiding the panels to start with
            Panel1.Hide();
            Panel2.Hide();
            Panel3.Hide();
            Panel4.Hide();
            Panel5.Hide();
        }

        private void HiraganaLesson1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This will be run in an event that the user hits the cross button on the window
        /// What this will do is make sure the application will close down instead
        /// of running in the background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HiraganaLesson1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Closes the programme
        }





        #endregion

        #region Main Form - あ

        #region Back and Next Buttons

        /// <summary>
        /// This will run when the "back" button is selected
        /// This will effectively take the user to the previous form which
        /// is the lesson menu form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e) // back Button - Form Version
        {
            HiraganaMenu LessonMenu = new HiraganaMenu(); // Initialise the new form
            this.Hide(); // Hide the current form
            LessonMenu.Show();
        }

        //-------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------

        /// <summary>
        /// This will run when the "next" button is selected 
        /// This will hide the current pannel and show the next one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e) // Next button - Form Version
        {
            Panel1.Show(); // Shows the next form
        }






        #endregion

        #region Main Form labels
        /// <summary>
        /// label 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSet1Label1_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSet1Label2_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSet1Label3_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSet1Label4_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LabelSet1Label5_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region Panel 1 - い

        #region Labels
        /// <summary>
        /// Label 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1Label1_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1Label2_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1Label3_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Back and Next Buttons
        /// <summary>
        /// This will run when the back button is selected
        /// This will hide panel 1 and show just the native form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel1BackButton_Click(object sender, EventArgs e)
        {
            Panel1.Hide(); // Hides the current Panel
        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        private void Panel1NextButton_Click(object sender, EventArgs e)
        {
            Panel2.Show(); // Shows the next panel
        }

        #endregion

        #endregion

        #region Panel 2 - う

        #region Labels
        /// <summary>
        /// Label 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel2Label1_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel2Label2_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Label 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel2Label3_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Back and Next Button
        /// <summary>
        /// This will run when the user has selected the back button
        /// This will hide the current panel being shown (panel 2)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel2BackButton_Click(object sender, EventArgs e)
        {
            Panel2.Hide(); // Hide the current pannel being shown
        }

        /// <summary>
        /// This will be run when the user selects the next button
        /// This will show the next panel (panel 3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel2NextButton_Click(object sender, EventArgs e)
        {
            Panel3.Show(); // Shows the next panel
        }



        #endregion

        #endregion

        #region Panel 3 - え

        #region Labels
        private void Panel3Label1_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        private void Panel3Label2_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        private void Panel3label3_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Back and Next Buttons
        /// <summary>
        /// This will be run when the user selects the back button
        /// This will hide the current panel (panel 3)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel3BackButton_Click(object sender, EventArgs e)
        {
            Panel3.Hide(); // Hides the current pannel
        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This will run when the user has selected the next button
        /// This will show the next pannel (panel 4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel3NextButton_Click(object sender, EventArgs e)
        {
            Panel4.Show(); // Show the next form
        }


        #endregion

        #endregion

        #region Panel 4 - お

        #region Labels
        private void Panel4Label1_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        private void Panel4Label2_Click(object sender, EventArgs e)
        {

        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        private void Panel4Label3_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Back and Next Buttons
        /// <summary>
        /// This will be run when the user selects the back button
        /// This will hide the current panel being shown (panel 4)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel4BackButton_Click(object sender, EventArgs e)
        {
            Panel4.Hide(); // Hide the current panel
        }

        //-------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------

        /// <summary>
        /// This will be run when the user selects the next button 
        /// This will show the next panel (panel 5)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel4NextButton_Click(object sender, EventArgs e)
        {
            Panel5.Show(); // Show the next panel
        }

        #endregion

        #endregion

        #region Panel 5 - Test or Menu Selection

        #region Labels
        private void Panel5Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel5Label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Test Buttons and Labels

        #region Speed Test
        private void Panel5Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel5TestButton_Click(object sender, EventArgs e) // Speed test button
        {
            Program.UserCameFrom = "L1"; // Tracking where the user came from - This has to be first - Not sure why

            TestsForm TestForm = new TestsForm();
            
            this.Hide();
            
            TestForm.Show();
        }
        #endregion

        #region Choice Test NOT DONE
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Panel5Label5_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

        #region Lesson Menu Button and Label
        private void Panel5Label4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This will be run when the user selects the Menu button 
        /// This will take the user to the lesson menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel5LessonMenuButton_Click(object sender, EventArgs e)
        {
            HiraganaMenu LessonMenu = new HiraganaMenu(); // Initialising the Hiragana menu form
            this.Hide(); // Hiding the current form
            LessonMenu.Show(); // Show the new form
        }


        #endregion

        #region Go Back  Button
        /// <summary>
        /// This will take the user to last panel
        /// This will effectively hide the current panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Panel5BackButton_Click(object sender, EventArgs e)
        {
            Panel5.Hide(); // Hide current panel
        }

        #endregion

        #endregion

        
    }



}
