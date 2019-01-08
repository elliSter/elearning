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
{ //testingcomm
    public partial class startForm : Form
    {
        public static int temp_id=1;
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

            OleDbConnection conn = new OleDbConnection();
            string appPath = Application.StartupPath;
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "SELECT * FROM Accounts123";
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            bool no_info = false;
            bool wrong_info = false;
            bool nerrorb = false;
            temp_id = 0;
            while (reader.Read())
            {
                if (textBox1.Text.Equals(reader["Username1"]))
                {
                    if (textBox2.Text.Equals(reader["Password2"]))
                    {
                        temp_id = Convert.ToInt32(reader["ID"]);
                        nerrorb = true;
                        player.controls.stop();
                        this.Close();
                        thread = new Thread(openMainMenuForm);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                }

            }
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            string message = "You did not enter valid Information.";
            string caption = "Error Detected in Input";
            DialogResult result;
            if (!nerrorb)
            {
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {

                    // Closes the parent form.

                    //this.Close();

                }
            }
            conn.Close();

            
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
            player.controls.play();
            soundOn.Visible = true;
        }

        private void soundOn_Click_1(object sender, EventArgs e)
        {
            soundOn.Visible = false;
            player.controls.stop();
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

        private void startForm_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
