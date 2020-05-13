using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        //viewResult 返回相应的视图
        //contentResult 返回相应的字符串
        // GET: Home

            //改成private 就不可以访问了
        public ActionResult Index()
        {
            return View();
        }
        [NonAction]
        public ActionResult Demo()
        {
           // Response.Redirect();
            return Redirect("http://www.baidu.com");
        }
        [ActionName("ddd")]
        public ActionResult DemoAction()
        {
            // Response.Redirect();
            return RedirectToAction("Index");
        }
        public ActionResult DemoAction2()
        {
            // Response.Redirect();
            return RedirectToAction("Index","Student");//根据路由进行重定义跳转
        }
        public ActionResult Getfile()
        {

            return File(@"E:\下载\程序.png","image/jpg");
        }
        private static string basepath= @"E:\uploads";
        public ActionResult Uploadfile(HttpPostedFileBase file)
        {
            //file.ContentLength
            var filename = DateTime.Now.Ticks + file.FileName;
            file.SaveAs(basepath+@"\"+filename);
            return Content(filename);
        }
        public ActionResult GetJson()
        {
            return Json(new { id=1,name="shi"},JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetCode()
        {
            return new HttpStatusCodeResult(System.Net.HttpStatusCode.NotFound);
        }
        /// <summary>
        /// 返回部分页面（类似于组件）
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GetPartial()
        {
            return PartialView();
        }
    }
}