using System.Web.Mvc;
using AdventureWorks.Web.Filters;

namespace AdventureWorks.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
	        filters.Add(new AiHandleErrorAttribute());
            filters.Add(new HandleErrorAttribute());
        }
    }
}
