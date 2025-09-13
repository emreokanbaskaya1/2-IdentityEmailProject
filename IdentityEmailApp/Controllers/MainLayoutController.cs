using Microsoft.AspNetCore.Mvc;

namespace IdentityEmailApp.Controllers
{
    public class MainLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
