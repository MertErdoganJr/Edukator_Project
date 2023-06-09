﻿using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _CoursePartial :ViewComponent
    {
        private readonly ICourseService _courseService;

        public _CoursePartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetCoursesWithoutCategories();
            return View(values);
        }
    }
}
