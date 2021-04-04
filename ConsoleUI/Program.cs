using Busines.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

            private static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());

                foreach (var car in carManager.GetCarDetails())
                {
                    Console.WriteLine(car.CarManager + "/" + car.BrandName);
                }

            }
        
    }
}


            




        }
    }
}
