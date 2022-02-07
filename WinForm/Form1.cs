using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using MaterialSkin;
using BioMetrixCore;
using WinForm.Models;
using System.IO;
using Newtonsoft.Json;

namespace WinForm
{


    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager skinManager;
        //private var client

        //private IList<Machine> machines = new List<Machine>();


        DeviceManipulatorNew manipulator = new DeviceManipulatorNew();
        //private IList<ZkemClientNew> clients = new List<ZkemClientNew>();
        //public ZkemClientNew objZkeeper;
        private bool isDeviceConnected = false;

        public bool IsDeviceConnected
        {
            get { return isDeviceConnected; }
            set
            {
                isDeviceConnected = value;
            }
        }


        public Form1()
        {
            InitializeComponent();
            //machineList.ColumnCount = 4;
            //machineList.Columns.Add("No", "No");
            //machineList.Columns.Add("Machine No", "Machine");
            //machineList.Columns.Add("IP", "IP");
            //machineList.Columns.Add("Port ","Port");
            //machineList.Columns.Add("Status", "Status");

            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.BlueGrey900, Primary.Blue500, Accent.Orange700, TextShade.WHITE);
            ConnectToMachine();
        }

        private void connectMachineClick(object sender, EventArgs e)
        {
            ConnectToMachine();
        }

        private void ConnectToMachine()
        {
            try
            {
                var currentDirectory = Directory.GetCurrentDirectory();
                var settingInfo = JsonConvert.DeserializeObject<SettingInfo>(File.ReadAllText(@"settingInfo.json"));
                foreach (var machine in settingInfo.MachineList)
                {
                    var objZkeeper = new ZkemClientNew(RaiseDeviceEvent);
                    objZkeeper.MachineNumber = machine.MachineNo;
                    machine.Status = objZkeeper.Connect_NetNew(machine.Ip, Convert.ToInt32(machine.Port), machine.MachineNo);
                    if (!machine.Status)
                    {
                        continue;
                    }
                    machine.MachineInfo = manipulator.FetchDeviceInfo(objZkeeper, machine.MachineNo);
                    objZkeeper.MachineCode = machine.MachineInfo;
                    //manipulator.SyncData(objZkeeper, machine.MachineNo);
                    //machines.Add(machine);
                    //clients.Add(objZkeeper);
                }

                //message.Text = "Successfully Connected!";
                machineList.DataSource = settingInfo.MachineList;
            }
            catch (Exception e)
            {
                message.Text = e.Message;
            }


        }


        //private void pushDataBl()
        //{
        //    var machine = new Machine
        //    {
        //        Ip = ipText.Text,
        //        Port = portText.Text,
        //        //Status = true
        //    };

        //    //machines.Add(machine);
        //    var ConnectOrDisconnect = machine.Status ? "Disconnect" : "Connect";
        //    string[] row = { $"{machineList.Rows.Count}", $"", $"{machine.Ip}", $"{machine.Port}", $"{ConnectOrDisconnect}", $"delete" };
        //    machineList.Rows.Add(row);

        //    //ListViewItem item = new ListViewItem();
        //    //item.SubItems.Add(machine.Ip.ToString());
        //    //item.SubItems.Add($"{machines.Count}");
        //    //item.SubItems.Add(machine.Ip.ToString());
        //    //item.SubItems.Add(machine.Port.ToString());
        //    //item.SubItems.Add(machine.Status.ToString());
        //    //machineList.Rows.Add(item);

        //}


        private void RaiseDeviceEvent(object sender, string actionType)
        {


        }
        private void SyncDataClick(object sender, EventArgs e)
        {

            DataSync();
        }

        private void DataSync()
        {
            try
            {
                
                
                //foreach (var client in clients)
                //{
                //    var i = 0;
                //    manipulator.SyncData(client, machines[i].MachineNo);
                //    i = i + 1;
                //}

            }
            catch (Exception)
            {

                throw;
            }
        }
        //private void machineList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    IList<ZkemClient> list = new List<ZkemClient>();
        //    if (e.ColumnIndex == 4)
        //    {
        //        if ((machineList.Rows[e.RowIndex].Cells[4].Value == "Connect"))
        //        {
        //            var client = new ZkemClient(RaiseDeviceEvent);
        //            list.Add(client);
        //            IsDeviceConnected = client.Connect_Net(ipText.Text, Convert.ToInt32(portText.Text));
        //            if (IsDeviceConnected)
        //            {
        //                string deviceInfo = manipulator.FetchDeviceInfo(client, 1);
        //                machineList.Rows[e.RowIndex].Cells[1].Value = deviceInfo;

        //                machineList.Rows[e.RowIndex].Cells[4].Value = "Disconnect";
        //                MessageBox.Show("Successfully Connected!");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Device not connect  Please Try again!");
        //                machineList.Rows[e.RowIndex].Cells[4].Value = "Connect";
        //            }
        //        }
        //        else if (machineList.Rows[e.RowIndex].Cells[4].Value == "Disconnect")
        //        {


        //            list[e.RowIndex].Disconnect();

        //            //objZkeeper.Disconnect();
        //            if (IsDeviceConnected)
        //            {
        //                string deviceInfo = manipulator.FetchDeviceInfo(list[e.RowIndex], 1);
        //                machineList.Rows[e.RowIndex].Cells[1].Value = deviceInfo;

        //                machineList.Rows[e.RowIndex].Cells[4].Value = "Disconnect";
        //                MessageBox.Show("Successfully Connected!");
        //            }
        //            else
        //            {
        //                MessageBox.Show("Device not connect  Please Try again!");
        //                machineList.Rows[e.RowIndex].Cells[4].Value = "Connect";
        //            }
        //        }

        //    }


        //    else if (e.ColumnIndex == 5)
        //    {
        //        if (!IsDeviceConnected)
        //        {
        //            //var row = machineList.Rows[e.RowIndex];
        //            machineList.Rows.RemoveAt(e.RowIndex);
        //            list.RemoveAt(e.RowIndex);
        //        }
        //        else
        //        {
        //            MessageBox.Show("Please disconnect First!");
        //        }

        //    }


        //}
    }


}
