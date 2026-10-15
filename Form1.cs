using System;
using System.Media;
using System.Windows.Forms;

namespace Stopwatch
{
    public partial class Form1 : Form
    {
        private readonly CountdownTimer _countdown = new CountdownTimer();

        public Form1()
        {
            InitializeComponent();
            ResetCountdown();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartCountdown();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseCountdown();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            ResumeCountdown();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetCountdown();
        }

        private void tmrCountdown_Tick(object sender, EventArgs e)
        {
            _countdown.Tick();
            UpdateDisplay();

            if (_countdown.IsFinished)
            {
                FinishCountdown();
            }
        }

        private void StartCountdown()
        {
            TimeSpan duration = GetSelectedDuration();
            if (duration <= TimeSpan.Zero)
            {
                return;
            }

            _countdown.Start(duration);
            tmrCountdown.Start();
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void PauseCountdown()
        {
            _countdown.Pause();
            tmrCountdown.Stop();
            UpdateButtonStates();
        }

        private void ResumeCountdown()
        {
            _countdown.Resume();
            tmrCountdown.Start();
            UpdateButtonStates();
        }

        private void ResetCountdown()
        {
            tmrCountdown.Stop();
            _countdown.Reset();
            UpdateDisplay();
            UpdateButtonStates();
        }

        private void FinishCountdown()
        {
            tmrCountdown.Stop();
            lblCountdown.Text = "TIME IS UP";
            SystemSounds.Beep.Play();
            UpdateButtonStates();
        }

        private TimeSpan GetSelectedDuration()
        {
            return new TimeSpan((int)numHours.Value, (int)numMinutes.Value, (int)numSeconds.Value);
        }

        private void UpdateDisplay()
        {
            if (_countdown.State == CountdownState.Stopped)
            {
                TimeSpan duration = GetSelectedDuration();
                lblCountdown.Text = string.Format("{0:00}:{1:00}:{2:00}",
                    (int)duration.TotalHours,
                    duration.Minutes,
                    duration.Seconds);
            }
            else
            {
                lblCountdown.Text = _countdown.Format();
            }
        }

        private void UpdateButtonStates()
        {
            bool running = _countdown.IsRunning;
            bool paused = _countdown.IsPaused;
            bool active = running || paused;

            btnStart.Enabled = !active;
            btnPause.Enabled = running;
            btnResume.Enabled = paused;
            btnReset.Enabled = active || _countdown.IsFinished;
            numHours.Enabled = !active;
            numMinutes.Enabled = !active;
            numSeconds.Enabled = !active;
        }
    }
}
