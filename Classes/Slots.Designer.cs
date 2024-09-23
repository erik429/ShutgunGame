namespace ShutgunGame.Classes
{
    partial class Slots
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slots));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbljackpot = new Label();
            infolbl = new Label();
            betlbl = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            label3 = new Label();
            checkBox1 = new CheckBox();
            label5 = new Label();
            lblnoWin = new Label();
            lblwinAmount = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(22, 101);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 183);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(154, 101);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 183);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(283, 101);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 183);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.Cornsilk;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Vanilla Whale", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Khaki;
            button1.Location = new Point(22, 321);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(477, 97);
            button1.TabIndex = 3;
            button1.Text = "Spin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Western Bang Bang", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Cornsilk;
            button3.Location = new Point(22, 426);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(38, 41);
            button3.TabIndex = 5;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Western Bang Bang", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Cornsilk;
            button4.Location = new Point(61, 426);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(38, 41);
            button4.TabIndex = 6;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbljackpot
            // 
            lbljackpot.AutoSize = true;
            lbljackpot.BackColor = Color.Black;
            lbljackpot.Font = new Font("Woodcut", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbljackpot.ForeColor = Color.Coral;
            lbljackpot.Location = new Point(122, 123);
            lbljackpot.Name = "lbljackpot";
            lbljackpot.Size = new Size(279, 50);
            lbljackpot.TabIndex = 7;
            lbljackpot.Text = "3-Pair";
            lbljackpot.Click += lblMsg_Click;
            // 
            // infolbl
            // 
            infolbl.BackColor = Color.Transparent;
            infolbl.Font = new Font("Woodcut", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infolbl.ForeColor = Color.Khaki;
            infolbl.Location = new Point(16, 534);
            infolbl.Name = "infolbl";
            infolbl.Size = new Size(299, 28);
            infolbl.TabIndex = 8;
            infolbl.Text = "Money 3000$";
            // 
            // betlbl
            // 
            betlbl.BackColor = Color.Transparent;
            betlbl.Font = new Font("Woodcut", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            betlbl.ForeColor = Color.Khaki;
            betlbl.Location = new Point(12, 493);
            betlbl.Name = "betlbl";
            betlbl.Size = new Size(283, 39);
            betlbl.TabIndex = 9;
            betlbl.Text = "Bet 30$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(496, -1);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.White;
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.ForeColor = SystemColors.ActiveCaptionText;
            numericUpDown1.Location = new Point(420, 437);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 25);
            numericUpDown1.TabIndex = 11;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Western Bang Bang", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Khaki;
            label2.Location = new Point(306, 434);
            label2.Name = "label2";
            label2.Size = new Size(108, 40);
            label2.TabIndex = 12;
            label2.Text = "Autospin";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Woodcut", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Khaki;
            label4.Location = new Point(348, 536);
            label4.Name = "label4";
            label4.Size = new Size(160, 48);
            label4.TabIndex = 14;
            label4.Text = "Round 8";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(407, 101);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(101, 183);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Vanilla Whale", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(83, 9);
            label3.Name = "label3";
            label3.Size = new Size(353, 88);
            label3.TabIndex = 16;
            label3.Text = "Slotmachine";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.Khaki;
            checkBox1.Location = new Point(416, 468);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(88, 26);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Fast spin";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(469, -1);
            label5.Name = "label5";
            label5.Size = new Size(21, 25);
            label5.TabIndex = 18;
            label5.Text = "?";
            label5.Click += label5_Click;
            // 
            // lblnoWin
            // 
            lblnoWin.AutoSize = true;
            lblnoWin.BackColor = Color.Black;
            lblnoWin.Font = new Font("Woodcut", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnoWin.ForeColor = Color.Coral;
            lblnoWin.Location = new Point(49, 140);
            lblnoWin.Name = "lblnoWin";
            lblnoWin.Size = new Size(430, 28);
            lblnoWin.TabIndex = 19;
            lblnoWin.Text = "No luck, try again";
            // 
            // lblwinAmount
            // 
            lblwinAmount.AutoSize = true;
            lblwinAmount.BackColor = Color.Black;
            lblwinAmount.Font = new Font("Woodcut", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblwinAmount.ForeColor = Color.Coral;
            lblwinAmount.Location = new Point(98, 183);
            lblwinAmount.Name = "lblwinAmount";
            lblwinAmount.Size = new Size(410, 33);
            lblwinAmount.TabIndex = 20;
            lblwinAmount.Text = "You win 3000 $";
            // 
            // Slots
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(524, 578);
            Controls.Add(lblwinAmount);
            Controls.Add(lblnoWin);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(betlbl);
            Controls.Add(infolbl);
            Controls.Add(lbljackpot);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Font = new Font("Western Bang Bang", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Yellow;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Slots";
            Text = "Slots";
            FormClosing += Slots_FormClosing;
            Load += Slots_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
        private Button button3;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
        private Label lbljackpot;
        private Label infolbl;
        private Label betlbl;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label4;
        private PictureBox pictureBox4;
        private Label label3;
        private CheckBox checkBox1;
        private Label label5;
        private Label lblnoWin;
        private Label lblwinAmount;
    }
}