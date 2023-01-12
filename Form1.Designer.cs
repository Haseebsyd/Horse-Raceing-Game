namespace A2_HorseRacingGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblTiming = new System.Windows.Forms.Label();
            this.oneHorse = new System.Windows.Forms.PictureBox();
            this.twoHorse = new System.Windows.Forms.PictureBox();
            this.threeHorse = new System.Windows.Forms.PictureBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHorse = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSpeed_ = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblTime1 = new System.Windows.Forms.Label();
            this.lblTime2 = new System.Windows.Forms.Label();
            this.lblTime3 = new System.Windows.Forms.Label();
            this.lblSpeed1 = new System.Windows.Forms.Label();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.lblSpeed3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneHorse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoHorse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeHorse)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 402);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "S   T   A   R   T";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.richTextBox1.Location = new System.Drawing.Point(202, 338);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(16, 75);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "E\n\nN\n\nD";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(495, 17);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(44, 13);
            this.lblWinner.TabIndex = 4;
            this.lblWinner.Text = "Winner:";
            // 
            // lblTiming
            // 
            this.lblTiming.AutoSize = true;
            this.lblTiming.Location = new System.Drawing.Point(495, 39);
            this.lblTiming.Name = "lblTiming";
            this.lblTiming.Size = new System.Drawing.Size(41, 13);
            this.lblTiming.TabIndex = 5;
            this.lblTiming.Text = "Timing:";
            // 
            // oneHorse
            // 
            this.oneHorse.Image = ((System.Drawing.Image)(resources.GetObject("oneHorse.Image")));
            this.oneHorse.Location = new System.Drawing.Point(15, 223);
            this.oneHorse.Name = "oneHorse";
            this.oneHorse.Size = new System.Drawing.Size(20, 15);
            this.oneHorse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oneHorse.TabIndex = 6;
            this.oneHorse.TabStop = false;
            // 
            // twoHorse
            // 
            this.twoHorse.Image = ((System.Drawing.Image)(resources.GetObject("twoHorse.Image")));
            this.twoHorse.Location = new System.Drawing.Point(43, 223);
            this.twoHorse.Name = "twoHorse";
            this.twoHorse.Size = new System.Drawing.Size(20, 15);
            this.twoHorse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twoHorse.TabIndex = 7;
            this.twoHorse.TabStop = false;
            // 
            // threeHorse
            // 
            this.threeHorse.Image = ((System.Drawing.Image)(resources.GetObject("threeHorse.Image")));
            this.threeHorse.Location = new System.Drawing.Point(71, 223);
            this.threeHorse.Name = "threeHorse";
            this.threeHorse.Size = new System.Drawing.Size(20, 15);
            this.threeHorse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.threeHorse.TabIndex = 8;
            this.threeHorse.TabStop = false;
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(495, 62);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(41, 13);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "Speed:";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(498, 350);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(92, 23);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "START RACE";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(596, 350);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(99, 23);
            this.btnRestart.TabIndex = 11;
            this.btnRestart.Text = "RESTART RACE";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(495, 390);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(0, 13);
            this.lblDescription.TabIndex = 12;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblHorse
            // 
            this.lblHorse.AutoSize = true;
            this.lblHorse.Location = new System.Drawing.Point(508, 200);
            this.lblHorse.Name = "lblHorse";
            this.lblHorse.Size = new System.Drawing.Size(42, 13);
            this.lblHorse.TabIndex = 13;
            this.lblHorse.Text = "Horse#";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(556, 200);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(44, 13);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time (s)";
            // 
            // lblSpeed_
            // 
            this.lblSpeed_.AutoSize = true;
            this.lblSpeed_.Location = new System.Drawing.Point(600, 200);
            this.lblSpeed_.Name = "lblSpeed_";
            this.lblSpeed_.Size = new System.Drawing.Size(65, 13);
            this.lblSpeed_.TabIndex = 15;
            this.lblSpeed_.Text = "Speed (m/s)";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(508, 219);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(20, 13);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "#1";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(508, 266);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(20, 13);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "#3";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(508, 243);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(20, 13);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "#2";
            // 
            // lblTime1
            // 
            this.lblTime1.AutoSize = true;
            this.lblTime1.Location = new System.Drawing.Point(556, 219);
            this.lblTime1.Name = "lblTime1";
            this.lblTime1.Size = new System.Drawing.Size(16, 13);
            this.lblTime1.TabIndex = 19;
            this.lblTime1.Text = "...";
            // 
            // lblTime2
            // 
            this.lblTime2.AutoSize = true;
            this.lblTime2.Location = new System.Drawing.Point(556, 243);
            this.lblTime2.Name = "lblTime2";
            this.lblTime2.Size = new System.Drawing.Size(16, 13);
            this.lblTime2.TabIndex = 20;
            this.lblTime2.Text = "...";
            // 
            // lblTime3
            // 
            this.lblTime3.AutoSize = true;
            this.lblTime3.Location = new System.Drawing.Point(556, 266);
            this.lblTime3.Name = "lblTime3";
            this.lblTime3.Size = new System.Drawing.Size(16, 13);
            this.lblTime3.TabIndex = 21;
            this.lblTime3.Text = "...";
            // 
            // lblSpeed1
            // 
            this.lblSpeed1.AutoSize = true;
            this.lblSpeed1.Location = new System.Drawing.Point(600, 219);
            this.lblSpeed1.Name = "lblSpeed1";
            this.lblSpeed1.Size = new System.Drawing.Size(16, 13);
            this.lblSpeed1.TabIndex = 22;
            this.lblSpeed1.Text = "...";
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.AutoSize = true;
            this.lblSpeed2.Location = new System.Drawing.Point(600, 243);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(16, 13);
            this.lblSpeed2.TabIndex = 23;
            this.lblSpeed2.Text = "...";
            // 
            // lblSpeed3
            // 
            this.lblSpeed3.AutoSize = true;
            this.lblSpeed3.Location = new System.Drawing.Point(600, 266);
            this.lblSpeed3.Name = "lblSpeed3";
            this.lblSpeed3.Size = new System.Drawing.Size(16, 13);
            this.lblSpeed3.TabIndex = 24;
            this.lblSpeed3.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSpeed3);
            this.Controls.Add(this.lblSpeed2);
            this.Controls.Add(this.lblSpeed1);
            this.Controls.Add(this.lblTime3);
            this.Controls.Add(this.lblTime2);
            this.Controls.Add(this.lblTime1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblSpeed_);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblHorse);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.threeHorse);
            this.Controls.Add(this.twoHorse);
            this.Controls.Add(this.oneHorse);
            this.Controls.Add(this.lblTiming);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oneHorse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twoHorse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeHorse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblTiming;
        private System.Windows.Forms.PictureBox oneHorse;
        private System.Windows.Forms.PictureBox twoHorse;
        private System.Windows.Forms.PictureBox threeHorse;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblHorse;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSpeed_;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblTime1;
        private System.Windows.Forms.Label lblTime2;
        private System.Windows.Forms.Label lblTime3;
        private System.Windows.Forms.Label lblSpeed1;
        private System.Windows.Forms.Label lblSpeed2;
        private System.Windows.Forms.Label lblSpeed3;
    }
}

