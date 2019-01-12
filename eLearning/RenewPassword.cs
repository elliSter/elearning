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
{
    public partial class Renew_Password : Form
    {
        Thread thread;
        int apot,gamie;
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        
        

        public Renew_Password()
        {
            InitializeComponent();
            //player.URL = @"C:\Users\Elli\source\repos\WindowsFormsApp1\onceagain.mp3";
            //player.controls.play();

            //for "captcha" authantication
            //Captcha(label6);
            apot= Captcha(label6);

            
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


        private void button2_Click(object sender, EventArgs e)
        {

            OleDbConnection conn = new OleDbConnection();
            string appPath = Application.StartupPath;
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "SELECT * FROM Accounts123";
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();

            bool nerrorb = false;
            String strSQL2;
            startForm.temp_id = 0;

            Random random = new Random();


            gamie = Convert.ToInt32(textBox5.Text);
            Console.WriteLine(apot + "-----" + gamie);

            while (reader.Read())
            {
                
                if(gamie != apot)
                {
                    apot = Captcha(label6);
                }
                if (gamie == apot)
                 {

                    if (textBox1.Text.Equals(reader["Username1"]))
                    {
                        if (textBox2.Text.Equals(reader["Password2"]))
                        {
                            if (textBox3.Text == textBox4.Text)
                            {
                                startForm.temp_id = Convert.ToInt32(reader["ID"]);

                                strSQL2 = "UPDATE Accounts123 SET Password2=" + textBox4.Text + " WHERE ID=" + startForm.temp_id;

                                OleDbCommand command2 = new OleDbCommand(strSQL2, conn);
                                OleDbDataReader reader2 = command2.ExecuteReader();

                                nerrorb = true;
                                player.controls.stop();
                                this.Close();
                                thread = new Thread(openMainMenuForm);
                                thread.SetApartmentState(ApartmentState.STA);
                                thread.Start();
                            }


                        }
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

        public static int Captcha(Label label)
        {
            int n1, n2, operation , apot=0;
            Random rnd = new Random();
            n1 = rnd.Next(1, 11);
            n2 = rnd.Next(1, 11);
           
            operation = rnd.Next(1, 4);
            
            switch (operation)
            {
                case 1:
                    label.Text = (n1 + " + " + n2);
                    apot = n1 + n2;
                    break;
                case 2:
                    label.Text = (n1 + " - " + n2);
                    apot = n1 - n2;
                    break;
                case 3:
                    label.Text = (n1 + " * " + n2);
                    apot = n1 * n2;
                    break;
            }
            return apot;
        }
    }
}
