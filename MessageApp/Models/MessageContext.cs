using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MessageApp.Models
{
    public class MessageContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<User> Users { get; set; }
    }
}