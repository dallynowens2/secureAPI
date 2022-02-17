using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secureAPI.Models
{
    public class UserInfo
    {
        public int id { get; set; }
        public string userName {get; set;}
        public string password { get; set; }
        public byte[] salt { get; set; }
    }
}
