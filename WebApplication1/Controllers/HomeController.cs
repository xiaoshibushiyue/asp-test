using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //内置对象 Request  Response Session Cookie Application Server

        //Request 是服务器接受客户端数据的
        //Request.QueryString["name"] get请求 return Content($"{Request.QueryString["name"]}-{Request.QueryString["id"]}-{Request.QueryString["age"]}");  http://localhost:64767/?name=11111&id=15
        //Request.Form post请求
        public ActionResult Index()
        {
            return Content($"{Request.QueryString["name"]}-{Request.QueryString["id"]}-{Request.QueryString["age"]}");
        }
        public ActionResult PostData()
        {
            return Content(Request.Form["loginname"]);
        }
        public ActionResult FileData()
        {
            Request.Files["file"].SaveAs(Request.MapPath("~/uploads/"+Request.Files["file"].FileName));
            return Content("ok");
        }
        public ActionResult ResponseData()
        {
            Response.Write("hello world");
            Response.Redirect("http://www.baidu.com");//重定向
            
            return Content("");
        }
        public ActionResult ResponseHeader()
        {
            Response.Headers["Hello"] = "world";
            return Content(Request.Headers["token"]);
        }
        //Session 会话 数据保存在服务器中 存储少量重量数据 比如账号
        //session 是一个键值对
        
        public ActionResult SessionData()
        {
          
            Session["user"] = Request.Form["user"];
            return Content("会话中的数据是:"+Session["user"]);
            
        }
        public ActionResult GetSession()
        {
            //Session 会话 数据保存在服务器中 存储少量重量数据 比如账号
           // Session.Clear();
            return Content("会话中的数据是:" + Session["user"]);

        }

        //cookie
        public ActionResult CookieSave()
        {
            //时效性
            Response.Cookies.Add(new HttpCookie("token")
            {
                Value = "asdgfhjgdsfafdgjsfdghkgdsf",
                Expires=DateTime.Now.AddDays(1)
            }); 
            return Content("ok");

        }
        public ActionResult CookieGet()
        {
           
            return Content(Request.Cookies["token"].Value);

        }
        public ActionResult Cookieclear()
        {

            //用过期的形式进行清理
            Response.Cookies.Add(new HttpCookie("token")
            {
                
                Expires = DateTime.Now.AddDays(-1)
            });
            return Content("ok");

        }
        //和session相对立，application 是整个项目共有的
        public ActionResult ApplicationData()
        {
            HttpContext.Application["user"] = "123";
            return Content("");

        }
        public ActionResult ApplicationGet()
        {
            
            return Content(HttpContext.Application["user"].ToString());

        }

        public ActionResult ServerDemo()
        {
            //转发路径不变，内容变化，但是不能转发外站的东西
            Server.Transfer("/WebForm1.aspx");
            return Content("");

        }
        public ActionResult ShowDemo()
        {
            
            return Content("这是内容");

        }
    }
}