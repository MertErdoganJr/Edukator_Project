﻿using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>,IAboutDal
    {
    }
}