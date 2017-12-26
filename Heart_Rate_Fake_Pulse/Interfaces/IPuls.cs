using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Label = System.Windows.Forms.Label;

namespace Heart_Rate_Fake_Pulse
{
    interface IPuls
    {
        Label Heart_Rate { get; set; }
    }
}
