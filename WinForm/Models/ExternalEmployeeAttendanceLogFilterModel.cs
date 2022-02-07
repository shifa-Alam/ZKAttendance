using System;

namespace WindowsFormsApp1
{
    
    public class ExternalEmployeeAttendanceLogFilterModel
    {
        public long HrConfigId { get; set; }
        ////public long BranchId { get; set; }
        //public DateTime AttendanceTime { get; set; }
        //public bool State { get; set; }
        ////public bool IsMachine { get; set; }
        //public long MachineNo { get; set; }
        //public string MachineCode { get; set; }
        //public string EmployeeCode { get; set; }


        public long Id { get; set; }
        public long BranchId { get; set; }
        public long EmployeeId { get; set; }
        public DateTime? AttendanceTime { get; set; }
        public bool? State { get; set; }
        public bool? IsMachine { get; set; }
        public string MachineCode { get; set; }
        public long MachineNo { get; set; }
        public long? ShiftId { get; set; }
        public string Note { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}