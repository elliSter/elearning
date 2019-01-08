using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;


namespace eLearning
{
    public partial class EnglishToGreek : Form
    {
        //Public Variables
        //commit test 
        public static int quest_id;
        public static int answ1_id;
        public static int answ2_id;
        public static int answ3_id;
        public static int en_gr = 0;
        public static string cor_answ;
        public static int temp_cor;

        //for sounds
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        //
        Thread thread;

        public EnglishToGreek()
        {
            InitializeComponent();
            player.URL = @"betterdays.mp3";
            player.controls.play();


        }

        private void EnglishToGreek_Load(object sender, EventArgs e)
        {
            //startForm.temp_id = 1;
            string appPath = Application.StartupPath;
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            string strSQL = "SELECT * FROM Accounts123";
            OleDbCommand command = new OleDbCommand(strSQL, conn);
            OleDbDataReader reader = command.ExecuteReader();
            //int temp_correct;
            string strSQL_lvl = "SELECT * FROM Accounts123";
            while (reader.Read())
            {
                //label3.Text = "Correct: " + temp_cor;
                
                if (startForm.temp_id == Convert.ToInt32(reader["ID"]))
                {
                    temp_cor = Convert.ToInt32(reader["Correct4"]);
                    label3.Text = "Correct: " + temp_cor;
                    Console.WriteLine("==============================================================================================================ID LINE = "+temp_cor);
                    //=-------------------------------------- LEVEL --------------------------------------
                    if (temp_cor < 50)
                    {
                        strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 0 + " WHERE ID = " + startForm.temp_id;
                    }
                    else
                    {
                        if (temp_cor < 100)
                        {
                            strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 1 + " WHERE ID = " + startForm.temp_id;
                        }
                        else
                        {
                            if (temp_cor < 150)
                            {
                                strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 2 + " WHERE ID = " + startForm.temp_id;
                            }
                            else
                            {
                                if (temp_cor < 200)
                                {
                                    strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 3 + " WHERE ID = " + startForm.temp_id;
                                }
                                else
                                {
                                    if (temp_cor < 250)
                                    {
                                        strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 4 + " WHERE ID = " + startForm.temp_id;
                                    }
                                    else
                                    {
                                        if (temp_cor < 300)
                                        {
                                            strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 5 + " WHERE ID = " + startForm.temp_id;
                                        }
                                        else
                                        {
                                            if (temp_cor < 350)
                                            {
                                                strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 6 + " WHERE ID = " + startForm.temp_id;
                                            }
                                            else
                                            {
                                                if (temp_cor < 400)
                                                {
                                                    strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 7 + " WHERE ID = " + startForm.temp_id;
                                                }
                                                else
                                                {
                                                    if (temp_cor < 450)
                                                    {
                                                        strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 8 + " WHERE ID = " + startForm.temp_id;
                                                    }
                                                    else
                                                    {
                                                        if (temp_cor < 500)
                                                        {
                                                            strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 9 + " WHERE ID = " + startForm.temp_id;
                                                        }
                                                        else
                                                        {
                                                            if (temp_cor < 550)
                                                            {
                                                                strSQL_lvl = "UPDATE Accounts123 SET Level5 = " + 10 + " WHERE ID = " + startForm.temp_id;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    OleDbCommand command2 = new OleDbCommand(strSQL_lvl, conn);
                    OleDbDataReader reader2 = command2.ExecuteReader();
                    //=-------------------------------------- LEVEL --------------------------------------
                }

            }


            EnglishToGreek.quest_id = RandomNumber(4, 60000);
            EnglishToGreek.answ1_id = EnglishToGreek.quest_id;
            EnglishToGreek.answ2_id = RandomNumber(3, 67000);
            EnglishToGreek.answ3_id = RandomNumber(3, 65000);
            Console.WriteLine("answ1_id = " + answ1_id + " || answ1_id = " + answ2_id + " || answ1_id = " + answ3_id + " ||====()()====|| Corrects : " + temp_cor);

            int correct = RandomNumber(0, 65000);
            int fail1 = correct % 2;
            int fail2 = correct % 3;

            string cor = "1";
            string fa1 = "2";
            string fa2 = "3";


            

            
            if (EnglishToGreek.en_gr == 0)
            {

                OleDbConnection conn2 = new OleDbConnection();
                conn2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/wordDB2.accdb";
                conn2.Open();
                string str2SQL = "SELECT * FROM Names123";
                OleDbCommand command2 = new OleDbCommand(str2SQL, conn2);
                OleDbDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    if (EnglishToGreek.answ1_id == Convert.ToInt32(reader2["ID"]))
                    {
                        cor = reader2["Field2"].ToString();
                        label1.Text = reader2["Field1"].ToString();
                        Console.WriteLine("Correct Word:" + cor + "-----------");
                    }
                    if (EnglishToGreek.answ2_id == Convert.ToInt32(reader2["ID"]))
                    {
                        fa1 = reader2["Field2"].ToString();
                    }
                    if (EnglishToGreek.answ3_id == Convert.ToInt32(reader2["ID"]))
                    {
                        fa2 = reader2["Field2"].ToString();
                    }
                    //===================================
                    EnglishToGreek.cor_answ = cor;
                    if (fail1 == 0)
                    {
                        radioButton1.Text = cor;
                        radioButton2.Text = fa2;
                        radioButton3.Text = fa1;
                    }
                    else if (fail2 == 0)
                    {
                        radioButton1.Text = fa1;
                        radioButton2.Text = fa2;
                        radioButton3.Text = cor;
                    }
                    else if (correct < 35162)
                    {
                        radioButton1.Text = fa2;
                        radioButton2.Text = cor;
                        radioButton3.Text = fa1;
                    }


                }

                Console.WriteLine("cor = _" + cor + "_ || fa1 = _" + fa1 + "_ || fa2 = _" + fa2 + "_");
                reader2.Close();
                conn2.Close();

            }
            //=======================================================================================================================================================================================
            
            if (EnglishToGreek.en_gr == 1)
            {
                OleDbConnection conn2 = new OleDbConnection();
                conn2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/wordDB2.accdb";
                conn2.Open();
                string str2SQL = "SELECT * FROM Names123";
                OleDbCommand command2 = new OleDbCommand(str2SQL, conn2);
                OleDbDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    if (EnglishToGreek.answ1_id == Convert.ToInt32(reader2["ID"]))
                    {
                        cor = reader2["Field1"].ToString();
                        label1.Text = reader2["Field2"].ToString();
                    }
                    if (EnglishToGreek.answ2_id == Convert.ToInt32(reader2["ID"]))
                    {
                        fa1 = reader2["Field1"].ToString();
                    }
                    if (EnglishToGreek.answ3_id == Convert.ToInt32(reader2["ID"]))
                    {
                        fa2 = reader2["Field1"].ToString();
                    }
                    //====================
                    EnglishToGreek.cor_answ = cor;
                    if (fail1 == 0)
                    {
                        radioButton1.Text = cor;
                        radioButton2.Text = fa2;
                        radioButton3.Text = fa1;
                    }
                    else if (fail2 == 0)
                    {
                        radioButton1.Text = fa1;
                        radioButton2.Text = fa2;
                        radioButton3.Text = cor;
                    }
                    else if (correct < 35162)
                    {
                        radioButton1.Text = fa2;
                        radioButton2.Text = cor;
                        radioButton3.Text = fa1;
                    }
                    else
                    {
                        radioButton1.Text = cor;
                        radioButton2.Text = fa2;
                        radioButton3.Text = fa1;
                    }

                }


                Console.WriteLine("cor = _" + cor + "_ || fa1 = _" + fa1 + "_ || fa2 = _" + fa2 + "_");
                reader2.Close();
                conn2.Close();

            }
            
            


            //===============================================================
            reader.Close();
            conn.Close();


        }


        private void button1_Click(object sender, EventArgs e)
        {
            //design
            button1.Show();
            label3.Show();
            pictureBox1.Hide();
            //button1.Text = " Submit ";
            button1.Text = "Submit";
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.White;
            string appPath = Application.StartupPath;
            //
            //=================================================================================
            OleDbConnection conn2 = new OleDbConnection();
            conn2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn2.Open();
            string strSQL2 = "SELECT * FROM Accounts123";
            OleDbCommand command2 = new OleDbCommand(strSQL2, conn2);
            OleDbDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                if (startForm.temp_id == Convert.ToInt32(reader2["ID"]))
                {
                    temp_cor = Convert.ToInt32(reader2["Correct4"]);
                    label3.Text = "Correct: " + temp_cor;
                    Console.WriteLine("==============================================================================================================ID reader2 = " + reader2["ID"] + " || ID temp_id = " + startForm.temp_id + " || temp_cor = " + temp_cor + " || Reader2 Correct = " + reader2["Correct4"]);
                }
            }
            //=================================================================================

            OleDbConnection conn = new OleDbConnection();
            
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "/eLearning_acc.accdb";
            conn.Open();
            int new_cor;
            string strSQL;


            if ((groupBox1.Controls[0].Text.Equals(EnglishToGreek.cor_answ)|| groupBox1.Controls[0].Text.Equals(" "+EnglishToGreek.cor_answ)) && radioButton3.Checked)
            {

                new_cor = EnglishToGreek.temp_cor + 1;
                EnglishToGreek.temp_cor = new_cor;
                strSQL = "UPDATE Accounts123 SET Correct4=" + new_cor + " WHERE ID=" + startForm.temp_id;
                OleDbCommand command = new OleDbCommand(strSQL, conn);
                OleDbDataReader reader = command.ExecuteReader();
                //groupBox1.Controls[0].Text += "_hi";
                Console.WriteLine(groupBox1.Controls[0].Text + "---------------------===========================CORRECT!!!===========================---------------------");
                label3.Text = "Correct: " + EnglishToGreek.temp_cor + " || " + new_cor;
            }
            else if ((groupBox1.Controls[1].Text.Equals(EnglishToGreek.cor_answ) || groupBox1.Controls[1].Text.Equals(" " + EnglishToGreek.cor_answ)) && radioButton2.Checked)
            {
                new_cor = EnglishToGreek.temp_cor + 1;
                EnglishToGreek.temp_cor = new_cor;
                strSQL = "UPDATE Accounts123 SET Correct4=" + new_cor + " WHERE ID=" + startForm.temp_id;
                OleDbCommand command = new OleDbCommand(strSQL, conn);
                OleDbDataReader reader = command.ExecuteReader();
                //groupBox1.Controls[1].Text += "_hi";
                Console.WriteLine(groupBox1.Controls[1].Text + "---------------------===========================CORRECT!!!===========================---------------------");
                label3.Text = "Correct: " + EnglishToGreek.temp_cor + " || " + new_cor;

            }
            else if ((groupBox1.Controls[2].Text.Equals(EnglishToGreek.cor_answ) || groupBox1.Controls[2].Text.Equals(" " + EnglishToGreek.cor_answ)) && radioButton1.Checked)
            {
                new_cor = EnglishToGreek.temp_cor + 1;
                EnglishToGreek.temp_cor = new_cor;
                strSQL = "UPDATE Accounts123 SET Correct4=" + new_cor + " WHERE ID=" + startForm.temp_id;
                OleDbCommand command = new OleDbCommand(strSQL, conn);
                OleDbDataReader reader = command.ExecuteReader();
                //groupBox1.Controls[2].Text += "_hi";
                Console.WriteLine(groupBox1.Controls[2].Text + "---------------------===========================CORRECT!!!===========================---------------------");
                label3.Text = "Correct: " + EnglishToGreek.temp_cor + " || " + new_cor;
            }
            else
            {
                Console.WriteLine("--------------------------------WRONG ANSWER--------------------------------");
            }
            Console.WriteLine("groupBox1.Controls[0].Text = _"+ groupBox1.Controls[0].Text + "_ || groupBox1.Controls[1].Text = _"+ groupBox1.Controls[1].Text + "_ || groupBox1.Controls[2].Text = _" + groupBox1.Controls[2].Text+"_");
            Console.WriteLine("Practise.cor_answ = _"+ EnglishToGreek.cor_answ +"_");
            Console.WriteLine("Radio 1 = " + radioButton1.Checked);
            Console.WriteLine("Radio 2 = " + radioButton2.Checked);
            Console.WriteLine("Radio 3 = " + radioButton3.Checked);
            EnglishToGreek_Load(this, e);
        }


        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        
        /*
        private void button2_Click(object sender, EventArgs e)
        {
            if (EnglishToGreek.en_gr == 0)
            {
                EnglishToGreek.en_gr = 1;
                button2.Text = "GR-EN";
            }
            else if (EnglishToGreek.en_gr == 1)
            {
                EnglishToGreek.en_gr = 0;
                button2.Text = "EN-GR";
            }
            Practise_Load(this, e);
        } */

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Practise_Load_1(object sender, EventArgs e)
        {

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

        private void menuButton_MouseEnter(object sender, EventArgs e)
        {
            menuButton.BackColor = Color.CadetBlue;
        }

        private void menuButton_MouseLeave(object sender, EventArgs e)
        {
            menuButton.BackColor = Color.DarkSlateGray;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            player.controls.stop();
            this.Close();
            thread = new Thread(openMainMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openMainMenu(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightCyan;
            button1.ForeColor = Color.DarkSlateGray;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkSlateGray;
            button1.ForeColor = Color.LightCyan;
        }

        private void radioButton1_MouseEnter(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.DarkSlateGray;
            radioButton1.BackgroundImage = global::eLearning.Properties.Resources.backhighl;
        }

        private void radioButton1_MouseLeave(object sender, EventArgs e)
        {
            radioButton1.ForeColor = Color.White;
            radioButton1.BackgroundImage = global::eLearning.Properties.Resources.back;
        }

        private void radioButton2_MouseEnter(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.DarkSlateGray;
            radioButton2.BackgroundImage = global::eLearning.Properties.Resources.backhighl;
        }

        private void radioButton2_MouseLeave(object sender, EventArgs e)
        {
            radioButton2.ForeColor = Color.White;
            radioButton2.BackgroundImage = global::eLearning.Properties.Resources.back;
        }

        private void radioButton3_MouseLeave(object sender, EventArgs e)
        {
            radioButton3.ForeColor = Color.White;
            radioButton3.BackgroundImage= global::eLearning.Properties.Resources.back;
        }

        private void radioButton3_MouseEnter(object sender, EventArgs e)
        {
            radioButton3.ForeColor = Color.DarkSlateGray;
            radioButton3.BackgroundImage = global::eLearning.Properties.Resources.backhighl;

        }

        private void soundOn_Click(object sender, EventArgs e)
        {
            soundOn.Visible = false;
            player.controls.stop();
            soundOff.Visible = true;
        }

        private void soundOff_Click(object sender, EventArgs e)
        {
            soundOff.Visible = false;
            player.controls.play();
            soundOn.Visible = true;
        }
    }
}
