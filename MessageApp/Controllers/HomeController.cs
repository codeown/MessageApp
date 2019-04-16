using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MessageApp.Models;

namespace MessageApp.Controllers
{
    public class HomeController : Controller
    {
        MessageContext messageContext = new MessageContext();  //Создаем новый объект для для обращения к БД (контекст данных)

        public ActionResult Index()
        {
            return View();
        }

        //===========================

        public ActionResult AllUsers()
        {
            //Извлекаем данные из  таблицы Users
            IEnumerable<User> users = messageContext.Users;

            //Записываем Users в динамическое свойство ViewBag
            ViewBag.Users = users;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        [HttpGet]
        public ActionResult Registration()
        {                      
            return View();
        }

        [HttpPost]
        public string Registration(User user)
        {
            //Добавляем информацию о регистрации в БД
            messageContext.Users.Add(user);

            messageContext.SaveChanges();
            return $"Спасибо, {user.Name}, вы зарегистрированы";
        }
    }
}