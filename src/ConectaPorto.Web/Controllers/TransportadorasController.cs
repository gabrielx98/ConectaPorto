using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Web.Controllers
{
    public class TransportadorasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
