using System.Web;
using System.Web.Mvc;

namespace Lynda_Identity_Course_.NET
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
