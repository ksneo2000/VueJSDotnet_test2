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
        private bool SearchRecordDB(string login, string password)
        {
            using (var vueJSTestDB = new VueJSTestContext())
            {
                if (vueJSTestDB.Users.SingleOrDefault(user => user.Name == login && user.Password == password) != null)
                {
                    return true;
                }
            }
            return false;

        }
        [HttpPost("Autorization")]

        public string Autorization([FromBody] User imputUser)
        {
  // проверка на null
            
                if (SearchRecordDB(imputUser.Name, imputUser.Password)==true)
                {
                    return "Пользователь " + imputUser.Name + " приветствуем тебя";
                }
                
            
            return "Пользователя не зарегистрирован.";

        }

        [HttpPost("Registration")]

        public string Registration([FromBody] UserRegistration userRegistration)
        {
            if (SearchRecordDB(userRegistration.Name,userRegistration.Password)==true)
            {
                return "Пользователь уже заригистрирован";
            }
          
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
