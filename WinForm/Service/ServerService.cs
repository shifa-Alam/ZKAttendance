using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using WinForm.Models;

namespace WinForm.Service
{
    class ServerService:IServerService
    {
        //private string jsonData;

        public async Task CallWebAPIAsync(string jsonData, string baseUrl)
        {
            try
            {
                if (jsonData == null) throw new ArgumentNullException(nameof(jsonData));
                if (baseUrl == null) throw new ArgumentNullException(nameof(baseUrl));


               
            }
            catch (Exception )
            {
               
                throw;
            }
        }

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
            catch (Exception )
            {
               
                throw;
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

                var response =  client.PostAsync("api/ExternalHrAttendance/FindLastLogByMachineNoAsync", new StringContent(json, Encoding.UTF8, "application/json"));

                var contentString = response.Result.Content.ReadAsStringAsync().Result;
                //var resultString = response.Result;
                var info = JsonConvert.DeserializeObject<ExternalEmployeeAttendanceLogModel>(contentString);

                return info;


            }
            catch (Exception e)
            {
               Console.WriteLine(e);
                throw;
            }
        }
    }
}
