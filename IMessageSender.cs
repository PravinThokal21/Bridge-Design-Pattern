using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Design_Pattern
{
    internal interface IMessageSender
    {
        public void SendMessage(string subject, string body);
    }
}
