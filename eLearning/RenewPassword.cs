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
    public partial class Renew_Password : Form
    {
        Thread thread;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public Renew_Password()
        {
            InitializeComponent();
            //player.URL = @"C:\Users\Elli\source\repos\WindowsFormsApp1\onceagain.mp3";
            //player.controls.play();
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();

            //gia na anoigei to menu
            thread = new Thread(openStartForm);

            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openStartForm(object obj)
        {
            Application.Run(new startForm());
        }
        private void Renew_Password_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
