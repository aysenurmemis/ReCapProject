using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretes
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand,CarContext>, IBrandDal
    {
       
    }
}
