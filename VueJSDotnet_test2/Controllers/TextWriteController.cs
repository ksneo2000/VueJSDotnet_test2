using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VueJSDotnet_test2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TextWriteController : ControllerBase
    {
       

        [HttpGet]
        public IEnumerable<TextWrite> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new TextWrite
            {
                TestWR = "wddcde"
            });
        }
    }
}
