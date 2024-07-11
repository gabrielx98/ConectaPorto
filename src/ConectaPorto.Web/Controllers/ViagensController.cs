using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Web.Controllers
{
    public class ViagensController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
