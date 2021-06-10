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
        [HttpGet]
        // поменять на post

        public USerResult  Get (string name, string password)
        {
            // написать проверку login и password гомно или нет
            if (name == "a")
            {
                return new USerResult("<h1>you write_ A</h1>");
            }
            if (name == null)
            {
                return new USerResult("<h1>you are not WRITE_</h1>");
            }

            using (StreamWriter sw = new StreamWriter("Resources\\User.txt"))
            {
                //!ВЫПОНИЛ КАК МОГ создать экземпляр User, серилизовать его и сохранить полученную строку его в файл
                var user = new User
                {
                    Name = name,
                    Password = password

                };
                string jsonString = JsonSerializer.Serialize<User>(user);
                sw.WriteLine(jsonString);
            }
            return new USerResult("<h1>SAVE OKKK!!!</h1>");

        }
    }
}
