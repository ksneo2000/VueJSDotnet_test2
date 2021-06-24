using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace VueJSDotnet_test2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        [HttpPost("Autorization")]

        public string Autorization([FromBody] User user)
        {
            return "она живая";

        }

        [HttpPost("Registration")]

        public IActionResult Registration([FromBody] User user)
        {

            using (var VueJSTestDB = new VueJSTestContext())
            {
                VueJSTestDB.Users.Add(user);
                VueJSTestDB.SaveChanges();

                
            }

            return Ok(user);
            
        }

    }
}
