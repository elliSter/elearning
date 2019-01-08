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
    public partial class Credits : Form
    {
        Thread thread;

        public Credits()
        {
            InitializeComponent();
        }
        

        private void menuButton_Clicked(object sender, EventArgs e)
        {

            this.Close();
            thread = new Thread(openMainMenu);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void openMainMenu(object obj)
        {
            Application.Run(new MainMenu());
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.CadetBlue;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkSlateGray;
        }
    }
}
