using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._7_IMessage
{
    public interface IMessageSender
    {
        public string Send(HttpContext context);
    }
    public class EmailMessageSender : IMessageSender
    {
        public string Send(HttpContext context)
        {
            if(context.Session.Keys.Contains("text"))
            {
                return context.Session.GetString("text");
            }
            context.Session.SetString("text", "text in session");
            return "text empty";
        }
    }
    public class SmsMessageSender : IMessageSender
    {
        public string Send(HttpContext context)
        {
            if(context.Request.Cookies.Keys.Contains("text"))
            {
                return context.Request.Cookies["text"];
            }
            context.Response.Cookies.Append("text", "text in cookies");
            return "text empty";
        }
    }
}
