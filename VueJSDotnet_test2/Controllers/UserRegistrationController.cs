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
        private string searchRecordBD()
        {
            return "а как?";
        }
        [HttpPost("Autorization")]

        public string Autorization([FromBody] User imputUser)
        {

            using (var vueJSTestDB = new VueJSTestContext())
            {
                if (vueJSTestDB.Users.SingleOrDefault(user => user.Name == imputUser.Name && user.Password == imputUser.Password) != null)
                {
                    return "Пользователь " + imputUser.Name + " приветствуем тебя";
                }
                
            }
            return "она живая";

        }

        [HttpPost("Registration")]

        public string Registration([FromBody] UserRegistration userRegistration)
        {
          
            if (userRegistration.Password != userRegistration.Password2)
            {
                return "Введеные пароли не совпадают";
            }

            var newUser = new User
            {
                Name = userRegistration.Name,
                Password = userRegistration.Password
            };

            using (var vueJSTestDB = new VueJSTestContext())
            {
                vueJSTestDB.Users.Add(newUser);
                vueJSTestDB.SaveChanges();
            }

            return "Пользователь " + newUser.Name + " добавлен в базу";
        }

                           
                       

            
        

    }
}
