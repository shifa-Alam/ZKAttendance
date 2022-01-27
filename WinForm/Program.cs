using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm.Models;

namespace WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var currentDirectory = Directory.GetCurrentDirectory();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var s = JsonConvert.DeserializeObject<SettingInfo>(File.ReadAllText(currentDirectory + "\\" + "settingInfo.json"));

            Application.Run(new Form1());
        }
    }
}
