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
using System.Data.OleDb;

namespace eLearning
{//tst
    public partial class SignUp : Form
    {
        Thread thread;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        int apot,gamie;
        public SignUp()
        {
            InitializeComponent();
            player.URL = @"onceagain.mp3";
            player.controls.play();
            apot = Renew_Password.Captcha(label6);
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

            OleDbConnection conn = new OleDbConnection();
            string appPath = Application.StartupPath;
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string str2 = "select * from Accounts123";
            OleDbCommand command2 = new OleDbCommand(str2, conn);
            OleDbDataReader reader2 = command2.ExecuteReader();
            long id2 = 0;

            gamie = Convert.ToInt32(textBox4.Text);
            Console.WriteLine(apot + "-----" + gamie);


            while (reader2.Read())
            {
                
               
                Console.WriteLine("____" + reader2["ID"]);
                if (id2< Convert.ToInt64(reader2["ID"]))
                {
                    id2 = Convert.ToInt64(reader2["ID"]);
                    Console.WriteLine(id2);
                }
                
            }            
            reader2.Close();
            int id = Convert.ToInt32(id2) + 1;
            string str1SQL = "INSERT INTO Accounts123 (ID,Username1,Password2,Fullname3,Correct4,Level5,Rating6) VALUES('";
            string strSmall = "')";
            string strSmall2 = "','";
            if (gamie == apot)
            {
                
                string fullSQL = str1SQL + id + strSmall2 + textBox1.Text + strSmall2 + textBox3.Text + strSmall2 + textBox2.Text + strSmall2 + "0" + strSmall2 + 0 + strSmall2 + 0 + strSmall;
                OleDbCommand command = new OleDbCommand(fullSQL, conn);
                OleDbDataReader reader = command.ExecuteReader();
                reader.Close();
                startForm.temp_id = id;

                player.controls.stop();
                this.Close();
                thread = new Thread(openMainMenu);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }else if(textBox3.Text!=textBox5.Text)
                {
                MessageBox.Show("Passwords, don't match");
            }
            
            else if ( textBox1.Text == "" || textBox2.Text=="" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Please fill the empty boxes");
            }
            else
            {
                MessageBox.Show("Wrong number, try again");
                apot = Renew_Password.Captcha(label6);
                Console.WriteLine("Something went wrong with your registration.");
            }
            
            conn.Close();
            
        }

        private void openMainMenu(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

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

        private void soundOff_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
