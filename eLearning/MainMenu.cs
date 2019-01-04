using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.Threading;


namespace eLearning
{
    public partial class MainMenu : Form
    {
        Thread thread;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public MainMenu()
        {
            InitializeComponent();
            player.URL = @"onceagain.mp3";
            player.controls.play();
        }

        private void logOut_Click(object sender, EventArgs e)
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

        private void soundOff_Click(object sender, EventArgs e)
        {
            soundOff.Visible = false;
            player.controls.stop();
            soundOn.Visible = true;
        }

        private void soundOn_Click(object sender, EventArgs e)
        {
            soundOn.Visible = false;
            player.controls.play();
            soundOff.Visible = true;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Practise practise = new Practise();
            practise.Show();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.CadetBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.Show();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.CadetBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkSlateGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateGray;
            
        }

        private void help_Click(object sender, EventArgs e)
        {
            Help help1 = new Help();
            help1.Show();


        }
    }
}
