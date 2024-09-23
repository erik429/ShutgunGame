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
            label1 = new Label();
            btnShot = new Button();
            btnReload = new Button();
            btnBlock = new Button();
            playerGun = new PictureBox();
            playerMuzzle = new PictureBox();
            computerShield = new PictureBox();
            label2 = new Label();
            playerReload = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            btnShotGun = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)playerGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerMuzzle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerShield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerGun).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerReload).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playerShield).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gunAnimationTimer
            // 
            gunAnimationTimer.Interval = 5;
            gunAnimationTimer.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Vanilla Whale", 72F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(374, 17);
            label1.Name = "label1";
            label1.Size = new Size(470, 115);
            label1.TabIndex = 0;
            label1.Text = "Shotgun Game";
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
            btnShot.Click += button1_Click_1;
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
            btnReload.Click += button2_Click;
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
            btnBlock.Click += button3_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Western Bang Bang", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(75, 67);
            label2.Name = "label2";
            label2.Size = new Size(168, 36);
            label2.TabIndex = 8;
            label2.Text = "Player Bullets:";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Western Bang Bang", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(926, 67);
            label3.Name = "label3";
            label3.Size = new Size(198, 36);
            label3.TabIndex = 10;
            label3.Text = "Computer Bullets:";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Vanilla Whale", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Khaki;
            label5.Location = new Point(150, 228);
            label5.Name = "label5";
            label5.Size = new Size(0, 77);
            label5.TabIndex = 12;
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
            computerReload.Location = new Point(1036, 237);
            computerReload.Name = "computerReload";
            computerReload.Size = new Size(88, 86);
            computerReload.TabIndex = 15;
            computerReload.TabStop = false;
            // 
            // playerShield
            // 
            playerShield.BackgroundImage = (Image)resources.GetObject("playerShield.BackgroundImage");
            playerShield.BackgroundImageLayout = ImageLayout.Stretch;
            playerShield.Location = new Point(68, 207);
            playerShield.Name = "playerShield";
            playerShield.Size = new Size(161, 160);
            playerShield.TabIndex = 16;
            playerShield.TabStop = false;
            // 
            // timerHide
            // 
            timerHide.Interval = 10;
            timerHide.Tick += timerHide_Tick;
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
            timerShowResult.Tick += timerShowResult_Tick;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Western Bang Bang", 24F, FontStyle.Bold);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(25, 543);
            label7.Name = "label7";
            label7.Size = new Size(150, 34);
            label7.TabIndex = 27;
            label7.Text = "Money 1000$";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Western Bang Bang", 24F, FontStyle.Bold);
            label8.ForeColor = Color.Yellow;
            label8.Location = new Point(27, 499);
            label8.Name = "label8";
            label8.Size = new Size(93, 34);
            label8.TabIndex = 29;
            label8.Text = "Bet 0 $";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Vanilla Whale", 150F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Yellow;
            label9.Location = new Point(250, 119);
            label9.Name = "label9";
            label9.Size = new Size(727, 240);
            label9.TabIndex = 30;
            label9.Text = "YOU WIN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Vanilla Whale", 150F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(156, 103);
            label6.Name = "label6";
            label6.Size = new Size(946, 240);
            label6.TabIndex = 31;
            label6.Text = "GAME OVER";
            // 
            // btnShotGun
            // 
            btnShotGun.BackColor = Color.Black;
            btnShotGun.BackgroundImage = (Image)resources.GetObject("btnShotGun.BackgroundImage");
            btnShotGun.BackgroundImageLayout = ImageLayout.Stretch;
            btnShotGun.FlatStyle = FlatStyle.Flat;
            btnShotGun.Font = new Font("Western Bang Bang", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShotGun.ForeColor = Color.Maroon;
            btnShotGun.Location = new Point(441, 480);
            btnShotGun.Name = "btnShotGun";
            btnShotGun.Size = new Size(346, 45);
            btnShotGun.TabIndex = 32;
            btnShotGun.Text = "SHOTGUN";
            btnShotGun.UseVisualStyleBackColor = false;
            btnShotGun.Click += btnShotGun_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(181, 545);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 32);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.MouseOverBackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(1098, 541);
            button1.Name = "button1";
            button1.Size = new Size(101, 45);
            button1.TabIndex = 34;
            button1.Text = "Shop";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderColor = Color.Yellow;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            button2.FlatAppearance.MouseOverBackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Yellow;
            button2.Location = new Point(991, 541);
            button2.Name = "button2";
            button2.Size = new Size(101, 45);
            button2.TabIndex = 35;
            button2.Text = "Slots";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1221, 588);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btnShotGun);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblRoundAmount);
            Controls.Add(btnStartGame);
            Controls.Add(lblExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(explosion);
            Controls.Add(playerShield);
            Controls.Add(computerReload);
            Controls.Add(computerGun);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(playerReload);
            Controls.Add(label2);
            Controls.Add(computerShield);
            Controls.Add(playerMuzzle);
            Controls.Add(playerGun);
            Controls.Add(btnBlock);
            Controls.Add(btnReload);
            Controls.Add(btnShot);
            Controls.Add(label1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer gunAnimationTimer;
        private Label label1;
        private Button btnShot;
        private Button btnReload;
        private Button btnBlock;
        private PictureBox playerGun;
        private PictureBox playerMuzzle;
        private PictureBox computerShield;
        private Label label2;
        private PictureBox playerReload;
        private Label label3;
        private Label label4;
        private Label label5;
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
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label6;
        private Button btnShotGun;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}
