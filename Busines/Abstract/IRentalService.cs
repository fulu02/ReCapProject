using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Busines.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rentals Rental);
        IResult Update(Rentals Rental);
        IResult Delete(Rentals Rental);
       
        IDataResult<List<Rentals>> GetAll();
        IDataResult<Rentals> GetById(int RentalId);
        IDataResult<List<CarRentalDetailDto>> GetCarRentalDetails(Expression<Func<Rentals, bool>> filter = null);

    }
}
