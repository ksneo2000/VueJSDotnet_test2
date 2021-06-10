using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace VueJSDotnet_test2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextDataWriteController : ControllerBase
    {
       
       

        [HttpGet]
        public TextDataWrite Get()
        {
            using (var sr2 = new StreamReader("Resources\\Text_2.txt"))
            {
                string text = sr2.ReadToEnd();
                return new TextDataWrite
                {
                    TextDataWR = text,
                    TextDataData = DateTime.Today
                };
            }

            
        }
    }
}
