using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using WinForm.Models;

namespace WinForm.Service
{
    class ServerService : IServerService
    {

        public async Task SaveRangeAsync(IList<ExternalEmployeeAttendanceLogModel> logs)
        {

            try
            {

                if (logs == null) throw new ArgumentNullException(nameof(logs));

                var baseUrl = string.Empty;
                var settingInfo = JsonConvert.DeserializeObject<SettingInfo>(File.ReadAllText(@"settingInfo.json"));

                if (settingInfo == null) throw new Exception("Setting File not found");
                baseUrl = settingInfo.Url;

                foreach (var log in logs)
                {
                    log.HrConfigId = settingInfo.HrConfigId;
                }

                var json = JsonConvert.SerializeObject(logs);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var response = await client.PostAsync("api/ExternalHrAttendance/SaveEmployeeAttendanceLogRangeAsync", new StringContent(json, Encoding.UTF8, "application/json"));

                if (response != null)
                {
                    Console.WriteLine(response.ToString());
                }

            }
            catch (Exception)
            {

                //throw;
            }
        }

        public async Task<ExternalEmployeeAttendanceLogModel> FindLastLogByMachineNo(ExternalEmployeeAttendanceLogFilterModel filter)
        {

            try
            {

                var baseUrl = string.Empty;
                var settingInfo = JsonConvert.DeserializeObject<SettingInfo>(File.ReadAllText(@"settingInfo.json"));

                if (settingInfo == null) throw new Exception("Setting File not found");
                baseUrl = settingInfo.Url;

                filter.HrConfigId = settingInfo.HrConfigId;

                var json = JsonConvert.SerializeObject(filter);

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsync("api/ExternalHrAttendance/FindLastLogByMachineNoAsync", new StringContent(json, Encoding.UTF8, "application/json"));
                var contentString = response.Result.Content.ReadAsStringAsync().Result;
                var responseData = JsonConvert.DeserializeObject<ExternalEmployeeAttendanceLogModel>(contentString);

                return responseData;


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
                return null;
            }
            

        }
    }
}
