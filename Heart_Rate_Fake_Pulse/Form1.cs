using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;


namespace Heart_Rate_Fake_Pulse
{
    public partial class Form1 : Form, IPuls, IMsg, IMonitor
    {

        #region Interface Members
        // IPuls
        public Label Heart_Rate { get; set; }
        // IMsg
        public Label Msg { get; set; }
        // IMonitor
        public bool Sleep { get; set; }
        public bool Normal { get; set; }
        public bool Training { get; set; }
        public bool Attack { get; set; }
        #endregion

        #region private properties
        private readonly ShowDialog _frm2 = new ShowDialog();
        private bool sleep_button_clicked = false;
        private bool standard_button_clicked = false;
        private bool training_button_clicked = false;
        private bool attack_button_clicked = false;
        #endregion

        #region Contructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        public void timerPuls_Tick(object sender, EventArgs e)
        {
            Heart_Rate = HeartRate;

            if (sleep_button_clicked == true)
            {
                // sleep puls
                Random sleep_puls = new Random();
                // Or whatever limits you want... Next() returns a double
                int sleep = sleep_puls.Next(47, 53);
                Heart_Rate.Text = sleep.ToString();

                PulsMonitor();
                Sleep = true;
            }
            if (standard_button_clicked == true)
            {
                // sleep puls
                Random normal_puls = new Random();
                // Or whatever limits you want... Next() returns a double
                int normal = normal_puls.Next(57, 63);
                Heart_Rate.Text = normal.ToString();

                PulsMonitor();
                Normal = true;
            }
            if (training_button_clicked == true)
            {
                // sleep puls
                Random training_puls = new Random();
                // Or whatever limits you want... Next() returns a double
                int training = training_puls.Next(80, 90);
                Heart_Rate.Text = training.ToString();

                PulsMonitor();
                Training = true;

            }
            if (attack_button_clicked == true)
            {
                // sleep puls
                Random attack_puls = new Random();
                // Or whatever limits you want... Next() returns a double
                int attack = attack_puls.Next(110, 150);
                Heart_Rate.Text = attack.ToString();

                PulsMonitor();
                Attack = true;


                if (attack >= 146)
                {
                    _frm2.Show();
                    timerAttack.Enabled = true;

                    Heart_Rate.Text = @"Attack";
                    attack_button_clicked = false;
                }
                //timerPuls.Interval = 5000;
                //timerAttack.Enabled = true;
                //if (timerPuls.Interval >= 5000 && timerAttack.Enabled == true)
                //{
                //    ShowDialog frm2 = new ShowDialog();
                //    frm2.Show();
                //}
            }
        }

        public void PulsMonitor()
        {
            Msg = label_msg;

            if (Sleep)
            {
                Msg.Text = @"Sove Puls";
            }
            if (Normal)
            {
                Msg.Text = @"Normal Puls";
            }
            if (Training)
            {
                Msg.Text = @"Aktiv Puls";
            }
            if (Attack)
            {
                Msg.Text = @"Anfald";
            }
        }

        public void SendSms()
        {
            /*
            * Sms Kode
           */
            // Find your Account Sid and Auth Token at twilio.com/user/account
            const string accountSid = "AC005ebd29c3cd2c89607e510501f2b0ba";
            const string authToken = "3127fad8cd518790edd9294d57846df2";

            // Initialize the Twilio client
            TwilioClient.Init(accountSid, authToken);

            // make an associative array of people we know, indexed by phone number
            var people = new Dictionary<string, string>()
                {
                    {"+4527421525", "Thomas"},
                };

            // Iterate over all our friends
            foreach (var person in people)
            {
                // Send a new outgoing SMS by POSTing to the Messages resource
                MessageResource.Create(
                    from: new PhoneNumber("+1 661-526-0244 "), // From number, must be an SMS-enabled Twilio number
                    to: new PhoneNumber(person.Key), // To number, if using Sandbox see note above
                                                     // Message content
                    body: $"Hej {person.Value} Har fået et epilepisk anfald, vær sød og kig til ham og kald efter hjælp!");

                Console.WriteLine(@"Sent message to {person.Value}");
            }
            timerAttack.Enabled = false;
        }

        private void timerAttack_Tick(object sender, EventArgs e)
        {
            _frm2.Hide();
            SendSms();
        }
        #endregion

        #region Button Click

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
        #endregion

        
    }
}