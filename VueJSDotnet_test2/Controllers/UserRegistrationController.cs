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

        public string Registration([FromBody] User_Reg user_Reg)
        {
          
            if (user_Reg.Password != user_Reg.Password2)
            {
                return "Введеные пароли не совпадают";
            }

            var User1 = new User();
            User1.Name = user_Reg.Name;
            User1.Password = user_Reg.Password;
            
            using (var VueJSTestDB = new VueJSTestContext())
            {
                VueJSTestDB.Users.Add(User1);
                VueJSTestDB.SaveChanges();
            }

            return "Пользователь " + User1.Name + " добавлен в базу";
        }

                           
                       

            
        

    }
}
