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
{
    public partial class SignUp : Form
    {
        Thread thread;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public SignUp()
        {
            InitializeComponent();
            //player.URL = @"C:\Users\Elli\source\repos\WindowsFormsApp1\onceagain.mp3";
            //player.controls.play();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Close();
            thread = new Thread(openStartForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openStartForm(object obj)
        {
            Application.Run(new startForm());
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "cat")
            {
                player.controls.stop();
                this.Close();
                thread = new Thread(openMainMenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            else MessageBox.Show("Wrong animal, try again");
        }

        private void openMainMenu(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
