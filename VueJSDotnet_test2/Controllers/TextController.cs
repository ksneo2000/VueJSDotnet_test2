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
        [HttpPost("TextExport")]

        public Text TextExport([FromBody] Text textexport)
        {
            //Функция получает экземпляр Text из FrontTend и создает новую запись в 
            //базе данных

            var newText = new Text();
            using (var vueJSTestDB = new VueJSTestContext())
            {
                if (vueJSTestDB.Texts.SingleOrDefault(text => text.Name == textexport.Name) != null)
                {
                    //up
                    newText.ID = vueJSTestDB.Texts.SingleOrDefault(text => text.Name == textexport.Name).ID;
                    newText.Name = vueJSTestDB.Texts.SingleOrDefault(text => text.Name == textexport.Name).Name;
                    newText.СonText = vueJSTestDB.Texts.SingleOrDefault(text => text.Name == textexport.Name).СonText;
                    
                    return newText;
                }

            };
            
            return newText;
        }

    }
}
