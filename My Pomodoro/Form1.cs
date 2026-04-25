using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace My_Pomodoro
{
    public partial class Form1 : Form
    {
        private WindowsMediaPlayer Player;
        private string tempDefaultSoundPath;
        private TimeSpan CountDown;
        private bool IsFocusTurn;
        public Form1()
        {
            InitializeComponent();

            Player = new WindowsMediaPlayer();
            Player.settings.autoStart = false;

            tempDefaultSoundPath = Path.Combine(Path.GetTempPath(),"time_up_s7.mp3");

            using (MemoryStream ms = new MemoryStream())
            {
                Properties.Resources.time_up_s7.CopyTo(ms);
                File.WriteAllBytes(tempDefaultSoundPath, ms.ToArray());
            }

            Player.URL = tempDefaultSoundPath;
            CountDown = new TimeSpan();

            rbFocus.Checked = true;
            
            notifyIcon1.BalloonTipTitle = "Time's up";
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipText= "Tap to dismiss";
            
        }

        private void UpdateTimerScreen()
        {
            lblTimerScreen.Text = $"{CountDown.Minutes:D2}:{CountDown.Seconds:D2}";
        }
        private void ResetTimerScreenAndCountDown()
        {
            if (IsFocusTurn)
            {
                CountDown = TimeSpan.FromMinutes((int)nudFocusDuration.Value);
            }
            else
            {
                CountDown = TimeSpan.FromMinutes((int)nudRestDuration.Value);
            }

            UpdateTimerScreen();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(CountDown.TotalSeconds > 0)
            {
                timer1.Start();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void tbVolumeSetter_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = tbVolumeSetter.Value;
            lblVolumeBarValue.Text = tbVolumeSetter.Value.ToString();
        }

        private void ChooseSound(object sender, EventArgs e)
        {
            Button b  = (Button)sender;

            openFileDialog1.Title = "Choose sound";
            openFileDialog1.Filter = "Audio Files|*.mp3;*.wav;*.wma;*.aac;*.m4a|MP3 Files|*.mp3|WAV Files|*.wav";
            openFileDialog1.DefaultExt = "mp3";
            openFileDialog1.FilterIndex = 2;
            
            if (b == btnChoose && openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Player.URL = openFileDialog1.FileName;
            }
            else
            {
                Player.URL = tempDefaultSoundPath;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CountDown = CountDown.Subtract(TimeSpan.FromSeconds(1));
            UpdateTimerScreen();
           
            if(!(CountDown.TotalSeconds > 0))
            {
                Player.controls.play();
                timer1.Stop();
                if(rbFocus.Checked)
                {
                    rbRest.Checked = true;
                }
                else
                {
                    rbFocus.Checked = true;
                }
                
                notifyIcon1.ShowBalloonTip(10000);
                
                
            }
                
        }

        private void FocusAndRestDurationNUD_ValueChanged(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                ResetTimerScreenAndCountDown();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
            {
                return;
            }

            ResetTimerScreenAndCountDown();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            Player.controls.stop();
            this.WindowState = FormWindowState.Normal;
            this.Show();
            this.Activate();
            this.BringToFront();
        }

        private void ChooseDurationType(object sender, EventArgs e)
        {
            timer1.Stop();
            if(((RadioButton)sender).Checked == false)
            {
                return;
            }

            if(((RadioButton)sender)== rbFocus)
            {
                IsFocusTurn = true;
            }
            else
            {
                IsFocusTurn = false;
            }
            ResetTimerScreenAndCountDown();
        }
    }
}