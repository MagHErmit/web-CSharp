using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._7_IMessage
{
    public class EmailMessageSender : IMessageSender
    {
        public string Send()
        {
            return "Sent by Email";
        }
    }
}
