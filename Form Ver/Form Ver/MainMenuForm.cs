using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Form_Ver
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            JapanesePanel.Hide(); // To hide the panel at the begining
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------
        //-------------------------------------------------------------------
        /// <summary>
        /// For if the user closes the programmer via the x on the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e) // User hits the x button on window
        {
            Application.Exit(); // Closes the programme 
        }

        
        //-------------------------------------------------------------------
        //-------------------------------------------------------------------

        private void JapaneseButton_Click(object sender, EventArgs e)
        {
            JapanesePanel.Show();
        }

        #region Japanese Panel Resources
        //-------------------------------------------------------------------
        #region Go back Button
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            JapanesePanel.Hide();
        }
        #endregion
        //-------------------------------------------------------------------
        private void JapanesePanel_Paint(object sender, PaintEventArgs e) // Panel to show the three Writting systems 
        {

        }
        #region Hiragana
        /// <summary>
        ///  This will run the hiragana lesson button is clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <return> It will show the hiragana menu form </return>
        private void HiraganaButton_Click(object sender, EventArgs e) // Hiragana Button
        {
            HiraganaMenu HiraganaMenuForm = new HiraganaMenu(); // Initalising the Hiragana menu form 
            this.Hide(); // Hides the form being used
            HiraganaMenuForm.Show(); // Shows the new form
        }
        //-------------------------------------------------------------------
        #endregion

        #region Kanji
        /// <summary>
        /// This will be run when the Kanji Button is selected 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <return> This will show the Kanji Menu form </return>
        private void KanjiButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides the current form
            KanjiMenu Kanji = new KanjiMenu();
            Kanji.Show();
        }

        #endregion
        //-------------------------------------------------------------------
        #endregion

        
    }
}
