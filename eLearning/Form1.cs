using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLearning
{
    public partial class startForm : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public startForm()
        {
            InitializeComponent();
            player.URL = @"C:\Users\Elli\source\repos\WindowsFormsApp1\onceagain.mp3";
            player.controls.play();
            
        }

        private void forgottenPassword_Click(object sender, EventArgs e)
        {
            Renew_Password renew_Password = new Renew_Password();
            renew_Password.Show();
            
            
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            

        }


        private void login_MouseEnter(object sender, EventArgs e)
        {
            logIn.BackColor = Color.CadetBlue;
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            
        }

        private void soundOff_Click(object sender, EventArgs e)
        {
            soundOff.Visible = false;
            player.controls.stop();
            soundOn.Visible = true;
        }

        private void soundOn_Click_1(object sender, EventArgs e)
        {
            soundOn.Visible = false;
            player.controls.play();
            soundOff.Visible = true;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            logIn.BackColor = Color.DarkSlateGray;
        }

        private void SignUp_MouseEnter(object sender, EventArgs e)
        {
            signUp.BackColor = Color.CadetBlue;
        }

        private void SignUp_MouseLeave(object sender, EventArgs e)
        {
            signUp.BackColor = Color.DarkSlateGray;
        }

        
    }
}
