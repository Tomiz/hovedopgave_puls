namespace Heart_Rate_Fake_Pulse
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
            this.button_sleep = new System.Windows.Forms.Button();
            this.button_standard = new System.Windows.Forms.Button();
            this.HeartRate = new System.Windows.Forms.Label();
            this.timerPuls = new System.Windows.Forms.Timer(this.components);
            this.button_training = new System.Windows.Forms.Button();
            this.button_attack = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.label_msg = new System.Windows.Forms.Label();
            this.timerAttack = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button_sleep
            // 
            this.button_sleep.Location = new System.Drawing.Point(49, 71);
            this.button_sleep.Name = "button_sleep";
            this.button_sleep.Size = new System.Drawing.Size(75, 23);
            this.button_sleep.TabIndex = 1;
            this.button_sleep.Text = "Sleep";
            this.button_sleep.UseVisualStyleBackColor = true;
            this.button_sleep.Click += new System.EventHandler(this.button_sleep_Click);
            // 
            // button_standard
            // 
            this.button_standard.Location = new System.Drawing.Point(130, 71);
            this.button_standard.Name = "button_standard";
            this.button_standard.Size = new System.Drawing.Size(75, 23);
            this.button_standard.TabIndex = 2;
            this.button_standard.Text = "Standard";
            this.button_standard.UseVisualStyleBackColor = true;
            this.button_standard.Click += new System.EventHandler(this.button_standard_Click);
            // 
            // HeartRate
            // 
            this.HeartRate.AutoSize = true;
            this.HeartRate.Location = new System.Drawing.Point(49, 37);
            this.HeartRate.Name = "HeartRate";
            this.HeartRate.Size = new System.Drawing.Size(27, 13);
            this.HeartRate.TabIndex = 3;
            this.HeartRate.Text = "Puls";
            // 
            // timerPuls
            // 
            this.timerPuls.Enabled = true;
            this.timerPuls.Interval = 1000;
            this.timerPuls.Tick += new System.EventHandler(this.timerPuls_Tick);
            // 
            // button_training
            // 
            this.button_training.Location = new System.Drawing.Point(49, 100);
            this.button_training.Name = "button_training";
            this.button_training.Size = new System.Drawing.Size(75, 23);
            this.button_training.TabIndex = 4;
            this.button_training.Text = "Training";
            this.button_training.UseVisualStyleBackColor = true;
            this.button_training.Click += new System.EventHandler(this.button_training_Click);
            // 
            // button_attack
            // 
            this.button_attack.Location = new System.Drawing.Point(130, 100);
            this.button_attack.Name = "button_attack";
            this.button_attack.Size = new System.Drawing.Size(75, 23);
            this.button_attack.TabIndex = 5;
            this.button_attack.Text = "Attack";
            this.button_attack.UseVisualStyleBackColor = true;
            this.button_attack.Click += new System.EventHandler(this.button_attack_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(49, 130);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 6;
            this.button_stop.Text = "Dead";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // label_msg
            // 
            this.label_msg.AutoSize = true;
            this.label_msg.Location = new System.Drawing.Point(49, 237);
            this.label_msg.Name = "label_msg";
            this.label_msg.Size = new System.Drawing.Size(27, 13);
            this.label_msg.TabIndex = 7;
            this.label_msg.Text = "Msg";
            // 
            // timerAttack
            // 
            this.timerAttack.Interval = 5000;
            this.timerAttack.Tick += new System.EventHandler(this.timerAttack_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 316);
            this.Controls.Add(this.label_msg);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_attack);
            this.Controls.Add(this.button_training);
            this.Controls.Add(this.HeartRate);
            this.Controls.Add(this.button_standard);
            this.Controls.Add(this.button_sleep);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_sleep;
        private System.Windows.Forms.Button button_standard;
        private System.Windows.Forms.Timer timerPuls;
        private System.Windows.Forms.Button button_training;
        private System.Windows.Forms.Button button_attack;
        private System.Windows.Forms.Button button_stop;
        public System.Windows.Forms.Label HeartRate;
        private System.Windows.Forms.Label label_msg;
        protected System.Windows.Forms.Timer timerAttack;
    }
}

