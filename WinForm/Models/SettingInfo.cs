using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Models
{
    class SettingInfo
    {
        public int HrConfigId { get; set; }
        public int BranchId { get; set; }
        public string Url { get; set; }
        public IList<Machine> MachineList { get; set; }
    }   
}
