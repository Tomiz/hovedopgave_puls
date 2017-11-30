using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heart_Rate_Fake_Pulse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private bool sleep_button_clicked = false;
        private bool standard_button_clicked = false;
        private bool training_button_clicked = false;
        private bool attack_button_clicked = false;

        public void timer1_Tick(object sender, EventArgs e)
        {
            Label heartRate = HeartRate;

            if (sleep_button_clicked == true)
            {
                // sleep puls
                Random sleep_puls = new Random();
                // Or whatever limits you want... Next() returns a double
                int sleep = sleep_puls.Next(47, 53);
                heartRate.Text = sleep.ToString();
            }
            if (standard_button_clicked == true)
            {
                // standard puls
                Random standard_puls = new Random();
                int standard = standard_puls.Next(57, 63);
                heartRate.Text = standard.ToString();
            }
           if (training_button_clicked == true)
            {
                // Training puls
                Random training_puls = new Random();
                // Or whatever limits you want... Next() returns a double
                int training = training_puls.Next(70, 90);
                heartRate.Text = training.ToString();
            }
            if (attack_button_clicked == true)
            {
                // Attacck puls
                Random attack_puls = new Random();
                // Or whatever limits you want... Next() returns a double
                int attack = attack_puls.Next(100, 120);
                heartRate.Text = attack.ToString();
            }
        }

        private void button_sleep_Click(object sender, EventArgs e)
        {
            sleep_button_clicked = true;
            standard_button_clicked = false;
            training_button_clicked = false;
            attack_button_clicked = false;
        }

        private void button_standard_Click(object sender, EventArgs e)
        {
            sleep_button_clicked = false;
            standard_button_clicked = true;
            training_button_clicked = false;
            attack_button_clicked = false;
        }

        private void button_training_Click(object sender, EventArgs e)
        {
            sleep_button_clicked = false;
            standard_button_clicked = false;
            training_button_clicked = true;
            attack_button_clicked = false;
        }

        private void button_attack_Click(object sender, EventArgs e)
        {
            sleep_button_clicked = false;
            standard_button_clicked = false;
            training_button_clicked = false;
            attack_button_clicked = true;
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            sleep_button_clicked = false;
            standard_button_clicked = false;
            training_button_clicked = false;
            attack_button_clicked = false;
            HeartRate.Text = "Puls";
        }
    }
}