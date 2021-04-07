using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IRentalDal : IEntityReposity<Rentals>
    {
        List<CarRentalDetailDto> GetCarRentalDetailDtos(Expression<Func<Rentals, bool>> filter = null);
        Rentals GetAll();
        Rentals Get(Func<object, bool> p);
        void Add(Rentals rental);
        void Delete(Rentals rental);
        void Update(Rentals rental);
    }
}
