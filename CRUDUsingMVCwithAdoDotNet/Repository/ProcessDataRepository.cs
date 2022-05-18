using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WassenBurgMedical.Models;
namespace WassenBurgMedical.Repository
{
    public class ProcessDataRepository
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);

        }

     

        public List<ProcessModel> GetAllProcessData()
        {
            List<ProcessModel> ProcessList =new List<ProcessModel>();
            ProcessList.Add(new ProcessModel { 
                CustomerId=3123, 
                CustomerName="UMC Utrecht", 
                MachineNr="UMC-342", 
                MachineId=21, 
                MachineTypeSerial="EWD220;33819830413901", 
                Process="WashDisWash", 
                ProcessTime="Start:2019 - 13 - 02 21:13:11.328; End: 2019 - 13 - 02 22:03:00.327", 
                SensorData="WaterTemp: celcius: 23; Pump10: off; Pump5: on; DrainSensor:off; WaterLevel: ml - 432;", 
                OnlineFrom="27 - 07 - 2014 10:02:37" 
            });
            ProcessList.Add(new ProcessModel
            {
                CustomerId = 2954,
                CustomerName = "UMC Utrecht",
                MachineNr = "UMC-536J",
                MachineId = 22,
                MachineTypeSerial = "EWD440;4813850810101",
                Process = "WashDis",
                ProcessTime = "Start:2019-20-04 20:10:04.129;End:2019-20-04 21:29:20.734",
                SensorData = "WaterTemp:celcius:25;Pump10:on;Pump5:off;DrainSensor:off;WaterLevel:ml-382;",
                OnlineFrom = "08-09-2017 18:12:43"
            });
            ProcessList.Add(new ProcessModel
            {
                CustomerId = 1224,
                CustomerName = "AMC",
                MachineNr = "AMC1-32",
                MachineId = 21,
                MachineTypeSerial = "EWD440-PT;36849839827301",
                Process = "Dis",
                ProcessTime = "Start:2019-12-09 23:54:12.349;End:2019-12-09 23:59:14.343",
                SensorData = "WaterTemp:celcius:22;Pump10:off;Pump5:on;DrainSensor:on;WaterLevel:ml-30;",
                OnlineFrom = "29-06-2016 16:55:02"
            });

            return ProcessList;

        }
        public List<ProcessModel> SearchProcessData(List<ProcessModel>DataList,string searchData)
        {
            List<ProcessModel> ProcessList = new List<ProcessModel>();
            ProcessList = DataList.Where(x => x.CustomerName.ToLower() == searchData.ToLower() || x.SensorData.ToLower().Contains(searchData.ToLower())).ToList();
            return ProcessList;
        }

        }
}