using Busines.Abstract;
using Busines.ValidationRules.FluentValidation;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Results.ErrorDataResult;

namespace Busines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public object Mesagges { get; private set; }

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car Car)
        {
            if (Car.CarName.Length < 2)
            {
                return new ErrorResult(Mesagges.CarNameInvalid);
            }

            var connect = new ValidationContext<Car>Car);
            CarValidator carValidator = new CarValidator();
            var result = carValidator.Validate(context);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }

            _carDal.Add(Car);

            return new SuccessResult(Mesagges.CarAdded);
        }
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Car>>(Mesagges.MaintenanceTime);
            }

            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Mesagges.CarsListed);
        }


      

        public IDataResult<Car> GetAllBrandID(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id);
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }
        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetailDtos());
        }

    }
}
    
    


            
        
    

