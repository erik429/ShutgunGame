using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutgunGame.Classes
{
    public partial class Shop : Form
    {
        private int dollar;
        public Shop(int money)
        {
            InitializeComponent();
            dollar = money;
            label5.Text = "Money: " + money.ToString() + " $";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dollar >= 4000)
            {
                MessageBox.Show("You can buy");

            }
            else
            {
                MessageBox.Show("You can't buy");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Do you want to buy Shotgun?");
        }
    }
}
