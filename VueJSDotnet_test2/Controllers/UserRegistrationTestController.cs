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
    public class UserRegistrationTestController : ControllerBase
    {
        [HttpPost]
        
        public IActionResult Post ([FromBody] User user)
        {
             using(var VueJSTestDB = new VueJSTestContext())
            {
                VueJSTestDB.Users.Add(user);
                VueJSTestDB.SaveChanges();

                var x = VueJSTestDB.Users.Where(user=>user.Name=="123");
            }

/*           using (StreamWriter sw = new StreamWriter("Resources\\User.txt"))
            {

                //!ВЫПОНИЛ КАК МОГ создать экземпляр User, серилизовать его и сохранить полученную строку его в файл

                string jsonString = JsonSerializer.Serialize<User>(user);
                sw.WriteLine(jsonString);

            }
*/
            return Ok(user);
        }
  }
}
