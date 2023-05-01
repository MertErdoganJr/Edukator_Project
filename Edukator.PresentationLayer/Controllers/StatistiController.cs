using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
    public class StatistiController : Controller
    {
        public IActionResult Index()
        {
            Context context = new Context();
            ViewBag.totalCategory = context.Categories.Count();
            ViewBag.totalCourse = context.Courses.Count();
            ViewBag.totalCoursePrice = context.Courses.Sum(x => x.Price);
            ViewBag.getAlgoritmaProgramlamaCoursePrice = context.Courses.Where(x => x.Title == "Algoritma Eğitimi").Select(y => y.Price).FirstOrDefault();

            ViewBag.avgReview = context.Courses.Average(x => x.Review);
            ViewBag.getOver30Price = context.Courses.Where(x => x.Price > 30).Count();
            ViewBag.lastCoursePrice = context.Courses.Where(x => x.CourseID == 9).Select(y => y.Price).FirstOrDefault();
            ViewBag.getTitleByCourseID2 = context.Courses.Where(x => x.CategoryID == 2).Select(y => y.Title).FirstOrDefault();

            ViewBag.softwareCourseCount = context.Courses.Where(x => x.CourseID == (context.Categories.Where(y => y.CategoryName == "Yazılım").Select(z => z.CategoryID).FirstOrDefault())).Count();
            ViewBag.maxCoursePrice = context.Courses.Max(x => x.Price);
            ViewBag.minCoursePrice = context.Courses.Min(y => y.Price);
            ViewBag.mostExpensiveCourse = context.Courses.Where(x => x.Price == (context.Courses.Max(y => y.Price))).Select(z => z.Title).FirstOrDefault();

            ViewBag.lastCourseTitle = context.Courses.Where(x => x.CourseID == (context.Courses.Max(x => x.CourseID))).Select(y => y.Title).FirstOrDefault();
            ViewBag.avgPriceForSoftwareCourse = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(x => x.CategoryName == "Yazılım").Select(x => x.CategoryID)).FirstOrDefault()).Average(x=>x.Price);
            ViewBag.last3CourseTotalPrice = context.Courses.OrderByDescending(x => x.CourseID).Take(3).Sum(x => x.Price);
            ViewBag.getCourseCategorySoftwareAndReviewMore9Score = context.Courses.Where(x => x.CategoryID == (context.Categories.Where(x => x.CategoryName == "Yazılım").Select(x => x.CategoryID).FirstOrDefault()) && x.Review >= 9).Select(x => x.Title).FirstOrDefault();
            

            return View();
        }
    }
}
