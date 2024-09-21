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
            lblMsg = new Label();
            infolbl = new Label();
            betlbl = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(55, 80);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 195);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(194, 80);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 195);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(330, 80);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(101, 195);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Vanilla Whale", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 296);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(376, 97);
            button1.TabIndex = 3;
            button1.Text = "Spin";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Western Bang Bang", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(437, 296);
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
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Western Bang Bang", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Yellow;
            button4.Location = new Point(437, 345);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(38, 48);
            button4.TabIndex = 6;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblMsg
            // 
            lblMsg.BackColor = Color.Transparent;
            lblMsg.Font = new Font("Western Bang Bang", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMsg.Location = new Point(55, 433);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(387, 50);
            lblMsg.TabIndex = 7;
            lblMsg.Text = "label1";
            lblMsg.Click += lblMsg_Click;
            // 
            // infolbl
            // 
            infolbl.BackColor = Color.Transparent;
            infolbl.Font = new Font("Western Bang Bang", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infolbl.Location = new Point(55, 21);
            infolbl.Name = "infolbl";
            infolbl.Size = new Size(242, 39);
            infolbl.TabIndex = 8;
            infolbl.Text = "label1";
            // 
            // betlbl
            // 
            betlbl.BackColor = Color.Transparent;
            betlbl.Font = new Font("Western Bang Bang", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            betlbl.Location = new Point(294, 21);
            betlbl.Name = "betlbl";
            betlbl.Size = new Size(137, 39);
            betlbl.TabIndex = 9;
            betlbl.Text = "label1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(469, 9);
            label1.Name = "label1";
            label1.Size = new Size(23, 25);
            label1.TabIndex = 10;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.Black;
            numericUpDown1.ForeColor = Color.Yellow;
            numericUpDown1.Location = new Point(355, 401);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 29);
            numericUpDown1.TabIndex = 11;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Western Bang Bang", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(232, 397);
            label2.Name = "label2";
            label2.Size = new Size(117, 48);
            label2.TabIndex = 12;
            label2.Text = "Autospin";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Western Bang Bang", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(369, 483);
            label4.Name = "label4";
            label4.Size = new Size(117, 48);
            label4.TabIndex = 14;
            label4.Text = "Round:";
            // 
            // Slots
            // 
            AutoScaleDimensions = new SizeF(8F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(498, 517);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(betlbl);
            Controls.Add(infolbl);
            Controls.Add(lblMsg);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
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
        private Label lblMsg;
        private Label infolbl;
        private Label betlbl;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label label4;
    }
}