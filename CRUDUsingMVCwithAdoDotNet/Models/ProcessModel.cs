using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WassenBurgMedical.Models
{
    public class ProcessModel
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MachineNr { get; set; }
        public int MachineId { get; set; }
        public string MachineTypeSerial { get; set; }
        public string Process { get; set; }
        public string ProcessTime { get; set; }
        public string SensorData { get; set; }
        public string OnlineFrom { get; set; }
        public string searchData { get; set; }
    }
}