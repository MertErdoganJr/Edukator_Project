using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Controllers
{
    public class AboutPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
