using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _AboutPartial :  ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
