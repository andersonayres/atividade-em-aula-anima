using System.Web;
using System.Web.Mvc;

namespace atividade_em_aula_anima
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
