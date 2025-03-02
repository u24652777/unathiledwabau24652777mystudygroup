using System.Web;
using System.Web.Mvc;

namespace unathiledwabau24652777mystudygroup
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
