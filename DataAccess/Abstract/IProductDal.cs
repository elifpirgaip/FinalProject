﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Not: Interface'lerin "operasyonları" Public'tir.
    public interface IProductDal:IEntitiyRepository<Product>
    {
        
    }
}
