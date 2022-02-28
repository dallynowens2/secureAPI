using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace secureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController: ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<string>> GetUserInfo()
        {
            string output = await $"systemctl status wg-quick@wg0.service".Bash();
            return output;
        }
    }
}
