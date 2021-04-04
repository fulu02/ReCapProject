using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Brand> _cars;

        public int BrandID { get; private set; }
        public object ToList { get; private set; }

        public InMemoryCarDal()
        {
            _cars = new List<Brand> {

                new Car{CarID=1, BrandID=1, CarName="Passat", ColorID=1, DailyPrice=350, Description="Manuel", ModelYear=2018},
                 new Car{CarID=2, BrandID=1, CarName="Jetta", ColorID=2, DailyPrice=300, Description="Otomatik Vites", ModelYear=2017},
                  new Car{CarID=3, BrandID=1, CarName="Golf", ColorID=1, DailyPrice=250, Description="Manuel", ModelYear=2016},
                  new Car{CarID=4, BrandID=1, CarName="Polo", ColorID=3, DailyPrice=150, Description="Otomatik Vites", ModelYear=2019},
                  new Car{CarID=5, BrandID=1, CarName="Tiguan", ColorID=2, DailyPrice=400, Description="Otomatik Vites", ModelYear=2018},


            };
        }
        public void Add(Brand car)
        {
            _cars.Add(car);
        }

        public void Delete(Brand car)
        {
            Brand carToDelete;

            carToDelete = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            _cars.Remove(carToDelete);
        }

        public List<Brand> GetAll()
        {
            return _cars;
        }

        public void Update(Brand car)
        {
            Brand carToUpdate = _cars.SingleOrDefault(c => c.CarID == car.CarID);
            carToUpdate.CarName = car.CarName;
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
       

        public List<Brand> GetByID(int CarID)
        {
            return (List<Brand>)_cars.Where(c => c.BrandID == BrandID);
        }
    }
}








