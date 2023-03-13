using System.Web;
using System.Web.Mvc;

namespace LamChauTotTi_2080600714
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
