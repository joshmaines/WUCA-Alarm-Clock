namespace Alarm_v2._0
{
    partial class Main
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
            this.timeSelector = new System.Windows.Forms.DateTimePicker();
            this.lblSongtitle = new System.Windows.Forms.Label();
            this.btnBrowseSong = new System.Windows.Forms.Button();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.tbStart = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNarrateInterval = new System.Windows.Forms.TextBox();
            this.txtIncreaseInterval = new System.Windows.Forms.TextBox();
            this.txtRepeatTimes = new System.Windows.Forms.TextBox();
            this.lblStartVolume = new System.Windows.Forms.Label();
            this.cbxNarrateTime = new System.Windows.Forms.CheckBox();
            this.cbxGradualVolume = new System.Windows.Forms.CheckBox();
            this.cbxRepeatSong = new System.Windows.Forms.CheckBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnSnooze = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // timeSelector
            // 
            this.timeSelector.CalendarForeColor = System.Drawing.Color.White;
            this.timeSelector.CalendarMonthBackground = System.Drawing.Color.Black;
            this.timeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSelector.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeSelector.Location = new System.Drawing.Point(12, 26);
            this.timeSelector.Name = "timeSelector";
            this.timeSelector.ShowUpDown = true;
            this.timeSelector.Size = new System.Drawing.Size(441, 83);
            this.timeSelector.TabIndex = 0;
            this.timeSelector.ValueChanged += new System.EventHandler(this.timeSelector_ValueChanged);
            // 
            // lblSongtitle
            // 
            this.lblSongtitle.AutoSize = true;
            this.lblSongtitle.Location = new System.Drawing.Point(23, 96);
            this.lblSongtitle.Name = "lblSongtitle";
            this.lblSongtitle.Size = new System.Drawing.Size(0, 13);
            this.lblSongtitle.TabIndex = 1;
            // 
            // btnBrowseSong
            // 
            this.btnBrowseSong.Location = new System.Drawing.Point(204, 147);
            this.btnBrowseSong.Name = "btnBrowseSong";
            this.btnBrowseSong.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseSong.TabIndex = 2;
            this.btnBrowseSong.Text = "Browse";
            this.btnBrowseSong.UseVisualStyleBackColor = true;
            this.btnBrowseSong.Click += new System.EventHandler(this.btnBrowseSong_Click);
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.tbStart);
            this.grpSettings.Controls.Add(this.label3);
            this.grpSettings.Controls.Add(this.label2);
            this.grpSettings.Controls.Add(this.label1);
            this.grpSettings.Controls.Add(this.txtNarrateInterval);
            this.grpSettings.Controls.Add(this.txtIncreaseInterval);
            this.grpSettings.Controls.Add(this.txtRepeatTimes);
            this.grpSettings.Controls.Add(this.lblStartVolume);
            this.grpSettings.Controls.Add(this.cbxNarrateTime);
            this.grpSettings.Controls.Add(this.cbxGradualVolume);
            this.grpSettings.Controls.Add(this.cbxRepeatSong);
            this.grpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSettings.ForeColor = System.Drawing.Color.White;
            this.grpSettings.Location = new System.Drawing.Point(12, 176);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(356, 141);
            this.grpSettings.TabIndex = 3;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Optional Settings";
            // 
            // tbStart
            // 
            this.tbStart.AutoSize = false;
            this.tbStart.Enabled = false;
            this.tbStart.Location = new System.Drawing.Point(109, 80);
            this.tbStart.Maximum = 99;
            this.tbStart.Minimum = 1;
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(104, 20);
            this.tbStart.TabIndex = 6;
            this.tbStart.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbStart.Value = 99;
            this.tbStart.ValueChanged += new System.EventHandler(this.tbStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "time(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "seconds";
            // 
            // txtNarrateInterval
            // 
            this.txtNarrateInterval.Enabled = false;
            this.txtNarrateInterval.Location = new System.Drawing.Point(184, 106);
            this.txtNarrateInterval.Name = "txtNarrateInterval";
            this.txtNarrateInterval.Size = new System.Drawing.Size(25, 22);
            this.txtNarrateInterval.TabIndex = 6;
            this.txtNarrateInterval.TextChanged += new System.EventHandler(this.txtNarrateInterval_TextChanged);
            this.txtNarrateInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // txtIncreaseInterval
            // 
            this.txtIncreaseInterval.Enabled = false;
            this.txtIncreaseInterval.Location = new System.Drawing.Point(204, 46);
            this.txtIncreaseInterval.Name = "txtIncreaseInterval";
            this.txtIncreaseInterval.Size = new System.Drawing.Size(25, 22);
            this.txtIncreaseInterval.TabIndex = 5;
            this.txtIncreaseInterval.TextChanged += new System.EventHandler(this.txtIncreaseInterval_TextChanged);
            this.txtIncreaseInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // txtRepeatTimes
            // 
            this.txtRepeatTimes.Enabled = false;
            this.txtRepeatTimes.Location = new System.Drawing.Point(109, 20);
            this.txtRepeatTimes.Name = "txtRepeatTimes";
            this.txtRepeatTimes.Size = new System.Drawing.Size(33, 22);
            this.txtRepeatTimes.TabIndex = 4;
            this.txtRepeatTimes.TextChanged += new System.EventHandler(this.txtRepeatTimes_TextChanged);
            this.txtRepeatTimes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckInput);
            // 
            // lblStartVolume
            // 
            this.lblStartVolume.AutoSize = true;
            this.lblStartVolume.Location = new System.Drawing.Point(23, 79);
            this.lblStartVolume.Margin = new System.Windows.Forms.Padding(20, 6, 3, 0);
            this.lblStartVolume.Name = "lblStartVolume";
            this.lblStartVolume.Size = new System.Drawing.Size(82, 16);
            this.lblStartVolume.TabIndex = 3;
            this.lblStartVolume.Text = "Start volume";
            // 
            // cbxNarrateTime
            // 
            this.cbxNarrateTime.AutoSize = true;
            this.cbxNarrateTime.Location = new System.Drawing.Point(6, 108);
            this.cbxNarrateTime.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbxNarrateTime.Name = "cbxNarrateTime";
            this.cbxNarrateTime.Size = new System.Drawing.Size(183, 20);
            this.cbxNarrateTime.TabIndex = 2;
            this.cbxNarrateTime.Text = "Narrate current time every ";
            this.cbxNarrateTime.UseVisualStyleBackColor = true;
            this.cbxNarrateTime.CheckedChanged += new System.EventHandler(this.cbxNarrateTime_CheckedChanged);
            // 
            // cbxGradualVolume
            // 
            this.cbxGradualVolume.AutoSize = true;
            this.cbxGradualVolume.Location = new System.Drawing.Point(6, 48);
            this.cbxGradualVolume.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cbxGradualVolume.Name = "cbxGradualVolume";
            this.cbxGradualVolume.Size = new System.Drawing.Size(203, 20);
            this.cbxGradualVolume.TabIndex = 1;
            this.cbxGradualVolume.Text = "Gradually increase volume in ";
            this.cbxGradualVolume.UseVisualStyleBackColor = true;
            this.cbxGradualVolume.CheckedChanged += new System.EventHandler(this.cbxGradualVolume_CheckedChanged);
            // 
            // cbxRepeatSong
            // 
            this.cbxRepeatSong.AutoSize = true;
            this.cbxRepeatSong.Location = new System.Drawing.Point(6, 22);
            this.cbxRepeatSong.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.cbxRepeatSong.Name = "cbxRepeatSong";
            this.cbxRepeatSong.Size = new System.Drawing.Size(105, 20);
            this.cbxRepeatSong.TabIndex = 0;
            this.cbxRepeatSong.Text = "Repeat song";
            this.cbxRepeatSong.UseVisualStyleBackColor = true;
            this.cbxRepeatSong.CheckedChanged += new System.EventHandler(this.cbxRepeatSong_CheckedChanged);
            // 
            // btnSet
            // 
            this.btnSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSet.Enabled = false;
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(376, 147);
            this.btnSet.Margin = new System.Windows.Forms.Padding(12);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(192, 48);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Start Alarm";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnSnooze
            // 
            this.btnSnooze.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSnooze.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSnooze.Enabled = false;
            this.btnSnooze.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnooze.Location = new System.Drawing.Point(459, 45);
            this.btnSnooze.Margin = new System.Windows.Forms.Padding(12);
            this.btnSnooze.Name = "btnSnooze";
            this.btnSnooze.Size = new System.Drawing.Size(109, 48);
            this.btnSnooze.TabIndex = 7;
            this.btnSnooze.Text = "Snooze";
            this.btnSnooze.UseVisualStyleBackColor = true;
            this.btnSnooze.Click += new System.EventHandler(this.btnSnooze_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choose sound file (.MP3) to be played:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(580, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSnooze);
            this.Controls.Add(this.timeSelector);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.btnBrowseSong);
            this.Controls.Add(this.lblSongtitle);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Alarm Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timeSelector;
        private System.Windows.Forms.Label lblSongtitle;
        private System.Windows.Forms.Button btnBrowseSong;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.CheckBox cbxNarrateTime;
        private System.Windows.Forms.CheckBox cbxGradualVolume;
        private System.Windows.Forms.CheckBox cbxRepeatSong;
        private System.Windows.Forms.TrackBar tbStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNarrateInterval;
        private System.Windows.Forms.TextBox txtIncreaseInterval;
        private System.Windows.Forms.TextBox txtRepeatTimes;
        private System.Windows.Forms.Label lblStartVolume;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnSnooze;
        private System.Windows.Forms.Label label4;
    }
}

