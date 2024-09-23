using Microsoft.VisualBasic;

namespace ShutgunGame.Classes
{
    public partial class Slots : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player3 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player4 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player5 = new WMPLib.WindowsMediaPlayer();
        int m;
        string file_slots1 = "C:\\Demo\\slots1.png";
        string file_slots2 = "C:\\Demo\\slots2.png";
        string file_slots3 = "C:\\Demo\\slots3.png";
        string file_slots4 = "C:\\Demo\\slots4.png";
        int a;
        int b;
        int c;
        int fast;
        int d;
        int cnt = 0;
        int credit = 0;
        int bet = 0;
        bool soundPlayedA = false;
        bool soundPlayedB = false;
        bool soundPlayedC = false;
        bool soundPlayedD = false;
        public int Money { get; set; }
        public Slots(int money)
        {
            credit = money;
            InitializeComponent();
        }
        private void Slots_Load(object sender, EventArgs e)
        {
            fast = 4;
            //PlaySound2(@"C:\Demo\saloon.mp3");
            if (bet <= 0)
            {
                button1.Enabled = false;
            }
            lblnoWin.Visible = false;
            lbljackpot.Visible = false;
            lblwinAmount.Visible = false;
            lbljackpot.Text = "";
            lblwinAmount.Text = "";
            infolbl.Text = "Money: " + credit + " $";
            betlbl.Text = "Bet: " + bet + " $";
        }
        private async void timer1_Tick(object sender, EventArgs e)
        {
            m += fast;
            if (m < 75 && m >= 50)
            {
                switch (a)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile(file_slots1);
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile(file_slots2);
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile(file_slots3);
                        break;
                    case 4:
                        pictureBox1.Image = Image.FromFile(file_slots4);
                        break;
                }
                if (!soundPlayedA)
                {
                    PlaySound2(@"C:\Demo\slam.mp3");
                    soundPlayedA = true; // Mark this sound as played
                }
            }
            else if (m < 100 && m >= 75) // Changed to else if to ensure the order
            {
                switch (b)
                {
                    case 1:
                        pictureBox2.Image = Image.FromFile(file_slots1);
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile(file_slots2);
                        break;
                    case 3:
                        pictureBox2.Image = Image.FromFile(file_slots3);
                        break;
                    case 4:
                        pictureBox2.Image = Image.FromFile(file_slots4);
                        break;
                }
                if (!soundPlayedB)
                {
                    PlaySound3(@"C:\Demo\slam.mp3");
                    soundPlayedB = true;
                }
            }
            else if (m < 150 && m >= 100) // Same here
            {
                switch (c)
                {
                    case 1:
                        pictureBox3.Image = Image.FromFile(file_slots1);
                        break;
                    case 2:
                        pictureBox3.Image = Image.FromFile(file_slots2);
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile(file_slots3);
                        break;
                    case 4:
                        pictureBox3.Image = Image.FromFile(file_slots4);
                        break;
                }
                if (!soundPlayedC)
                {
                    PlaySound4(@"C:\Demo\slam.mp3");
                    soundPlayedC = true;
                }
            }
            else if (m < 175 && m >= 150) // And here
            {
                switch (d)
                {
                    case 1:
                        pictureBox4.Image = Image.FromFile(file_slots1);
                        break;
                    case 2:
                        pictureBox4.Image = Image.FromFile(file_slots2);
                        break;
                    case 3:
                        pictureBox4.Image = Image.FromFile(file_slots3);
                        break;
                    case 4:
                        pictureBox4.Image = Image.FromFile(file_slots4);
                        break;
                }
                if (!soundPlayedD)
                {
                    PlaySound5(@"C:\Demo\slam.mp3");
                    soundPlayedD = true;
                }
            }
            else if (soundPlayedD == true) // This block handles when all images have been updated
            {
                cnt++;
                button1.Text = "Spin";
                button1.Enabled = true;

                // Reset the timer and sounds
                timer1.Enabled = false;
                m = 0;
                soundPlayedA = false;
                soundPlayedB = false;
                soundPlayedC = false;
                soundPlayedD = false;

                // Evaluate winnings here
                if (a == b && a == c && a == d)
                {
                    int winning = bet * 55;
                    PlaySound(@"C:\Demo\jackpot.mp3");
                    lblwinAmount.Text = "You win " + winning.ToString() + "$";
                    lbljackpot.Text = "JACKPOT";
                    ShowFonts();
                    credit += winning - bet;
                    infolbl.Text = "Money " + credit.ToString() + "$";
                }
                else if ((a == b && a == c) || (d == c && d == b))
                {
                    int winning = bet * 3;
                    PlaySound(@"C:\Demo\cash.mp3");
                    lblwinAmount.Text = "You win " + winning.ToString() + "$";
                    lbljackpot.Text = "3-Pair";
                    ShowFonts();
                    credit += winning - bet;
                    infolbl.Text = "Money " + credit.ToString() + "$";
                }
                else if (a == b || c == d)
                {
                    
                    int winning = bet * 2;
                    PlaySound(@"C:\Demo\cash.mp3");
                    lblwinAmount.Text = "You win " + winning.ToString() + "$";
                    lbljackpot.Text = "2-Pair";
                    ShowFonts();
                    credit += winning - bet;
                    infolbl.Text = "Money " + credit.ToString() + "$";
                }
                else
                {
                    lblnoWin.Visible = true;
                    lblnoWin.Text = "No luck, try again";
                    credit -= bet;
                    infolbl.Text = "Money " + credit.ToString() + "$";
                    if (credit < bet)
                    {
                        button1.Enabled = false;
                    }
                }

                // Prepare for the next spin
                if (numericUpDown1.Value > 0 && numericUpDown1.Value >= cnt)
                {
                    CalculateWin();
                    SpinAnimation();
                    Reset();
                    label4.Text = "Spin " + cnt.ToString();
                    timer1.Enabled = true;
                }
            }
        }
        private void SpinAnimation()
        {
            pictureBox1.Image = Image.FromFile("C:\\Demo\\projekt\\SPIN2_edit.gif");
            pictureBox2.Image = Image.FromFile("C:\\Demo\\projekt\\SPIN1_edit.gif");
            pictureBox3.Image = Image.FromFile("C:\\Demo\\projekt\\SPIN2_edit.gif");
            pictureBox4.Image = Image.FromFile("C:\\Demo\\projekt\\SPIN1_edit.gif");
        }
        private void CalculateWin()
        {
            a = (int)(Conversion.Int(1 + VBMath.Rnd() * 4));
            b = (int)(Conversion.Int(1 + VBMath.Rnd() * 4));
            c = (int)(Conversion.Int(1 + VBMath.Rnd() * 4));
            d = (int)(Conversion.Int(1 + VBMath.Rnd() * 4));
        }
        private void Reset()
        {
            lblnoWin.Visible = false;
            lblwinAmount.Visible = false;
            lbljackpot.Visible = false;
            soundPlayedA = false;
            soundPlayedB = false;
            soundPlayedC = false;
            soundPlayedD = false;
        }
        private void ShowFonts()
        {
            lbljackpot.Visible = true;
            lblwinAmount.Visible = true;
        }
        private void PlaySound(string soundFile)
        {
            player.URL = soundFile;
        }
        private void PlaySound2(string soundFile)
        {
            player2.URL = soundFile;
        }
        private void PlaySound3(string soundFile)
        {
            player3.URL = soundFile;
        }
        private void PlaySound4(string soundFile)
        {
            player4.URL = soundFile;
        }
        private void PlaySound5(string soundFile)
        {
            player5.URL = soundFile;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SpinAnimation();
            CalculateWin();
            Reset();
            label4.Text = "Spin: " + cnt.ToString();
            button1.Enabled = false;
            button1.Text = "Good luck...";
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
                betlbl.Text = "Bet " + bet.ToString() + "$";
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fast = 20;
            }
            else
            {
                fast = 4;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            aboutslot aboutslot = new aboutslot();
            aboutslot.Show();
        }
    }
}
