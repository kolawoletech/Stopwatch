using System;

namespace Stopwatch
{
    /// <summary>
    /// Represents the possible states of a countdown.
    /// </summary>
    public enum CountdownState
    {
        /// <summary>No countdown is loaded/running.</summary>
        Stopped,
        /// <summary>Countdown is actively counting down.</summary>
        Running,
        /// <summary>Countdown is temporarily paused.</summary>
        Paused,
        /// <summary>Countdown has reached zero.</summary>
        Finished
    }

    /// <summary>
    /// Pure countdown model. It owns the remaining time and the state,
    /// but knows nothing about the UI or the WinForms Timer. Form1 drives
    /// it by calling <see cref="Tick"/> once per second, keeping the
    /// countdown logic separated from the presentation layer.
    /// </summary>
    public class CountdownTimer
    {
        // One second is subtracted on every tick.
        private static readonly TimeSpan OneSecond = TimeSpan.FromSeconds(1);

        /// <summary>Time still left on the clock.</summary>
        public TimeSpan Remaining { get; private set; }

        /// <summary>Current lifecycle state of the countdown.</summary>
        public CountdownState State { get; private set; } = CountdownState.Stopped;

        /// <summary>True once the countdown has reached zero.</summary>
        public bool IsFinished => State == CountdownState.Finished;

        /// <summary>True while the countdown is actively running.</summary>
        public bool IsRunning => State == CountdownState.Running;

        /// <summary>True while the countdown is paused.</summary>
        public bool IsPaused => State == CountdownState.Paused;

        /// <summary>
        /// Loads a duration and begins running.
        /// </summary>
        /// <param name="duration">The amount of time to count down from.</param>
        public void Start(TimeSpan duration)
        {
            Remaining = duration;
            State = CountdownState.Running;
        }

        /// <summary>
        /// Advances the countdown by one second. Has no effect unless the
        /// countdown is currently running. When the remaining time hits zero
        /// the state automatically becomes <see cref="CountdownState.Finished"/>.
        /// </summary>
        public void Tick()
        {
            if (State != CountdownState.Running)
            {
                return;
            }

            Remaining = Remaining.Subtract(OneSecond);

            if (Remaining <= TimeSpan.Zero)
            {
                Remaining = TimeSpan.Zero;
                State = CountdownState.Finished;
            }
        }

        /// <summary>Pauses a running countdown.</summary>
        public void Pause()
        {
            if (State == CountdownState.Running)
            {
                State = CountdownState.Paused;
            }
        }

        /// <summary>Resumes a paused countdown.</summary>
        public void Resume()
        {
            if (State == CountdownState.Paused)
            {
                State = CountdownState.Running;
            }
        }

        /// <summary>Clears the countdown back to the stopped state.</summary>
        public void Reset()
        {
            Remaining = TimeSpan.Zero;
            State = CountdownState.Stopped;
        }

        /// <summary>
        /// Formats the remaining time as hh:mm:ss with leading zeros.
        /// Hours are taken from the total so durations of 24h+ still work.
        /// </summary>
        public string Format()
        {
            return string.Format("{0:00}:{1:00}:{2:00}",
                (int)Remaining.TotalHours,
                Remaining.Minutes,
                Remaining.Seconds);
        }
    }
}
