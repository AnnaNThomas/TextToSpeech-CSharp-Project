namespace project8
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
            btnSpeak = new Button();
            comboBox1 = new ComboBox();
            BtnOpenFile = new Button();
            BtnPause = new Button();
            BtnResume = new Button();
            BtnStop = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            trackBar1 = new TrackBar();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            trackBar2 = new TrackBar();
            txtSpechText = new TextBox();
            BtnPronounce = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // btnSpeak
            // 
            btnSpeak.BackColor = Color.GhostWhite;
            btnSpeak.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpeak.Location = new Point(303, 35);
            btnSpeak.Name = "btnSpeak";
            btnSpeak.Size = new Size(175, 45);
            btnSpeak.TabIndex = 0;
            btnSpeak.Text = "Speak";
            btnSpeak.UseVisualStyleBackColor = false;
            btnSpeak.Click += btnSpeak_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.AliceBlue;
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(615, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(400, 45);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "Select Voice";
            // 
            // BtnOpenFile
            // 
            BtnOpenFile.BackColor = SystemColors.GradientInactiveCaption;
            BtnOpenFile.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnOpenFile.Location = new Point(190, 147);
            BtnOpenFile.Name = "BtnOpenFile";
            BtnOpenFile.Size = new Size(133, 65);
            BtnOpenFile.TabIndex = 2;
            BtnOpenFile.Text = "Open File";
            BtnOpenFile.UseVisualStyleBackColor = false;
            // 
            // BtnPause
            // 
            BtnPause.BackColor = SystemColors.GradientInactiveCaption;
            BtnPause.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPause.Location = new Point(426, 147);
            BtnPause.Name = "BtnPause";
            BtnPause.Size = new Size(140, 65);
            BtnPause.TabIndex = 3;
            BtnPause.Text = "Pause";
            BtnPause.UseVisualStyleBackColor = false;
            // 
            // BtnResume
            // 
            BtnResume.BackColor = SystemColors.GradientInactiveCaption;
            BtnResume.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnResume.Location = new Point(689, 147);
            BtnResume.Name = "BtnResume";
            BtnResume.Size = new Size(140, 65);
            BtnResume.TabIndex = 4;
            BtnResume.Text = "Resume";
            BtnResume.UseVisualStyleBackColor = false;
            // 
            // BtnStop
            // 
            BtnStop.BackColor = SystemColors.GradientInactiveCaption;
            BtnStop.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnStop.Location = new Point(949, 147);
            BtnStop.Name = "BtnStop";
            BtnStop.Size = new Size(132, 65);
            BtnStop.TabIndex = 5;
            BtnStop.Text = "Stop";
            BtnStop.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(trackBar1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(39, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1248, 116);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Voice Speed";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1174, 78);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 3;
            label3.Text = "Fast";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(596, 78);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 2;
            label2.Text = "Normal";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 78);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "Slow";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(20, 42);
            trackBar1.Minimum = -10;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(1192, 56);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(trackBar2);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(39, 401);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1248, 116);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Volume";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 78);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 4;
            label6.Text = "Low";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 78);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 3;
            label5.Text = "Normal";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1150, 78);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 2;
            label4.Text = "Maximun";
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(20, 42);
            trackBar2.Maximum = 100;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(1192, 56);
            trackBar2.TabIndex = 0;
            // 
            // txtSpechText
            // 
            txtSpechText.Location = new Point(39, 532);
            txtSpechText.Multiline = true;
            txtSpechText.Name = "txtSpechText";
            txtSpechText.ScrollBars = ScrollBars.Vertical;
            txtSpechText.Size = new Size(1248, 140);
            txtSpechText.TabIndex = 8;
            // 
            // BtnPronounce
            // 
            BtnPronounce.BackColor = SystemColors.GradientActiveCaption;
            BtnPronounce.Location = new Point(581, 678);
            BtnPronounce.Name = "BtnPronounce";
            BtnPronounce.Size = new Size(236, 45);
            BtnPronounce.TabIndex = 9;
            BtnPronounce.Text = "Pronounce Highlighted Words";
            BtnPronounce.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1555, 735);
            Controls.Add(BtnPronounce);
            Controls.Add(txtSpechText);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(BtnStop);
            Controls.Add(BtnResume);
            Controls.Add(BtnPause);
            Controls.Add(BtnOpenFile);
            Controls.Add(comboBox1);
            Controls.Add(btnSpeak);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSpeak;
        private ComboBox comboBox1;
        private Button BtnOpenFile;
        private Button BtnPause;
        private Button BtnResume;
        private Button BtnStop;
        private GroupBox groupBox1;
        private TrackBar trackBar1;
        private GroupBox groupBox2;
        private TrackBar trackBar2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtSpechText;
        private Button BtnPronounce;
    }
}
