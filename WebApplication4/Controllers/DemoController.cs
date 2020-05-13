using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication4.Controllers
{
    public class DemoController : Controller
    {

        public ActionResult ShowForm()
        {
            return View();
        }
        // GET: Demo 从界面往控制器里面传递数据的方法
        [HttpGet]
        public ActionResult Index(string name)
        {
           // Request.QueryString["name"]
            return Content(name);
        }
        //[HttpPost]
        //public ActionResult Login(string name,string pwd)
        //{
        //    if (name=="admin"&&pwd=="123")
        //    {
        //        return Content("ok");
        //    }
        //    else
        //    {
        //        return Content("no");
        //    }
        //    return Content(name);
        //}
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Models.LoginviewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Email == "admin" && model.name == "123")
                {
                    return View(); 
                }
                else
                {
                    ModelState.AddModelError("","账号密码有误");
                    return View(model);
                }
            }

            ModelState.AddModelError("", "数据有误");
            return View(model);
        }
    }
}