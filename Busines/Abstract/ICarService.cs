using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Abstract
{
   public interface ICarService
    {
        List<Brand> GetAll();
        List<Brand> GetCarsByBrandId(int Id);
        List<Brand> GetCarsByCarName(int Id );
        List<Brand> GetCarsByColorId(decimal min, decimal max);
        List<CarDetailDto> GetCarDetailDtos();
    }
}
