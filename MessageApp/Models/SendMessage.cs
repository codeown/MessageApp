using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MessageApp.Models
{
    public class SendMessage
    {        
        public int SendMessageId { get; set; } //Id сообщения
        public DateTime DateTime { get; set; }
        public int FromUser { get; set; }
        public int ToUser { get; set; }
    }
}