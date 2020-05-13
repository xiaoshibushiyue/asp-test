using System.Web;
using System.Web.Mvc;

namespace WebApplication3
{
    /// <summary>
    /// 过滤器
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
