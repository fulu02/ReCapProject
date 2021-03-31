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
        public CarManager(ICarDal carDal)
        {
            _carDal = CarDal;

        }
    


             public List<Car> GetAll()
            {
                   return _carDal.GetAll();
            }
     }
}
    
    


            
        
    

