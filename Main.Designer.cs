namespace ShutgunGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gunAnimationTimer = new System.Windows.Forms.Timer(components);
            lblGameName = new Label();
            btnShot = new Button();
            btnReload = new Button();
            btnBlock = new Button();
            playerGun = new PictureBox();
            playerMuzzle = new PictureBox();
            computerShield = new PictureBox();
            lblPlayerBullet = new Label();
            playerReload = new PictureBox();
            lblComputerBullet = new Label();
            label4 = new Label();
            lblGameResult = new Label();
            computerGun = new PictureBox();
            computerReload = new PictureBox();
            playerShield = new PictureBox();
            timerHide = new System.Windows.Forms.Timer(components);
            explosion = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            timerShowResult = new System.Windows.Forms.Timer(components);
            lblExit = new Label();
            btnStartGame = new Button();
            lblRoundAmount = new Label();
            lblMoney = new Label();
            lblBet = new Label();
            lblWin = new Label();
            lblGameOver = new Label();
            btnShotgun = new Button();
            pbAddBet = new PictureBox();
            btnShop = new Button();
            btnSlots = new Button();
            WinOrLoose = new System.ComponentModel.BackgroundWorker();
            pbArmor = new PictureBox();
            pbShotgun = new PictureBox();
            pbDeathComputer = new PictureBox();
            pbDeathPlayer = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)playerGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerMuzzle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerShield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerShield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbAddBet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbArmor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbShotgun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeathComputer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDeathPlayer).BeginInit();
            SuspendLayout();
            // 
            // gunAnimationTimer
            // 
            gunAnimationTimer.Interval = 20;
            gunAnimationTimer.Tick += timer1_Tick;
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.BackColor = Color.Transparent;
            lblGameName.Font = new Font("Vanilla Whale", 72F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGameName.ForeColor = Color.Yellow;
            lblGameName.Location = new Point(374, 17);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(470, 115);
            lblGameName.TabIndex = 0;
            lblGameName.Text = "Shotgun Game";
            // 
            // btnShot
            // 
            btnShot.BackColor = SystemColors.ActiveCaptionText;
            btnShot.BackgroundImageLayout = ImageLayout.Stretch;
            btnShot.FlatStyle = FlatStyle.Flat;
            btnShot.Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShot.ForeColor = Color.FromArgb(192, 0, 0);
            btnShot.Location = new Point(441, 532);
            btnShot.Name = "btnShot";
            btnShot.Size = new Size(102, 45);
            btnShot.TabIndex = 1;
            btnShot.Text = "SHOOT";
            btnShot.UseVisualStyleBackColor = false;
            btnShot.Click += btnShot_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.Black;
            btnReload.BackgroundImageLayout = ImageLayout.Stretch;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.FromArgb(192, 0, 0);
            btnReload.Location = new Point(549, 531);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(131, 46);
            btnReload.TabIndex = 3;
            btnReload.Text = "RELOAD";
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // btnBlock
            // 
            btnBlock.BackColor = Color.Black;
            btnBlock.BackgroundImageLayout = ImageLayout.Stretch;
            btnBlock.FlatStyle = FlatStyle.Flat;
            btnBlock.Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBlock.ForeColor = Color.FromArgb(192, 0, 0);
            btnBlock.Location = new Point(686, 531);
            btnBlock.Name = "btnBlock";
            btnBlock.Size = new Size(101, 45);
            btnBlock.TabIndex = 4;
            btnBlock.Text = "BLOCK";
            btnBlock.UseVisualStyleBackColor = false;
            btnBlock.Click += btnBlock_Click;
            // 
            // playerGun
            // 
            playerGun.BackColor = Color.Transparent;
            playerGun.BackgroundImage = (Image)resources.GetObject("playerGun.BackgroundImage");
            playerGun.BackgroundImageLayout = ImageLayout.Stretch;
            playerGun.Location = new Point(27, 207);
            playerGun.Name = "playerGun";
            playerGun.Size = new Size(258, 189);
            playerGun.TabIndex = 5;
            playerGun.TabStop = false;
            // 
            // playerMuzzle
            // 
            playerMuzzle.BackColor = Color.Transparent;
            playerMuzzle.Image = (Image)resources.GetObject("playerMuzzle.Image");
            playerMuzzle.Location = new Point(250, 237);
            playerMuzzle.Name = "playerMuzzle";
            playerMuzzle.Size = new Size(83, 50);
            playerMuzzle.TabIndex = 6;
            playerMuzzle.TabStop = false;
            // 
            // computerShield
            // 
            computerShield.BackgroundImage = (Image)resources.GetObject("computerShield.BackgroundImage");
            computerShield.BackgroundImageLayout = ImageLayout.Stretch;
            computerShield.Location = new Point(986, 207);
            computerShield.Name = "computerShield";
            computerShield.Size = new Size(161, 160);
            computerShield.TabIndex = 7;
            computerShield.TabStop = false;
            // 
            // lblPlayerBullet
            // 
            lblPlayerBullet.AutoSize = true;
            lblPlayerBullet.BackColor = Color.Transparent;
            lblPlayerBullet.Font = new Font("Western Bang Bang", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlayerBullet.ForeColor = Color.Yellow;
            lblPlayerBullet.Location = new Point(75, 67);
            lblPlayerBullet.Name = "lblPlayerBullet";
            lblPlayerBullet.Size = new Size(168, 36);
            lblPlayerBullet.TabIndex = 8;
            lblPlayerBullet.Text = "Player Bullets:";
            // 
            // playerReload
            // 
            playerReload.BackColor = Color.Transparent;
            playerReload.Image = (Image)resources.GetObject("playerReload.Image");
            playerReload.Location = new Point(105, 227);
            playerReload.Name = "playerReload";
            playerReload.Size = new Size(84, 78);
            playerReload.TabIndex = 9;
            playerReload.TabStop = false;
            // 
            // lblComputerBullet
            // 
            lblComputerBullet.AutoSize = true;
            lblComputerBullet.BackColor = Color.Transparent;
            lblComputerBullet.Font = new Font("Western Bang Bang", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComputerBullet.ForeColor = Color.Yellow;
            lblComputerBullet.Location = new Point(926, 67);
            lblComputerBullet.Name = "lblComputerBullet";
            lblComputerBullet.Size = new Size(198, 36);
            lblComputerBullet.TabIndex = 10;
            lblComputerBullet.Text = "Computer Bullets:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Rio Grande", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(250, 431);
            label4.Name = "label4";
            label4.Size = new Size(0, 36);
            label4.TabIndex = 11;
            // 
            // lblGameResult
            // 
            lblGameResult.AutoSize = true;
            lblGameResult.BackColor = Color.Transparent;
            lblGameResult.Font = new Font("Vanilla Whale", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameResult.ForeColor = Color.Khaki;
            lblGameResult.Location = new Point(0, 0);
            lblGameResult.Name = "lblGameResult";
            lblGameResult.Size = new Size(0, 77);
            lblGameResult.TabIndex = 12;
            // 
            // computerGun
            // 
            computerGun.BackColor = Color.Transparent;
            computerGun.BackgroundImage = (Image)resources.GetObject("computerGun.BackgroundImage");
            computerGun.BackgroundImageLayout = ImageLayout.Stretch;
            computerGun.Location = new Point(963, 207);
            computerGun.Name = "computerGun";
            computerGun.Size = new Size(246, 189);
            computerGun.TabIndex = 14;
            computerGun.TabStop = false;
            // 
            // computerReload
            // 
            computerReload.BackColor = Color.Transparent;
            computerReload.Image = (Image)resources.GetObject("computerReload.Image");
            computerReload.Location = new Point(1036, 220);
            computerReload.Name = "computerReload";
            computerReload.Size = new Size(88, 86);
            computerReload.TabIndex = 15;
            computerReload.TabStop = false;
            // 
            // playerShield
            // 
            playerShield.BackgroundImage = (Image)resources.GetObject("playerShield.BackgroundImage");
            playerShield.BackgroundImageLayout = ImageLayout.Stretch;
            playerShield.Location = new Point(56, 207);
            playerShield.Name = "playerShield";
            playerShield.Size = new Size(161, 160);
            playerShield.TabIndex = 16;
            playerShield.TabStop = false;
            // 
            // timerHide
            // 
            timerHide.Interval = 10;
            timerHide.Tick += TimerShowResult;
            // 
            // explosion
            // 
            explosion.BackColor = Color.Transparent;
            explosion.Image = (Image)resources.GetObject("explosion.Image");
            explosion.Location = new Point(926, 520);
            explosion.Name = "explosion";
            explosion.Size = new Size(100, 50);
            explosion.TabIndex = 20;
            explosion.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(12, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1209, 12);
            panel1.TabIndex = 21;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(1205, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(16, 576);
            panel2.TabIndex = 22;
            // 
            // timerShowResult
            // 
            timerShowResult.Interval = 20;
            timerShowResult.Tick += TimerHideResult;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Black;
            lblExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExit.ForeColor = Color.Red;
            lblExit.Location = new Point(1195, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(23, 25);
            lblExit.TabIndex = 23;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.Transparent;
            btnStartGame.BackgroundImage = (Image)resources.GetObject("btnStartGame.BackgroundImage");
            btnStartGame.FlatStyle = FlatStyle.Flat;
            btnStartGame.Font = new Font("Western Bang Bang", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStartGame.ForeColor = Color.Yellow;
            btnStartGame.Location = new Point(460, 362);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(313, 115);
            btnStartGame.TabIndex = 24;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lblRoundAmount
            // 
            lblRoundAmount.AutoSize = true;
            lblRoundAmount.BackColor = Color.Transparent;
            lblRoundAmount.Font = new Font("Western Bang Bang", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoundAmount.ForeColor = Color.Yellow;
            lblRoundAmount.Location = new Point(27, 456);
            lblRoundAmount.Name = "lblRoundAmount";
            lblRoundAmount.Size = new Size(76, 30);
            lblRoundAmount.TabIndex = 25;
            lblRoundAmount.Text = "Round: ";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.BackColor = Color.Transparent;
            lblMoney.Font = new Font("Western Bang Bang", 24F, FontStyle.Bold);
            lblMoney.ForeColor = Color.Yellow;
            lblMoney.Location = new Point(25, 543);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(150, 34);
            lblMoney.TabIndex = 27;
            lblMoney.Text = "Money 1000$";
            // 
            // lblBet
            // 
            lblBet.AutoSize = true;
            lblBet.BackColor = Color.Transparent;
            lblBet.Font = new Font("Western Bang Bang", 24F, FontStyle.Bold);
            lblBet.ForeColor = Color.Yellow;
            lblBet.Location = new Point(27, 499);
            lblBet.Name = "lblBet";
            lblBet.Size = new Size(93, 34);
            lblBet.TabIndex = 29;
            lblBet.Text = "Bet 0 $";
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.BackColor = Color.Transparent;
            lblWin.Font = new Font("Vanilla Whale", 150F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWin.ForeColor = Color.Yellow;
            lblWin.Location = new Point(250, 119);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(727, 240);
            lblWin.TabIndex = 30;
            lblWin.Text = "YOU WIN";
            // 
            // lblGameOver
            // 
            lblGameOver.AutoSize = true;
            lblGameOver.BackColor = Color.Transparent;
            lblGameOver.Font = new Font("Vanilla Whale", 150F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameOver.ForeColor = Color.Red;
            lblGameOver.Location = new Point(146, 119);
            lblGameOver.Name = "lblGameOver";
            lblGameOver.Size = new Size(946, 240);
            lblGameOver.TabIndex = 31;
            lblGameOver.Text = "GAME OVER";
            // 
            // btnShotgun
            // 
            btnShotgun.BackColor = Color.Black;
            btnShotgun.BackgroundImage = (Image)resources.GetObject("btnShotgun.BackgroundImage");
            btnShotgun.BackgroundImageLayout = ImageLayout.Stretch;
            btnShotgun.FlatStyle = FlatStyle.Flat;
            btnShotgun.Font = new Font("Western Bang Bang", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShotgun.ForeColor = Color.Maroon;
            btnShotgun.Location = new Point(441, 480);
            btnShotgun.Name = "btnShotgun";
            btnShotgun.Size = new Size(346, 45);
            btnShotgun.TabIndex = 32;
            btnShotgun.Text = "SHOTGUN";
            btnShotgun.UseVisualStyleBackColor = false;
            btnShotgun.Click += btnShotGun_Click;
            // 
            // pbAddBet
            // 
            pbAddBet.BackColor = Color.Transparent;
            pbAddBet.BackgroundImage = (Image)resources.GetObject("pbAddBet.BackgroundImage");
            pbAddBet.BackgroundImageLayout = ImageLayout.Zoom;
            pbAddBet.Location = new Point(181, 545);
            pbAddBet.Name = "pbAddBet";
            pbAddBet.Size = new Size(36, 32);
            pbAddBet.TabIndex = 33;
            pbAddBet.TabStop = false;
            pbAddBet.Click += PbAddBet;
            // 
            // btnShop
            // 
            btnShop.BackColor = Color.Transparent;
            btnShop.BackgroundImageLayout = ImageLayout.Stretch;
            btnShop.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            btnShop.FlatAppearance.MouseOverBackColor = Color.White;
            btnShop.FlatStyle = FlatStyle.Flat;
            btnShop.Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShop.ForeColor = Color.Yellow;
            btnShop.Location = new Point(1098, 541);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(101, 45);
            btnShop.TabIndex = 34;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = false;
            btnShop.Click += btnShop_Click;
            // 
            // btnSlots
            // 
            btnSlots.BackColor = Color.Transparent;
            btnSlots.BackgroundImageLayout = ImageLayout.Stretch;
            btnSlots.FlatAppearance.BorderColor = Color.Yellow;
            btnSlots.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnSlots.FlatAppearance.MouseOverBackColor = Color.White;
            btnSlots.FlatStyle = FlatStyle.Flat;
            btnSlots.Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSlots.ForeColor = Color.Yellow;
            btnSlots.Location = new Point(991, 541);
            btnSlots.Name = "btnSlots";
            btnSlots.Size = new Size(101, 45);
            btnSlots.TabIndex = 35;
            btnSlots.Text = "Slots";
            btnSlots.UseVisualStyleBackColor = false;
            btnSlots.Click += btnSlots_Click;
            // 
            // WinOrLoose
            // 
            WinOrLoose.WorkerSupportsCancellation = true;
            WinOrLoose.DoWork += backgroundWorker1_DoWork;
            // 
            // pbArmor
            // 
            pbArmor.BackColor = Color.FromArgb(255, 255, 128);
            pbArmor.BackgroundImage = (Image)resources.GetObject("pbArmor.BackgroundImage");
            pbArmor.BackgroundImageLayout = ImageLayout.Stretch;
            pbArmor.Location = new Point(27, 402);
            pbArmor.Name = "pbArmor";
            pbArmor.Size = new Size(54, 50);
            pbArmor.TabIndex = 36;
            pbArmor.TabStop = false;
            // 
            // pbShotgun
            // 
            pbShotgun.BackColor = Color.FromArgb(255, 255, 128);
            pbShotgun.BackgroundImage = (Image)resources.GetObject("pbShotgun.BackgroundImage");
            pbShotgun.BackgroundImageLayout = ImageLayout.Stretch;
            pbShotgun.Location = new Point(87, 402);
            pbShotgun.Name = "pbShotgun";
            pbShotgun.Size = new Size(74, 50);
            pbShotgun.TabIndex = 37;
            pbShotgun.TabStop = false;
            // 
            // pbDeathComputer
            // 
            pbDeathComputer.BackColor = Color.Transparent;
            pbDeathComputer.Image = (Image)resources.GetObject("pbDeathComputer.Image");
            pbDeathComputer.Location = new Point(963, 175);
            pbDeathComputer.Name = "pbDeathComputer";
            pbDeathComputer.Size = new Size(213, 143);
            pbDeathComputer.TabIndex = 38;
            pbDeathComputer.TabStop = false;
            // 
            // pbDeathPlayer
            // 
            pbDeathPlayer.BackColor = Color.Transparent;
            pbDeathPlayer.Image = (Image)resources.GetObject("pbDeathPlayer.Image");
            pbDeathPlayer.Location = new Point(35, 172);
            pbDeathPlayer.Name = "pbDeathPlayer";
            pbDeathPlayer.Size = new Size(213, 143);
            pbDeathPlayer.TabIndex = 39;
            pbDeathPlayer.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1221, 588);
            Controls.Add(pbDeathPlayer);
            Controls.Add(pbDeathComputer);
            Controls.Add(pbShotgun);
            Controls.Add(pbArmor);
            Controls.Add(btnSlots);
            Controls.Add(btnShop);
            Controls.Add(pbAddBet);
            Controls.Add(btnShotgun);
            Controls.Add(lblGameOver);
            Controls.Add(lblWin);
            Controls.Add(lblBet);
            Controls.Add(lblMoney);
            Controls.Add(lblRoundAmount);
            Controls.Add(btnStartGame);
            Controls.Add(lblExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(explosion);
            Controls.Add(playerShield);
            Controls.Add(computerReload);
            Controls.Add(computerGun);
            Controls.Add(lblGameResult);
            Controls.Add(label4);
            Controls.Add(lblComputerBullet);
            Controls.Add(playerReload);
            Controls.Add(lblPlayerBullet);
            Controls.Add(computerShield);
            Controls.Add(playerMuzzle);
            Controls.Add(playerGun);
            Controls.Add(btnBlock);
            Controls.Add(btnReload);
            Controls.Add(btnShot);
            Controls.Add(lblGameName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Shotgun Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)playerGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerMuzzle).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerShield).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerGun).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerReload).EndInit();
            ((System.ComponentModel.ISupportInitialize)playerShield).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbAddBet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbArmor).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbShotgun).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeathComputer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDeathPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gunAnimationTimer;
        private Label lblGameName;
        private Button btnShot;
        private Button btnReload;
        private Button btnBlock;
        private PictureBox playerGun;
        private PictureBox playerMuzzle;
        private PictureBox computerShield;
        private Label lblPlayerBullet;
        private PictureBox playerReload;
        private Label lblComputerBullet;
        private Label label4;
        private Label lblGameResult;
        private PictureBox computerGun;
        private PictureBox computerReload;
        private PictureBox playerShield;
        private System.Windows.Forms.Timer timerHide;
        private PictureBox explosion;
        private Panel panel1;
        private Panel panel2;
        private System.Windows.Forms.Timer timerShowResult;
        private Label lblExit;
        private Button btnStartGame;
        private Label lblRoundAmount;
        private Label lblMoney;
        private Label lblBet;
        private Label lblWin;
        private Label lblGameOver;
        private Button btnShotgun;
        private PictureBox pbAddBet;
        private Button btnShop;
        private Button btnSlots;
        private System.ComponentModel.BackgroundWorker WinOrLoose;
        private PictureBox pbArmor;
        private PictureBox pbShotgun;
        private PictureBox pbDeathComputer;
        private PictureBox pbDeathPlayer;
    }
}
