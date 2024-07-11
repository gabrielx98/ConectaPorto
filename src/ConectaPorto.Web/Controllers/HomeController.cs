using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
