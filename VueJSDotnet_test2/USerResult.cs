using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;



namespace VueJSDotnet_test2
{
    public class USerResult : ActionResult
    {
        private string UserReply;
        public USerResult (string reply)
        {
            UserReply = reply;
        }

        public override async Task ExecuteResultAsync(ActionContext context)
        {
            string fullHtmlCode = UserReply;
            
            await context.HttpContext.Response.WriteAsync(fullHtmlCode);
        }
    }
}
