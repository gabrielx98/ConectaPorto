using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Web.Controllers
{
    public class PortosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
