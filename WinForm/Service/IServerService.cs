using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinForm.Service
{
    interface IServerService
    {

        Task  CallWebAPIAsync(string jsonData, string baseUrl);

        Task SaveRangeAsync(IList<ExternalEmployeeAttendanceLogModel> logs);

        Task<ExternalEmployeeAttendanceLogModel> FindLastLogByMachineNo(ExternalEmployeeAttendanceLogFilterModel filter);
    }
}
