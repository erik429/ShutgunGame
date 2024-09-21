using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShutgunGame.Classes
{
    public partial class Slots : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
        int m;
        int a;
        int b;
        int c;
        int cnt = 0;
        int credit = 0;
        int bet = 0;
        public int Money { get; set; }
        public Slots(int money)
        {
            credit = money;
            InitializeComponent();
        }

        private void Slots_Load(object sender, EventArgs e)
        {
            PlaySound2(@"C:\Demo\saloon.mp3");
            if (bet <= 0)
            {
                button1.Enabled = false;
            }
            lblMsg.Text = "";
            infolbl.Text = "Money: " + credit + " $";
            betlbl.Text = "Bet: " + bet + " $";
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            m += 10;
            if (m < 100)
            {

                a = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));

                b = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));

                c = (int)(Conversion.Int(1 + VBMath.Rnd() * 3));

                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile("C:\\Demo\\slots1.png");
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile("C:\\Demo\\slots2.png");
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile("C:\\Demo\\slots3.png");
                        break;

                }

                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Image.FromFile("C:\\Demo\\slots1.png");
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile("C:\\Demo\\slots2.png");
                        break;
                    case 3:
                        pictureBox2.Image = Image.FromFile("C:\\Demo\\slots3.png");
                        break;

                }
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Image.FromFile("C:\\Demo\\slots1.png");
                        break;
                    case 2:
                        pictureBox3.Image = Image.FromFile("C:\\Demo\\slots2.png");
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile("C:\\Demo\\slots3.png");
                        break;

                }

            }
            else
            {
                cnt++;
                button1.Enabled = true;
                {
                    timer1.Enabled = false;
                    m = 0;
                    if ((a == b) && (a == c))
                    {
                        PlaySound(@"C:\Demo\jackpot.mp3");
                        lblMsg.Text = "Jackpot! You won x4 " + bet.ToString() + " $";
                        int winning = bet * 4;
                        credit = credit + winning - bet;
                        infolbl.Text = "CREDIT: " + credit.ToString() + " $";

                    }
                    else if ((a == b) && (b == a))
                    {

                        PlaySound(@"C:\Demo\cash.mp3");
                        lblMsg.Text = "2 Pair! You won x2 " + bet.ToString() + " $";
                        int winning = bet * 2;

                        credit = credit + winning - bet;
                        infolbl.Text = "CREDIT: " + credit.ToString() + " $";
                    }
                    else
                    {
                        lblMsg.Text = "No luck, try again";
                        credit = credit - bet;
                        infolbl.Text = "CREDIT: " + credit.ToString() + " $";
                        if (credit < bet)
                        {
                            button1.Enabled = false;
                        }
                        if (credit == 0)
                        {

                        }
                    }
                }
                if (numericUpDown1.Value > 0 && numericUpDown1.Value >= cnt)
                {
                    label4.Text = "SPIN: " + cnt.ToString();
                    timer1.Enabled = true;
                }
            }
        }
        private void PlaySound(string soundFile)
        {
            player.URL = soundFile;
        }
        private void PlaySound2(string soundFile)
        {
            player2.URL = soundFile;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "Spin: " + cnt.ToString();
            button1.Enabled = false;
            PlaySound(@"C:\Demo\slotmachine.mp3");
            timer1.Enabled = true;
            timer1.Interval = 50;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Demo\slotmachineinsert.mp3");
            if (bet < credit)
            {
                button1.Enabled = true;
                bet += 5;
                betlbl.Text = "BET: " + bet.ToString() + " $";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Demo\slotmachineinsert.mp3");
            if (bet > 0) bet -= 5;
            if (bet <= credit) //button1.Enabled = true;
                betlbl.Text = "BET: " + bet.ToString() + " $";
            if (bet == 0)
            {
            }
        }

        private void Slots_FormClosing(object sender, FormClosingEventArgs e)
        {
            Money = credit;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
