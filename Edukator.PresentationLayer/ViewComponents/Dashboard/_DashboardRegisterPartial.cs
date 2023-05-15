using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Dashboard
{
    public class _DashboardRegisterPartial : ViewComponent
    {
        private readonly ICourseRegisterService _courseRegisterService;

        public _DashboardRegisterPartial(ICourseRegisterService courseRegisterService)
        {
            _courseRegisterService = courseRegisterService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseRegisterService.TCourseRegisterListWithCoursesAndUser();
            return View(values);
        }
    }
}
