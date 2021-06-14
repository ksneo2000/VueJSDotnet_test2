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
        [HttpPost]
        
        public void Post12 ([FromBody] User user)
        {
             using(var VueJSTestDB = new VueJSTestContext())
            {
                VueJSTestDB.Users.Add(user);
                VueJSTestDB.SaveChanges();

                var x = VueJSTestDB.Users.Where(user=>user.Name=="123");
            }


            
        }
  }
}
