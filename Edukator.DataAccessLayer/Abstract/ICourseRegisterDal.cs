﻿using Edukator.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseRegisterDal : IGenericDal<CourseRegister>
    {
        List<CourseRegister> CourseRegisterListWithCoursesAndUser();
        List<CourseRegister> CourseRegisterListWithCourseByUser(int id);
    }
}
