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

        public string TextInput ([FromBody] Text text)
        {


            var newText = new Text
            {
                Name = text.Name,
                MyСontent = text.MyСontent

            };
            using (var vueJSTestDB = new VueJSTestContext())
            {
                vueJSTestDB.Texts.Add(newText);
                vueJSTestDB.SaveChanges();
            }


            return "у меня получилось";
        }


    }
}
