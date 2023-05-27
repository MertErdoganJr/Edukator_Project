using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    
    public class MemberLayoutController : Controller
    {       
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult MemberSidebarPartial()
        {
            return PartialView();
        }
    }
}
