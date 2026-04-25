using System.Drawing;

namespace My_Pomodoro
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpTimer = new System.Windows.Forms.TabPage();
            this.rbRest = new System.Windows.Forms.RadioButton();
            this.rbFocus = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblTimerScreen = new System.Windows.Forms.Label();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnChoose = new System.Windows.Forms.Button();
            this.nudRestDuration = new System.Windows.Forms.NumericUpDown();
            this.nudFocusDuration = new System.Windows.Forms.NumericUpDown();
            this.lblVolumeBarValue = new System.Windows.Forms.Label();
            this.tbVolumeSetter = new System.Windows.Forms.TrackBar();
            this.lblRestDuration = new System.Windows.Forms.Label();
            this.lblFocusDuration = new System.Windows.Forms.Label();
            this.lblRingSound = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tpTimer.SuspendLayout();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocusDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumeSetter)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpTimer);
            this.tabControl1.Controls.Add(this.tpSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(677, 389);
            this.tabControl1.TabIndex = 0;
            // 
            // tpTimer
            // 
            this.tpTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tpTimer.Controls.Add(this.rbRest);
            this.tpTimer.Controls.Add(this.rbFocus);
            this.tpTimer.Controls.Add(this.btnReset);
            this.tpTimer.Controls.Add(this.btnPause);
            this.tpTimer.Controls.Add(this.btnStart);
            this.tpTimer.Controls.Add(this.lblTimerScreen);
            this.tpTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpTimer.ImageIndex = 1;
            this.tpTimer.Location = new System.Drawing.Point(4, 34);
            this.tpTimer.Name = "tpTimer";
            this.tpTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tpTimer.Size = new System.Drawing.Size(669, 351);
            this.tpTimer.TabIndex = 1;
            this.tpTimer.Text = "Timer";
            // 
            // rbRest
            // 
            this.rbRest.AutoSize = true;
            this.rbRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRest.Location = new System.Drawing.Point(377, 189);
            this.rbRest.Name = "rbRest";
            this.rbRest.Size = new System.Drawing.Size(60, 22);
            this.rbRest.TabIndex = 2;
            this.rbRest.Text = "Rest";
            this.rbRest.UseVisualStyleBackColor = true;
            this.rbRest.CheckedChanged += new System.EventHandler(this.ChooseDurationType);
            // 
            // rbFocus
            // 
            this.rbFocus.AutoSize = true;
            this.rbFocus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFocus.Location = new System.Drawing.Point(244, 189);
            this.rbFocus.Name = "rbFocus";
            this.rbFocus.Size = new System.Drawing.Size(71, 22);
            this.rbFocus.TabIndex = 2;
            this.rbFocus.Text = "Focus";
            this.rbFocus.UseVisualStyleBackColor = true;
            this.rbFocus.CheckedChanged += new System.EventHandler(this.ChooseDurationType);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::My_Pomodoro.Properties.Resources.Reset;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.Location = new System.Drawing.Point(443, 258);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 48);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Image = global::My_Pomodoro.Properties.Resources.Pause;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPause.Location = new System.Drawing.Point(281, 258);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(106, 48);
            this.btnPause.TabIndex = 1;
            this.btnPause.Text = "Pause";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPause.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Image = global::My_Pomodoro.Properties.Resources.Start;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(119, 258);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 48);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimerScreen
            // 
            this.lblTimerScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTimerScreen.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimerScreen.ForeColor = System.Drawing.Color.Red;
            this.lblTimerScreen.Location = new System.Drawing.Point(245, 44);
            this.lblTimerScreen.Name = "lblTimerScreen";
            this.lblTimerScreen.Size = new System.Drawing.Size(192, 96);
            this.lblTimerScreen.TabIndex = 0;
            this.lblTimerScreen.Text = "25:00";
            this.lblTimerScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpSettings
            // 
            this.tpSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tpSettings.Controls.Add(this.btnDefault);
            this.tpSettings.Controls.Add(this.btnChoose);
            this.tpSettings.Controls.Add(this.nudRestDuration);
            this.tpSettings.Controls.Add(this.nudFocusDuration);
            this.tpSettings.Controls.Add(this.lblVolumeBarValue);
            this.tpSettings.Controls.Add(this.tbVolumeSetter);
            this.tpSettings.Controls.Add(this.lblRestDuration);
            this.tpSettings.Controls.Add(this.lblFocusDuration);
            this.tpSettings.Controls.Add(this.lblRingSound);
            this.tpSettings.Controls.Add(this.lblVolume);
            this.tpSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpSettings.ImageIndex = 0;
            this.tpSettings.Location = new System.Drawing.Point(4, 34);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(669, 351);
            this.tpSettings.TabIndex = 0;
            this.tpSettings.Text = "Settings";
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.Location = new System.Drawing.Point(270, 131);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(73, 29);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Default";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.ChooseSound);
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.Location = new System.Drawing.Point(394, 131);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(73, 29);
            this.btnChoose.TabIndex = 5;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.ChooseSound);
            // 
            // nudRestDuration
            // 
            this.nudRestDuration.Location = new System.Drawing.Point(335, 260);
            this.nudRestDuration.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudRestDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRestDuration.Name = "nudRestDuration";
            this.nudRestDuration.Size = new System.Drawing.Size(76, 30);
            this.nudRestDuration.TabIndex = 4;
            this.nudRestDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudRestDuration.ValueChanged += new System.EventHandler(this.FocusAndRestDurationNUD_ValueChanged);
            // 
            // nudFocusDuration
            // 
            this.nudFocusDuration.Location = new System.Drawing.Point(335, 205);
            this.nudFocusDuration.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudFocusDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFocusDuration.Name = "nudFocusDuration";
            this.nudFocusDuration.Size = new System.Drawing.Size(76, 30);
            this.nudFocusDuration.TabIndex = 4;
            this.nudFocusDuration.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudFocusDuration.ValueChanged += new System.EventHandler(this.FocusAndRestDurationNUD_ValueChanged);
            // 
            // lblVolumeBarValue
            // 
            this.lblVolumeBarValue.AutoSize = true;
            this.lblVolumeBarValue.Location = new System.Drawing.Point(582, 62);
            this.lblVolumeBarValue.Name = "lblVolumeBarValue";
            this.lblVolumeBarValue.Size = new System.Drawing.Size(45, 25);
            this.lblVolumeBarValue.TabIndex = 2;
            this.lblVolumeBarValue.Text = "100";
            // 
            // tbVolumeSetter
            // 
            this.tbVolumeSetter.LargeChange = 10;
            this.tbVolumeSetter.Location = new System.Drawing.Point(163, 61);
            this.tbVolumeSetter.Maximum = 100;
            this.tbVolumeSetter.Name = "tbVolumeSetter";
            this.tbVolumeSetter.Size = new System.Drawing.Size(395, 56);
            this.tbVolumeSetter.TabIndex = 1;
            this.tbVolumeSetter.Value = 100;
            this.tbVolumeSetter.Scroll += new System.EventHandler(this.tbVolumeSetter_Scroll);
            // 
            // lblRestDuration
            // 
            this.lblRestDuration.AutoSize = true;
            this.lblRestDuration.Location = new System.Drawing.Point(63, 265);
            this.lblRestDuration.Name = "lblRestDuration";
            this.lblRestDuration.Size = new System.Drawing.Size(217, 25);
            this.lblRestDuration.TabIndex = 0;
            this.lblRestDuration.Text = "Rest Duration (Minutes)";
            // 
            // lblFocusDuration
            // 
            this.lblFocusDuration.AutoSize = true;
            this.lblFocusDuration.Location = new System.Drawing.Point(63, 207);
            this.lblFocusDuration.Name = "lblFocusDuration";
            this.lblFocusDuration.Size = new System.Drawing.Size(232, 25);
            this.lblFocusDuration.TabIndex = 0;
            this.lblFocusDuration.Text = "Focus Duration (Minutes)";
            // 
            // lblRingSound
            // 
            this.lblRingSound.AutoSize = true;
            this.lblRingSound.Location = new System.Drawing.Point(63, 130);
            this.lblRingSound.Name = "lblRingSound";
            this.lblRingSound.Size = new System.Drawing.Size(114, 25);
            this.lblRingSound.TabIndex = 0;
            this.lblRingSound.Text = "Ring Sound";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(63, 62);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(79, 25);
            this.lblVolume.TabIndex = 0;
            this.lblVolume.Text = "Volume";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Settings.png");
            this.imageList1.Images.SetKeyName(1, "Timer.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(677, 389);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Pomodoro";
            this.tabControl1.ResumeLayout(false);
            this.tpTimer.ResumeLayout(false);
            this.tpTimer.PerformLayout();
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRestDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFocusDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVolumeSetter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpTimer;
        private System.Windows.Forms.Label lblTimerScreen;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblVolumeBarValue;
        private System.Windows.Forms.TrackBar tbVolumeSetter;
        private System.Windows.Forms.Label lblRingSound;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.NumericUpDown nudFocusDuration;
        private System.Windows.Forms.Label lblFocusDuration;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblRestDuration;
        private System.Windows.Forms.NumericUpDown nudRestDuration;
        private System.Windows.Forms.RadioButton rbRest;
        private System.Windows.Forms.RadioButton rbFocus;
        private System.Windows.Forms.ImageList imageList1;
    }
}

