using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heart_Rate_Fake_Pulse
{
    interface IMonitor
    {
        bool Sleep { get; set; }
        bool Normal { get; set; }
        bool Training { get; set; }
        bool Attack { get; set; }
    }
}
