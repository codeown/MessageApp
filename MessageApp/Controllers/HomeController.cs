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
        

        public ActionResult Index()
        {            
            return View();
        }

        //===========================
        MessageContext messageContext = new MessageContext();  //Создаем новый объект для для обращения к БД
        public ActionResult AllUsers()
        {
            //Извлекаем данные из  таблицы Users
            IEnumerable<User> users = messageContext.Users;

            //Записываем Users в динамического свойство ViewBag
            ViewBag.Users = users;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Registration()
        {            
            return View();
        }
    }
}