using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork{
    public class Endpoint{
        public string SerialNumber { get; set; }
        public int MeterModelID { get; set; }
        public int MeterNumber { get; set; }
        public string MeterFirmwareVersion { get; set; }
        public int SwitchState { get; set; }
    }
}
