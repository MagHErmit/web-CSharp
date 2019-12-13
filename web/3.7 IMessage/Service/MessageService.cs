using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._7_IMessage.Service
{
    public class MessageService
    {
        IMessageSender _sender;
        
        public MessageService(IMessageSender sender)
        {
            _sender = sender;
        }

        public string Send(HttpContext context)
        {
            return _sender.Send(context);
        }
    }
}
