
using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace WinForm.Service
{
    interface IServerService
    {

        Task SaveRangeAsync(IList<ExternalEmployeeAttendanceLogModel> logs);

        Task<ExternalEmployeeAttendanceLogModel> FindLastLogByMachineNo(ExternalEmployeeAttendanceLogFilterModel filter);
    }
}
