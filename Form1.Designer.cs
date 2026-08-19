namespace Stopwatch
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
            this.tmrCountdown = new System.Windows.Forms.Timer(this.components);
            this.lblCountdown = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.numSeconds = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
            this.SuspendLayout();
            //
            // tmrCountdown
            //
            this.tmrCountdown.Interval = 1000;
            this.tmrCountdown.Tick += new System.EventHandler(this.tmrCountdown_Tick);
            //
            // lblCountdown
            //
            this.lblCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCountdown.Font = new System.Drawing.Font("Consolas", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountdown.Location = new System.Drawing.Point(20, 20);
            this.lblCountdown.Name = "lblCountdown";
            this.lblCountdown.Size = new System.Drawing.Size(760, 150);
            this.lblCountdown.TabIndex = 0;
            this.lblCountdown.Text = "00:00:00";
            this.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblHours
            //
            this.lblHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblHours.Location = new System.Drawing.Point(230, 200);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(37, 15);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Hours";
            //
            // lblMinutes
            //
            this.lblMinutes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMinutes.Location = new System.Drawing.Point(355, 200);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(52, 15);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "Minutes";
            //
            // lblSeconds
            //
            this.lblSeconds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSeconds.Location = new System.Drawing.Point(480, 200);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(53, 15);
            this.lblSeconds.TabIndex = 5;
            this.lblSeconds.Text = "Seconds";
            //
            // numHours
            //
            this.numHours.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numHours.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numHours.Location = new System.Drawing.Point(230, 220);
            this.numHours.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(90, 32);
            this.numHours.TabIndex = 2;
            this.numHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // numMinutes
            //
            this.numMinutes.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numMinutes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numMinutes.Location = new System.Drawing.Point(355, 220);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(90, 32);
            this.numMinutes.TabIndex = 4;
            this.numMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // numSeconds
            //
            this.numSeconds.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.numSeconds.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.numSeconds.Location = new System.Drawing.Point(480, 220);
            this.numSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numSeconds.Name = "numSeconds";
            this.numSeconds.Size = new System.Drawing.Size(90, 32);
            this.numSeconds.TabIndex = 6;
            this.numSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // btnStart
            //
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnStart.Location = new System.Drawing.Point(140, 300);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 45);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            //
            // btnPause
            //
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPause.Location = new System.Drawing.Point(280, 300);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(120, 45);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            //
            // btnResume
            //
            this.btnResume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResume.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnResume.Location = new System.Drawing.Point(420, 300);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(120, 45);
            this.btnResume.TabIndex = 9;
            this.btnResume.Text = "Resume";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            //
            // btnReset
            //
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnReset.Location = new System.Drawing.Point(560, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 45);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.numSeconds);
            this.Controls.Add(this.numMinutes);
            this.Controls.Add(this.numHours);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblMinutes);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblCountdown);
            this.MinimumSize = new System.Drawing.Size(640, 400);
            this.Name = "Form1";
            this.Text = "VClock - Countdown Timer";
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrCountdown;
        private System.Windows.Forms.Label lblCountdown;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnReset;
    }
}
