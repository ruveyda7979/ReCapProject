﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapDbContext context = new ReCapDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join a in context.Colors
                             on c.ColorId equals a.ColorId
                             select new CarDetailDto { 
                                 Id = c.Id,
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = a.ColorName,
                                 DailyPrice = c.DailyPrice

                             };
                return result.ToList();




            }
        }
    }
}
