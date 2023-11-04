using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Network_Configurator
{
    public class NetworkInterfaceData
    {
        public string IPAddress { get; set; }
        public string SubnetMask { get; set; }

        public NetworkInterfaceData(string ipAddress, string subnetMask)
        {
            IPAddress = ipAddress;
            SubnetMask = subnetMask;
        }
    }
}
