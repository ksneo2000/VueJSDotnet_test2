using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueJSDotnet_test2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextController : ControllerBase
    {
        [HttpPost("TextInput")]

        public string TextInput([FromBody] Text textinput)
        {
            //Функция получает экземпляр Text из FrontTend и создает новую запись в 
            //базе данных

            var newText = new Text
            {
                Name = textinput.Name,
                СonText = textinput.СonText

            };
            using (var vueJSTestDB = new VueJSTestContext())
            {
                vueJSTestDB.Texts.Add(newText);
                vueJSTestDB.SaveChanges();
            }


            return "Текст успешно загружен";
        }


    }
}
