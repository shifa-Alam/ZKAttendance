using System;

namespace WindowsFormsApp1
{
    
    public class ExternalEmployeeAttendanceLogModel
    {
        public long HrConfigId { get; set; }
        //public long BranchId { get; set; }
        public DateTime AttendanceTime { get; set; }
        public bool State { get; set; }
        //public bool IsMachine { get; set; }
        public int MachineNo { get; set; }
        public string MachineCode { get; set; }
        public string AttendanceCode { get; set; }
    }
}