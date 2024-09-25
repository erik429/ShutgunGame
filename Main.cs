using ShutgunGame.Classes;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using static System.Reflection.Metadata.BlobBuilder;

namespace ShutgunGame
{
    public partial class Form1 : Form
    {
        private Inventory playerInventory;
        private Game game;
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
        private int bet = 0;
        public int money = 100000;

        private int mouseX = 0;
        private int mouseY = 0;
        private string gameResult;
        private bool ranbefore = false;
        private int choice;
        private bool shouldDrawBallcomputer = false;
        private bool shouldDrawBall = false;
        private bool isMouseDown = false;
        public Form1()
        {
            game = new Game();
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += new PaintEventHandler(OnPaint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnShotgun.Visible = false;
            HideAll();
            //MainTheme(@"C:\Demo\maintheme.mp3");
            foreach (Control control in this.Controls)
            {
                if (control != btnStartGame && control != lblGameName && control != panel2 && control != lblExit && control != panel1)
                {
                    control.Visible = false;
                }
            }
        }
        private void OnPaint(object sender, PaintEventArgs e) //DRAW BULLET 
        {
            if (shouldDrawBall)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.Black, new Rectangle(ballX, ballY, 10, 10));
            }
            if (shouldDrawBallcomputer)
            {
                Graphics g = e.Graphics;
                g.FillRectangle(Brushes.Black, new Rectangle(computerballX, computerballY, 10, 10));
            }
        }
        private void timer1_Tick(object sender, EventArgs e) //BULLET AND PICTURES ANIMATION
        {
            if (choice == 1)
            {
                if (ranbefore == false)
                {
                    if (game.AIchoice == 2 && ballX >= 1050)
                    {
                        PlaySound(@"C:\Demo\bullethit.mp3");
                        pbDeathComputer.Show();
                        //ANIMATION KILL COMPUTER WIN GAME
                        timerHide.Start();
                        ResetPlayerBall();
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
                        gunAnimationTimer.Stop();
                        timerHide.Start();
                    }
                }
                if (choice == 2 && computerballX <= 150 && computerballX >= 80)
                {
                    //ANIMATION KILL PLAYER. LOSE GAME
                    if (ranbefore == false)
                    {
                        ranbefore = true;
                        if (!game.CheckArmor())
                        {
                            PlaySound(@"C:\Demo\bullethit.mp3");
                            pbDeathPlayer.Show();
                            ResetComputerBall();
                            timerHide.Start();
                            gunAnimationTimer.Stop();
                        }
                        else
                        {
                            game.RemoveArmor();
                            PlaySound(@"C:\Demo\ricochet.wav");
                            computerballYSpeed = 80;
                        }

                    }

                    if (computerballX <= 80)
                    {
                        timerHide.Start();
                        gunAnimationTimer.Stop();
                        ranbefore = false;
                    }
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
            this.Refresh();
        }
        private void UpdateUI() // UPDATE UI
        {
            if (game.CheckArmor())
            {
                pbArmor.Show();
            }
            if (game.CheckShotgun())
            {
                pbShotgun.Show();
            }
            lblMoney.Text = "Money: " + money.ToString();
            lblBet.Text = "Bet: " + bet.ToString();
            lblRoundAmount.Text = "Round: " + ToRoman(game.Round);
            lblPlayerBullet.Text = "Player Bullets: " + game.GetBullet();

            lblComputerBullet.Text = "Computer Bullets: " + game.GetComputer();
            if (game.GetBullet() == "0")
            {
                btnShot.Enabled = false;
            }
            else
            {
                btnShot.Enabled = true;

            }
        }
        private void ResetPlayerBall()
        {
            shouldDrawBall = false;
            ballX = 180;
            ballY = 248;
            ballYSpeed = 0;
        }
        private void ResetComputerBall()
        {
            shouldDrawBallcomputer = false;
            computerballX = 1000;
            computerballY = 248;
            computerballYSpeed = 0;
        }
        private void DisableUserControl()
        {
            btnShot.Visible = false;
            btnReload.Visible = false;
            btnBlock.Visible = false;
        }
        private void ComputerChoice()
        {
            if (game.CanShotgun())
            {
                PlaySound(@"C:\Demo\shotgunreload.mp3");
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
            if (!game.CheckArmor())
            {
                pbArmor.Hide();
            }
            if (!game.CheckShotgun())
            {
                pbShotgun.Hide();
            }
            pbDeathComputer.Hide();
            pbDeathPlayer.Hide();
            lblWin.Hide();
            playerGun.Hide();
            playerMuzzle.Hide();
            computerShield.Hide();
            playerReload.Hide();
            computerGun.Hide();
            computerReload.Hide();
            playerShield.Hide();
            explosion.Hide();
            lblGameResult.Hide();
            lblGameOver.Hide();
        }

        private void TimerShowResult(object sender, EventArgs e) //SHOW GAME RESULT AND RESET
        {
            x++;
            if (x == 100) // x 10 ms
            {
                x = 0;
                ResetComputerBall();
                ResetPlayerBall();
                HideAll();
                timerShowResult.Start();
                if (!game.coinflipped)
                {
                    ShowGameResult();
                }
                if (!WinOrLoose.IsBusy)
                {
                    WinOrLoose.RunWorkerAsync();
                }
                timerHide.Stop();
            }
        }
        private void ShowGameResult() //SHOW GAME RESULT AND CENTER IT
        {
            lblGameResult.Text = gameResult;
            lblGameResult.Left = (this.ClientSize.Width - lblGameResult.Width) / 2;
            lblGameResult.Top = (this.ClientSize.Height - lblGameResult.Height) / 2;
            lblGameResult.Refresh();
            lblGameResult.Show();

        }
        private void panel1_MouseUp(object sender, MouseEventArgs e) //MOVE FORM
        {
            isMouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) //MOVE FORM
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) //MOVE FORM
        {
            if (isMouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void TimerHideResult(object sender, EventArgs e) //HIDES GAME RESULT AFTER 2sec
        {
            cnt++;
            if (cnt == 100) // x20ms
            {
                cnt = 0;
                if (game.GetBullet() == "3" && btnStartGame.Visible == false)
                {
                    MainTheme(@"C:\Demo\intenseduel.mp3");
                    btnShotgun.Visible = true;
                    DisableUserControl();
                }
                else if (btnStartGame.Visible == false)
                {
                    btnSlots.Enabled = true;
                    btnShop.Enabled = true;
                    btnBlock.Visible = true;
                    btnReload.Visible = true;
                    btnShot.Visible = true;
                }
                timerShowResult.Stop();
                lblGameResult.Hide();
            }
        }

        private void lblExit_Click(object sender, EventArgs e) //EXIT APP
        {
            this.Close();
        }
        public static string ToRoman(int number) //CONVERT NUMBER TO ROMAN
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException(nameof(number));
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
        private void btnStartGame_Click(object sender, EventArgs e) //BTN START GAME
        {
            PlaySound(@"C:\Demo\startgame.mp3");
            MainTheme(@"C:\Demo\maintheme.mp3");
            game.NewGame();
            foreach (Control control in this.Controls)
            {
                if (control != lblWin)
                    control.Visible = true;
            }
            btnShotgun.Visible = false;
            ranbefore = false;
            timerHide.Stop();
            gunAnimationTimer.Stop();
            pbAddBet.Enabled = true;
            btnShop.Enabled = true;
            btnSlots.Enabled = true;
            btnStartGame.Visible = false;
            lblGameOver.Visible = false;
            lblWin.Visible = false;
            UpdateUI();
            HideAll();
        }
        private void btnShotGun_Click(object sender, EventArgs e) //CLICK SHOTGUN
        {
            gameResult = game.PlayGame(4);
            timerHide.Start();
        }

        private void PbAddBet(object sender, EventArgs e)
        {
            if (money > 249)
            {
                money -= 250;
                bet += 250;
                PlaySound(@"C:\Demo\cash.mp3");
            }
            else if (money < 249 && money > 0)
            {
                bet += money;
                money -= money;
                PlaySound(@"C:\Demo\cash.mp3");
            }
            else
            {
                pbAddBet.Enabled = false;
            }
            lblBet.Text = "Bet: " + bet.ToString() + " $";
            lblMoney.Text = "Money: " + money.ToString() + " $";
        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e) //WIN GAME THREAD.
        {
            if (game.coinflipped)
            {
                PlaySound(@"C:\Demo\coinflip.mp3");
                Thread.Sleep(3000);
                PlaySound2(@"C:\Demo\shotgunfire.mp3");
                this.Invoke(new MethodInvoker(() =>
                {
                    ShowGameResult();
                    Thread.Sleep(3000);
                }));
            }


            this.Invoke(new MethodInvoker(() =>
            {
                if (game.WonGame == true) // WIN GAME
                {
                    if (game.GetBullet() == "3")
                    {
                        PlaySound2(@"C:\Demo\shotgunfire.mp3");
                        Thread.Sleep(1000);
                    }
                    DisableUserControl();
                    foreach (Control control in this.Controls)
                    {
                        if (control != btnStartGame && control != panel2 && control != lblExit && control != panel1)
                        {
                            lblWin.Visible = true;
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
                if (game.LostGame == true) // LOST GAME
                {
                    ShowGameResult();
                    if (game.CanShotgun())
                    {
                        Thread.Sleep(2000);
                    }
                    if (game.ShotGunReady)
                    {
                        PlaySound(@"C:\Demo\shotgunfire.mp3");
                    }
                    money = 1000;
                    bet = 0;
                    MainTheme(@"C:\Demo\gameover.mp3");
                    foreach (Control control in this.Controls)
                    {
                        if (control != btnStartGame && control != panel2 && control != lblExit && control != panel1 && control != lblGameOver)
                        {
                            lblGameOver.Visible = true;
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
            }));
        }

        private void btnShot_Click(object sender, EventArgs e) //BTN SHOOT
        {
            btnSlots.Enabled = false;
            btnShop.Enabled = false;
            pbAddBet.Enabled = false;
            PlaySound(@"C:\Demo\gun.wav");
            ResetPlayerBall();
            playerGun.Show();
            shouldDrawBall = true;
            choice = 1;
            gameResult = game.PlayGame(choice);
            ComputerChoice();
            gunAnimationTimer.Start();
            UpdateUI();
            DisableUserControl();
        }

        private void btnReload_Click(object sender, EventArgs e) // BTN RELOAD
        {
            btnSlots.Enabled = false;
            btnShop.Enabled = false;
            pbAddBet.Enabled = false;
            PlaySound(@"C:\Demo\reload.wav");
            choice = 2;
            gameResult = game.PlayGame(choice);
            playerReload.Show();
            ComputerChoice();
            UpdateUI();
            DisableUserControl();
        }

        private void btnBlock_Click(object sender, EventArgs e) //BTN BLOCK
        {
            btnSlots.Enabled = false;
            btnShop.Enabled = false;
            pbAddBet.Enabled = false;
            PlaySound(@"C:\Demo\block.wav");
            choice = 3;
            gameResult = game.PlayGame(choice);
            playerShield.Show();
            ComputerChoice();
            UpdateUI();
            DisableUserControl();
        }

        private void btnSlots_Click(object sender, EventArgs e) //OPEN SLOT FORM
        {
            //MainTheme(@"C:\Demo\saloon.mp3");
            Slots slots = new Slots(money);
            slots.Show();
            slots.FormClosed += (s, args) =>
            {
                this.money = slots.Money;
                UpdateUI();
            };
        }

        private void btnShop_Click(object sender, EventArgs e) //OPEN SHOP FORM
        {
            Shop shop = new Shop(game.inventory, ref money);
            shop.Show();
            shop.FormClosed += (s, args) =>
            {
                this.money = shop.money;
                UpdateUI();
            };
        }
    }
}
