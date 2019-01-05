using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace eLearning
{ //testingcomm
    public partial class startForm : Form
    {
        Thread thread;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public startForm()
        {
            InitializeComponent();
            player.URL = @"onceagain.mp3"; 
            player.controls.play();
            
        }

        private void forgottenPassword_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Close();
            thread = new Thread(openForgottenPasswordForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openForgottenPasswordForm(object obj)
        {
            Application.Run(new Renew_Password());
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Close();
            thread = new Thread(openMainMenuForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openMainMenuForm(object obj)
        {
            Application.Run(new MainMenu());
        }


        private void login_MouseEnter(object sender, EventArgs e)
        {
            logIn.BackColor = Color.CadetBlue;
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Close();
            thread = new Thread(openSignUpForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openSignUpForm(object obj)
        {
            Application.Run(new SignUp());
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

        private void startForm_Load(object sender, EventArgs e)
        {

        }
    }
}
