﻿using Microsoft.AspNetCore.Mvc;
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
    public class TextWriteController : ControllerBase
    {
       
       

        [HttpGet]
        public TextWrite Get()
        {
            using (var sr = new StreamReader("Resources\\Text_1.txt"))
            {
                string text = sr.ReadToEnd();
                return new TextWrite
                {
                    TextWR = text

                };
            }

            
        }
    }
}
