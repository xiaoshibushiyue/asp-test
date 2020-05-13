using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return Content("student");
        }
        public ActionResult List()
        {
            return View(new List<Student>
            {
                new Student()
                {
                    Id=1,
                    Name="张三",
                    Age=12
                },
                new Student()
                {
                    Id=12,
                    Name="张三wwww",
                    Age=12
                },
                new Student()
                {
                    Id=13,
                    Name="张三fsdf",
                    Age=12
                }
            });
        }
    }
}