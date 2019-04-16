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
        MessageContext messageContext = new MessageContext();  //Добавляем для обращения к БД

        public ActionResult Index()
        {            
            return View();
        }
        
        //===========================
        public ActionResult About()
        {
            //Извлекаем данные из  таблицы Users
            IEnumerable<User> users = messageContext.Users;

            //Записываем Users в динамического свойство ViewBag
            ViewBag.Users = User;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}