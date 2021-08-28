using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concretes
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from a in context.Cars
                             join b in context.Brands
                             on a.BrandId equals b.Id
                             join c in context.Colors
                             on a.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 CarName = a.Description,
                                 BrandName = b.Name,
                                 ColorName = c.Name,
                                 DailyPrice = a.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
