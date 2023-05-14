using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _ReferencesPartial : ViewComponent
    {
        private readonly IReferenceService _referenceService;

        public _ReferencesPartial(IReferenceService referenceService)
        {
            _referenceService = referenceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _referenceService.TGetList();
            return View(values);
        }
    }
}
