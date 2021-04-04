using Busines.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busines.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal CarDal)
        {
            _carDal = CarDal;

        }
    


             public List<Brand> GetAll()
            {
                   return _carDal.GetAll();
            }
        public List<Brand> GetCarsByBrandID(int Id)
        {
            return _carDal.GetAll(c => c.BrandID == Id);
        }
        public List<Brand> GetCarsByCarName(int Id) => _carDal.GetAll(c => c.CarName == "");
        public List<Brand> GetCarsByColorID(int Id)
        {
            return _carDal.GetAll(c => c.ColorID == Id);
        }
        public List<Brand> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        
    }
}
    
    


            
        
    

