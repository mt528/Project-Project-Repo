using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Ver
{
    
    public partial class IntroductionForm : Form
    {
        

        public IntroductionForm()
        {
            InitializeComponent();
        }

        private void IntroductionForm_Load(object sender, EventArgs e)
        {

        }

        
        //---------------------------------------------------------------------------------
        //---------------------------------------------------------------------------------
        private void IntroductionButton_Click(object sender, EventArgs e) // Intro Button 
        {
            MainMenuForm MainMenu = new MainMenuForm();
            this.Hide(); // Hiding the current form
            MainMenu.Show(); // Showing the new main menu form 
            
        }
        /// <summary>
        /// This is for if the user hits the close button on the window
        /// The aim is to make the programme close entierly rather than running in the background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IntroductionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Closes the programe
        }
    }
}
