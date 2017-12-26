using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heart_Rate_Fake_Pulse
{
    public class Puls
    {
        public int HeartRate { get; set; }

        public Puls(int heartRate)
        {
            HeartRate = heartRate;
        }


    }
}
