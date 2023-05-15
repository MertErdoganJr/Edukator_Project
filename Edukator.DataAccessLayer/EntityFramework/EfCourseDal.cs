using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseDal : GenericRepository<Course>, ICourseDal
    {
        
        public List<Course> GetCoursesWithCategory()
        {
            Context context = new Context();
            return context.Courses.Include(x => x.Category).ToList();
        }

        public List<Course> GetCoursesWithoutCategories()
        {
            Context context = new Context();
            return context.Courses.Include(x => x.Category).ToList();
        }

        public List<Course> GetLast5Course()
        {
            Context context= new Context();
            return context.Courses.OrderByDescending(x => x.CourseID).Take(5).ToList();
        }
    }
}
