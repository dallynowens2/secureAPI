using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secureAPI
{
    public class WireGuardInfo
    {
        public int id { get; set; }
        public string clientName { get; set; }
        public string ipAddress {get;set;}
        public string dateAdded {get;set;}
        public string allowedIpRange { get; set; }
        public string clientPublicKey { get; set; }
        public string clientPrivateKey { get; set; }
    }
}
