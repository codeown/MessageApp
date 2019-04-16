using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MessageApp.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<MessageContext>  //При запуске каждый раз пересоздает БД заново
    {
        protected override void Seed(MessageContext context)
        {
            context.Users.Add(new User() { Name = "Владимир", Email = "some1@ya.ru", Password = "123"});//Id должно присвоится автоматически при добавлении строки в таблицу
            context.Users.Add(new User() { Name = "Евгений", Email = "some2@ya.ru", Password = "456" });
            context.Users.Add(new User() { Name = "Дмитрий", Email = "some3@ya.ru", Password = "789" });
            context.Users.Add(new User() { Name = "Иван", Email = "some4@ya.ru", Password = "101" });

            context.Messages.Add(new Message() { Boby = "Тестовое сообщение1" });//Id должно присвоится автоматически
            context.Messages.Add(new Message() { Boby = "Тестовое сообщение2" });
            context.Messages.Add(new Message() { Boby = "Тестовое сообщение3" });
            context.Messages.Add(new Message() { Boby = "Тестовое сообщение4" });

            //context.SendMessages.Add(new SendMessage() { MessageId = 3, DateTime = DateTime.Now, FromUser = 1, ToUser = 4 }); //Конечно не верно использовать DateTime.Now, но времени разбираться в правильном формате не было
            //context.SendMessages.Add(new SendMessage() { MessageId = 1, DateTime = DateTime.Now, FromUser = 4, ToUser = 3 });
            //context.SendMessages.Add(new SendMessage() { MessageId = 4, DateTime = DateTime.Now, FromUser = 2, ToUser = 1 });
            //context.SendMessages.Add(new SendMessage() { MessageId = 2, DateTime = DateTime.Now, FromUser = 3, ToUser = 2 });

            base.Seed(context);
        }
    }
}