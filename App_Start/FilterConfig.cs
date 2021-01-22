using System.Web;
using System.Web.Mvc;

namespace mvcDEMO
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }

    public class ErrorFilter: HandleErrorAttribute
    {
        public override void OnException(ExceptionContext filterContext)
        {
            //這邊可以添加Error之後的程式碼
        }
    }
}
