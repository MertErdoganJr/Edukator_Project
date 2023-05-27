using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
