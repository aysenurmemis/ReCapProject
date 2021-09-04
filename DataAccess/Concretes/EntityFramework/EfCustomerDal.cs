﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarContext>, ICustomerDal
    {
    }
}
