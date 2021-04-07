using Busines.Abstract;
using Busines.Constant;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Busines.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        private IRentalDal rentalıd;

        public RentalManager(IRentalDal IRentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rentals Rental)
        {
            if (Rental.ReturnDate != null)
            {
                IRentalDal.Add(Rental);
                return new SuccessResult(Messages.RentalAdded)
            }

            return new ErrorResult(Messages.RentalNotAdded);

        }

        public IResult Delete(Rentals Rental)
        {
            _rentalDal.Delete(Rental);
            return new SuccessResult(Messages.Deleted);

        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<Rentals>(_rentalDal.GetAll());
        }

        public IDataResult<Rentals> GetById(int RentalId)
        {return new SuccessDataResult<Rentals>(_rentalDal.Get(r => r.RentalId == rentalId);
        }

        public IDataResult<List<CarRentalDetailDto>> GetCarRentalDetails(Expression<Func<Rentals, bool>> filter = null)
        {
            return new SuccessDataResult<List<CarRentalDetailDto>>(_rentalDal.GetCarRentalDetailDtos(filter), Messages.CarNotReturned);
        }

        public IResult Update(Rentals Rental)
        {
            _rentalDal.Update(Rental);
            return new SuccessResult(Messages.Updated);
        }
    }
}
