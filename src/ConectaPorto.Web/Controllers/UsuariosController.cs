using Microsoft.AspNetCore.Mvc;

namespace ConectaPorto.Web.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
