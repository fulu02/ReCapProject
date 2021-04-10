using Busines.Abstract;
using Busines.ValidationRules.FluentValidation;
using Core.Crosscuttingconcerns.Validation;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using FluentValidation;
using RestSharp.Validation;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Text;
using static Core.Results.ErrorDataResult;

namespace Busines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        private object car;

        public object Mesagges { get; private set; }

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }



        [Validate]
        public IResult Add(Car Car)
        {
           
            ValidationTool.Validate(new CarValidator(), car);

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
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == Id));
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

        public IDataResult<List<Car>> GetAllBrandId(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
    
    


            
        
    

