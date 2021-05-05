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
        }

        #region Lesson Contents

        #region K's Panels 1 - 5 FINSIH

        #region か - Panel 1 
        #endregion

        #region き - Panel 2 
        #endregion

        #region く- Panel 3 
        #endregion

        #region け - Panel 4 
        #endregion

        #region こ - Panel 5 
        #endregion

        #endregion

        #region S's FINSIH
        #region さ - Panel 6 
        #endregion

        #region し - Panel 7 
        #endregion

        #region す - Panel 8 
        #endregion

        #region せ - Panel 9 
        #endregion

        #region そ - Panel 10
        #endregion

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
