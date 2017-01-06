using System.Web;
using System.Web.Mvc;

namespace Nina_Aulia_Ramadhani_27_XI_RPL_4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
