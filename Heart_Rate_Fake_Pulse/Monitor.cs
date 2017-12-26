using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heart_Rate_Fake_Pulse
{
    public class Monitor : IMsg
    {
        public Label Msg { get; set; }

        public bool Sleep { get; set; }
        public bool Normal { get; set; }
        public bool Training { get; set; }
        public bool Attack { get; set; }

        public void PulsMonitor()
        {
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
    }
}
