using ShutgunGame.Classes;
using System.Diagnostics;

namespace ShutgunGame
{
    public partial class Form1 : Form
    {
        Game game = new Game();
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer player2 = new WMPLib.WindowsMediaPlayer();
        WMPLib.WindowsMediaPlayer maintheme = new WMPLib.WindowsMediaPlayer();
        private int ballXSpeed = 20;
        private int ballYSpeed = 0;
        private int ballX = 180;
        private int ballY = 248;
        private int computerballXSpeed = 20;
        private int computerballYSpeed = 0;
        private int computerballX = 1000;
        private int computerballY = 248;
        private int x = 0;
        private int cnt = 0;
        private int money = 1000;
        private int mouseX = 0;
        private int bet = 0;
        private int mouseY = 0;
        private string gameResult;
        private bool ranbefore = false;
        private int choice;
        private bool shouldDrawBallcomputer = false;
        private bool shouldDrawBall = false;
        private bool isMouseDown = false;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(OnPaint);
            this.Paint += new PaintEventHandler(OnPaint2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnShotGun.Visible = false;
            HideAll();
            //MainTheme(@"C:\Demo\maintheme.mp3");
            foreach (Control control in this.Controls)
            {
                if (control != btnStartGame && control != label1 && control != panel2 && control != lblExit && control != panel1)
                {
                    control.Visible = false;
                }
            }
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (shouldDrawBall)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.Black, new Rectangle(ballX, ballY, 10, 10));
            }
        }
        private void OnPaint2(object sender, PaintEventArgs e)
        {
            if (shouldDrawBallcomputer)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.Black, new Rectangle(computerballX, computerballY, 10, 10));
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (choice == 1)
            {
                if (ranbefore == false)
                {
                    if (game.AIchoice == 2 && ballX >= 1000)
                    {
                        //MessageBox.Show("player shot, computer reload. player won... Exiting....");
                        //ANIMATION KILL COMPUTER WIN GAME
                        timerHide.Start();

                        gunAnimationTimer.Stop();
                        ranbefore = true;
                    }
                }
                if (game.AIchoice == 3)
                {
                    //ANIMATION COMPUTER RICOCHET
                    if (ranbefore == false)
                    {
                        if (ballX >= 950 && ballX <= 1000)
                        {
                            ranbefore = true;
                            ballYSpeed = 80;
                            PlaySound(@"C:\Demo\ricochet.wav");
                        }
                    }
                    else if (ballX >= 1200)
                    {
                        ranbefore = false;
                        gunAnimationTimer.Stop();
                        timerHide.Start();
                    }
                }
                ballX += ballXSpeed;
                ballY += ballYSpeed;
            }
            if (game.AIchoice == 1)
            {
                if (choice == 1)
                {
                    if (Math.Abs(computerballX - ballX) <= 15)
                    {
                        //ANIMATION BOTH SHOT
                        PlaySound(@"C:\Demo\explosion.wav");
                        explosion.Location = new Point(computerballX, computerballY);
                        explosion.Show();
                        ResetComputerBall();
                        ResetPlayerBall();
                        shouldDrawBallcomputer = false;
                        shouldDrawBall = false;
                        gunAnimationTimer.Stop();
                        timerHide.Start();
                    }
                }
                if (choice == 2 && computerballX <= 80)
                {
                    PlaySound(@"C:\Demo\yoda.mp3");
                    //ANIMATION KILL PLAYER. LOSE GAME
                    timerHide.Start();
                    gunAnimationTimer.Stop();
                }
                if (choice == 3)
                {
                    if (ranbefore == false)
                    {
                        if (computerballX <= 180 && computerballX >= 130)
                        {
                            //PLAYER RICOCHET
                            ranbefore = true;
                            computerballYSpeed = 80;
                            PlaySound(@"C:\Demo\ricochet.wav");
                        }
                    }
                    else if (computerballX <= 80)
                    {
                        ranbefore = false;
                        gunAnimationTimer.Stop();
                        timerHide.Start();
                    }
                }
                computerballX -= computerballXSpeed;
                computerballY -= computerballYSpeed;
            }
            this.Invalidate();
        }
        private void UpdateUI()
        {
            label7.Text = "Money: " + money.ToString();
            label8.Text = "Bet: " + bet.ToString();
            lblRoundAmount.Text = "Round: " + ToRoman(game.Round);
            label2.Text = "Player Bullets: " + game.GetBullet();

            label3.Text = "Computer Bullets: " + game.GetComputer();
            //label6.Text = game.AIchoice.ToString();
            if (game.GetBullet() == "0")
            {
                btnShot.Enabled = false;
            }
            else
            {
                btnShot.Enabled = true;

            }
            if (game.GetBullet() == "3")
            {
                MainTheme(@"C:\Demo\intenseduel.mp3");
                btnShotGun.Visible = true;
            }
        }
        private void ResetPlayerBall()
        {
            ballX = 180;
            ballY = 248;
            ballYSpeed = 0;
        }
        private void ResetComputerBall()
        {
            computerballX = 1000;
            computerballY = 248;
            computerballYSpeed = 0;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            PlaySound(@"C:\Demo\gun.wav");
            ResetPlayerBall();
            playerGun.Show();
            shouldDrawBall = true;
            choice = 1;
            gameResult = game.PlayGame(choice);
            ComputerChoice();
            gunAnimationTimer.Start();
            UpdateUI();
            btnShot.Visible = false;
            btnReload.Visible = false;
            btnBlock.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            PlaySound(@"C:\Demo\reload.wav");
            choice = 2;
            gameResult = game.PlayGame(choice);
            playerReload.Show();
            ComputerChoice();
            UpdateUI();
            btnShot.Visible = false;
            btnReload.Visible = false;
            btnBlock.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
            PlaySound(@"C:\Demo\block.wav");
            choice = 3;
            gameResult = game.PlayGame(choice);
            playerShield.Show();
            ComputerChoice();
            UpdateUI();
            btnShot.Visible = false;
            btnReload.Visible = false;
            btnBlock.Visible = false;
        }
        private void ComputerChoice()
        {
            if (game.CanShotgun())
            {
                PlaySound(@"C:\Demo\shotgunreload.mp3");
                MainTheme(@"C:\Demo\intenseduel.mp3");
            }
            if (game.AIchoice == 1)
            {
                PlaySound2(@"C:\Demo\gun.wav");
                ResetComputerBall();
                shouldDrawBallcomputer = true;
                computerGun.Show();
                gunAnimationTimer.Start();
            }
            if (game.AIchoice == 2)
            {
                PlaySound2(@"C:\Demo\reload.wav");
                computerReload.Show();
                timerHide.Start();
            }
            if (game.AIchoice == 3)
            {
                computerShield.Show();
                timerHide.Start();
            }
        }
        private void PlaySound(string soundFile)
        {
            player.URL = soundFile;
        }
        private void MainTheme(string soundFile)
        {
            maintheme.URL = soundFile;
        }
        private void PlaySound2(string soundFile)
        {
            player2.URL = soundFile;
        }
        private void HideAll()
        {

            label9.Hide();
            playerGun.Hide();
            playerMuzzle.Hide();
            computerShield.Hide();
            playerReload.Hide();
            computerGun.Hide();
            computerReload.Hide();
            playerShield.Hide();
            explosion.Hide();
            label5.Hide();
            label6.Hide();
        }

        private async void timerHide_Tick(object sender, EventArgs e)
        {
            x++;
            if (x == 200) // x 10 ms
            {
                ResetComputerBall();
                ResetPlayerBall();
                shouldDrawBallcomputer = false;
                shouldDrawBall = false;
                x = 0;
                timerHide.Stop();
                HideAll();
                timerShowResult.Start();
                if (game.coinflipped)
                {
                    PlaySound(@"C:\Demo\coinflip.mp3");
                    await Task.Delay(3000);
                    PlaySound2(@"C:\Demo\shotgunfire.mp3");
                    await Task.Delay(3000);
                    label5.Text = gameResult;
                    label5.Show();
                    label5.Refresh();
                }
                else if (game.CanShotgun() && game.GetBullet() != "3")
                {
                    PlaySound2(@"C:\Demo\shotgunfire.mp3");
                }
                label5.Text = gameResult;
                label5.Show();
                label5.Refresh();
                if (game.WonGame) // WIN GAME
                {
                    btnBlock.Visible = false;
                    btnReload.Visible = false;
                    btnShot.Visible = false;
                    foreach (Control control in this.Controls)
                    {
                        if (control != btnStartGame && control != panel2 && control != lblExit && control != panel1)
                        {
                            label9.Visible = true;
                            control.Visible = false;
                        }
                    }
                    bet *= 2;
                    money = money + bet;
                    bet = 0;
                    btnStartGame.Text = "Continue";
                    btnStartGame.Visible = true;
                    PlaySound(@"C:\Demo\cash.mp3");
                    MainTheme(@"C:\Demo\winmusic.mp3");
                }
                if (game.LostGame) // LOST GAME
                {
                    btnBlock.Visible = false;
                    btnReload.Visible = false;
                    btnShot.Visible = false;
                    if (game.ShotGunReady)
                    {
                        PlaySound(@"C:\Demo\shotgunfire.mp3");
                    }
                    money = 1000;
                    bet = 0;
                    MainTheme(@"C:\Demo\gameover.mp3");
                    foreach (Control control in this.Controls)
                    {
                        if (control != btnStartGame && control != panel2 && control != lblExit && control != panel1 && control != label9)
                        {
                            label6.Visible = true;
                            control.Visible = false;
                        }
                    }
                    btnStartGame.Text = "Restart game";
                    btnStartGame.Visible = true;
                }
                if (game.LostRound == true)
                {
                    PlaySound(@"C:\Demo\lostround.mp3");

                }
                else
                {
                    PlaySound(@"C:\Demo\winround.mp3");
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void timerShowResult_Tick(object sender, EventArgs e)
        {
            cnt++;
            if (cnt == 100) // x20ms
            {
                btnBlock.Visible = true;
                btnReload.Visible = true;
                btnShot.Visible = true;
                timerShowResult.Stop();
                cnt = 0;
                label5.Hide();
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException(nameof(number), "insert value between 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new UnreachableException("Impossible state reached");
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Demo\startgame.mp3");
            MainTheme(@"C:\Demo\maintheme.mp3");
            game.NewGame();
            foreach (Control control in this.Controls)
            {
                if (control != label9)
                    control.Visible = true;
            }
            btnShotGun.Visible = false;
            ranbefore = false;
            timerHide.Stop();
            gunAnimationTimer.Stop();
            pictureBox1.Enabled = true;
            btnStartGame.Visible = false;
            label6.Visible = false;
            label9.Visible = false;
            UpdateUI();
            HideAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gunAnimationTimer.Enabled.ToString());
            MessageBox.Show(timerHide.Enabled.ToString());
        }

        private void btnShotGun_Click(object sender, EventArgs e)
        {
            gameResult = game.PlayGame(4);
            timerHide.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PlaySound(@"C:\Demo\cash.mp3");
            if (money > 0)
            {
                money -= 100;
                bet += 100;
            }
            else
            {
                pictureBox1.Enabled = false;
            }
            label8.Text = "Bet: " + bet.ToString() + " $";
            label7.Text = "Money: " + money.ToString() + " $";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Shop shop = new Shop(money);
            shop.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MainTheme(@"C:\Demo\saloon.mp3");
            Slots slots = new Slots(money);
            slots.Show();
            slots.FormClosed += (s, args) =>
            {
                MainTheme(@"C:\Demo\theme.wav");
                this.money = slots.Money;
                UpdateUI();
            };
        }
    }
}
