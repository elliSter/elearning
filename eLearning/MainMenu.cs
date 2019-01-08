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
using System.Data.OleDb;

namespace eLearning
{
    public partial class MainMenu : Form
    {
        Thread thread;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public MainMenu()
        {
            InitializeComponent();
            player.URL = @"betterdays.mp3";
            player.controls.play();
            
            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "SELECT * FROM Accounts123";
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (startForm.temp_id == Convert.ToInt32(reader["ID"]))
                {
                    EnglishToGreek.lvl = Convert.ToInt32(reader["Level5"]);
                }
            }
            label4.Text = "Level: " + EnglishToGreek.lvl;
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
            player.controls.play();
            soundOn.Visible = true;
        }

        private void soundOn_Click(object sender, EventArgs e)
        {
            soundOn.Visible = false;
            player.controls.stop();
            soundOff.Visible = true;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EnglishToGreek.en_gr = 0;
            player.controls.stop();
            this.Close();
            thread = new Thread(openEnToGr);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openEnToGr(object obj)
        {
            Application.Run(new EnglishToGreek());
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.CadetBlue;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnglishToGreek.en_gr = 1;
            player.controls.stop();
            this.Close();
            thread = new Thread(openEnToGr); //form2
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
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

        private void credits_Click(object sender, EventArgs e)
        {
            EnglishToGreek.en_gr = 0;
            player.controls.stop();
            this.Close();
            thread = new Thread(openCredits);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openCredits(object obj)
        {
            Application.Run(new Credits());
        }

        private void credits_MouseEnter(object sender, EventArgs e)
        {
            credits.BackColor = Color.CadetBlue;
        }

        private void credits_MouseLeave(object sender, EventArgs e)
        {
            credits.BackColor = Color.DarkSlateGray;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //show
            pictureBox2.Show();
            //hide
            pictureBox5.Hide();
            //----------------------- NEW CHANGES ----------------------------
            
            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL="UPDATE Accounts123 SET Rating6=" + 1 + " WHERE ID=" + startForm.temp_id;
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            
            Console.WriteLine("pB5 - Clicked!");
            Console.WriteLine("1");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //show
            pictureBox2.Show();
            pictureBox3.Show();
            //hide
            pictureBox5.Hide();
            pictureBox6.Hide();
            Console.WriteLine("pB6 - Clicked!");

            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "UPDATE Accounts123 SET Rating6=" + 2 + " WHERE ID=" + startForm.temp_id;
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            Console.WriteLine("2");

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //show
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            //hide
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            Console.WriteLine("pB7 - Clicked!");

            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "UPDATE Accounts123 SET Rating6=" + 3 + " WHERE ID=" + startForm.temp_id;
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            Console.WriteLine("3");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //no rate
            //show
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            //hide
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            Console.WriteLine("pB2 - Clicked!");
            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "UPDATE Accounts123 SET Rating6=" + 0 + " WHERE ID=" + startForm.temp_id;
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            Console.WriteLine("0");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //rate as 1 star
            //show
            pictureBox2.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            //hide
            pictureBox5.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            Console.WriteLine("pB3 - Clicked!");
            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "UPDATE Accounts123 SET Rating6=" + 1 + " WHERE ID=" + startForm.temp_id;
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            Console.WriteLine("1");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //rate 2 stars
            //show
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox7.Show();
            //hide
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox4.Hide();
            Console.WriteLine("pB4 - Clicked!");
            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "UPDATE Accounts123 SET Rating6=" + 2 + " WHERE ID=" + startForm.temp_id;
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            Console.WriteLine("2");
        }
    }
}
