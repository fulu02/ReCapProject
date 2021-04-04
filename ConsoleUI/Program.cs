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
            CarTest();
            BrandTest();

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarManager + "/" + car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Messages);
            }

            private static void BrandTest()
            {
                BrandManager brandManager = new BrandManager(new EfBrandDal);
                foreach (var brand in brandManager.GetAll())
                {
                    Console.WriteLine(brand.BrandName);
                }
            }



        }

    }

        private static void BrandTest()
        {
            throw new NotImplementedException();
        }
    }
