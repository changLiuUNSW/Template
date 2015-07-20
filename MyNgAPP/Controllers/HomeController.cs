using System.Web.Http;
using System.Web.Mvc;

namespace MyNgAPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var apiExplorer = GlobalConfiguration.Configuration.Services.GetApiExplorer();
            return View(apiExplorer.ApiDescriptions);
        }
    }
}