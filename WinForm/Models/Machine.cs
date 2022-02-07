using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    public class Machine
    {
        public string Ip { get; set; }
        public string Port { get; set; }
        public int MachineNo { get; set; }
        public string MachineInfo { get; set; }
        public bool Status { get; set; }

    }
}
