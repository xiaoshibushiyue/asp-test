using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //一般存放非主要的数据
            ViewBag.Content = "这是Controller里面的数据";
            ViewBag.Name = 12;
            ViewBag.Age = 55;
            ViewData["Age"] = 444;//本质和上面一样,但是不能跨页面
            return View();
        }
        public void Demo()
        {
            TempData["Hello"] = "123";//一次读取就会被清空，可以跨页面
            Response.Redirect("~/Home/Demo2");
        }
        public ActionResult Demo2()
        {
            return View();
        }
        public ActionResult ShowData()
        {

            return View("ShowData2","_Layout1",new Student()
            {
                Id = 1,
                Name = "时",
                Age = 25
            }); ; 
        }
    }
}