using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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

        public static string GetHash(string password)
        {
            using (var hash = SHA1.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(x => x.ToString("X2")));
            }
        }


        [HttpPost("Autorization")]

        public string Autorization([FromBody] User imputUser)
        {
            // проверка на null

            imputUser.Password = GetHash(imputUser.Password);
            
                if (SearchRecordDB(imputUser.Name, imputUser.Password)==true)
                {
                    using (var vueJSTestDB = new VueJSTestContext())
                    {
                                      
                    return vueJSTestDB.Users.SingleOrDefault(user => user.Name == imputUser.Name && user.Password == imputUser.Password).ID.ToString();
                    }
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

            userRegistration.Password = GetHash(userRegistration.Password);

            var newUser = new User
            {
                Name = userRegistration.Name,
                Password = userRegistration.Password,
                Surname=userRegistration.Surname,
                Email=userRegistration.Email

            };

            using (var vueJSTestDB = new VueJSTestContext())
            {
                vueJSTestDB.Users.Add(newUser);
                vueJSTestDB.SaveChanges();
            }

            return "Пользователь " + newUser.Name + " добавлен в базу";
        }
       
 
        [HttpPost("Answer")]

        public User Answer([FromBody] User imputUser)
        {
            
            var vrUser = new User();
            using (var vueJSTestDB = new VueJSTestContext())
            {
            if (vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID ) != null)
                {
                 //up
                    vrUser.ID = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).ID;
                    vrUser.Name = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).Name;
                    vrUser.Surname = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).Surname;
                    vrUser.Email = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).Email;
                    return vrUser;
                }

            
            }
            
            

            return vrUser;
        }
        [HttpPost("AnswerEdit")]

        public string AnswerEdit([FromBody] User imputUser)
        {
            // HACK
            var vrUser = new User();
            using (var vueJSTestDB = new VueJSTestContext())
            {
                if (vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID) != null)
                {
                    return vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).ID.ToString();
                
                }

            }

            return "редактирование не возможно";
        }

        [HttpPost("AnswerDelete")]

        public string AnswerDelete([FromBody] User imputUser)
        {
            // HACK
            var vrUser = new User();
            using (var vueJSTestDB = new VueJSTestContext())
            {
                if (vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID) != null)
                {
                    vueJSTestDB.Users.Remove(vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID));
                    vueJSTestDB.SaveChanges();

                    return "Удаление успешно";
                }

            }

            return "нихрена";
        }

        [HttpPost("Edit")]

        public User Edit([FromBody] User imputUser)
        {

            var vrUser = new User();
            using (var vueJSTestDB = new VueJSTestContext())
            {
                if (vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID) != null)
                {
                    //up
                    vrUser.ID = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).ID;
                    vrUser.Name = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).Name;
                    vrUser.Surname = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).Surname;
                    vrUser.Email = vueJSTestDB.Users.SingleOrDefault(user => user.ID == imputUser.ID).Email;
                    return vrUser;
                }

                return vrUser;
            }

        }

        [HttpPost("Alteration_Edit")]

        public string Alteration_Edit([FromBody] User inputUser)
        {
            var vrUser = new User();
            using (var vueJSTestDB = new VueJSTestContext())
            {
                if (vueJSTestDB.Users.SingleOrDefault(user => user.ID == inputUser.ID) != null)
                {
                    vrUser = vueJSTestDB.Users.SingleOrDefault(user => user.ID == inputUser.ID);
                    if (vrUser != inputUser)
                    {
                        vrUser.Name = inputUser.Name;
                        vrUser.Surname = inputUser.Surname;
                        vrUser.Email = inputUser.Email;

                    }
                    vueJSTestDB.SaveChanges();
                    return vueJSTestDB.Users.SingleOrDefault(user => user.ID == inputUser.ID).ID.ToString(); ;
                }

                return "что-то пошло не так";
            }


            
        
        }

    }
}
