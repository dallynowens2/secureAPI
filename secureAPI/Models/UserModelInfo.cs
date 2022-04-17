using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace secureAPI.Models
{
    public class UserModelInfo
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string topping { get; set; }
        public string icecream { get; set; }
        public string visit { get; set; }
        public string nickname { get; set; }
        public string profilePictureName { get; set; }

        [NotMapped]
        public IFormFile profilePicture { get; set; }
    }
}
