using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
    public interface IBrandService
    {

        List<Brand> GetAll();
        Brand GetByID(int brandId);
    }
}
