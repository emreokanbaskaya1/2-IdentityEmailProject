using Microsoft.AspNetCore.Mvc;

namespace IdentityEmailApp.Controllers
{
    public class MainLayoutController : Controller
    {
        public IActionResult Index()
        {
            // Layout dosyası model gerektirmez
            return View();
        }
    }
}
