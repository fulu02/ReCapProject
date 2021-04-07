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
            UserTest();

            CustomerTest();

            RentalTest();

            GetRentailDetailsTest();


            //BrandTest();
            //CarTest();
            //GetCarsById();
            //GetCarsByColorId();
            //AddedTest();
            //DeleteTest();
            //GetCarDetailsTest();





        }

        private static void RentalTest()

        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rentals { CustomerId = 1, CarId = 2, RentDate = DateTime.Now, ReturnDate = new DateTime(2021, 4, 6) });

            Console.WriteLine(result.Message);

        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.Add(new Customer { UserId = 1, CompanyName = "A Galeri" });

            Console.WriteLine(result.Message);
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.Add(new Users { FirstName = "Fatma", LastName = "Ulu", EMail = "fulu02@gmail.com", Password = "12345" });

            Console.WriteLine(result.Message);
        }

        private static void GetRentailDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetCarRentalDetails();

            if (result.Success)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.UserName + rental.RentDate + "\n " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.BrandId + brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Description + "\t\n" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result5 = carManager.GetCarDetails();

            foreach (var car in result5.Data)
            {
                Console.WriteLine(car.BrandName + "\n " + car.CarName + "\n " + car.ColorName + "\n " + car.DailyPrice + "");
            }
        }

        private static void DeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Delete(new Car { CarId = 1 });

            Console.WriteLine(result.Message);
        }

        private static void AddedTest()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Add(new Car { BrandId = 4, ColorId = 3, DailyPrice = 0, CarName = "None" });

            Console.WriteLine(result.Message);
        }

        private static void GetCarsByColorId()
        {

            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarsByColorId((1));

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.ColorId);
            }
        }

        private static void GetCarsById()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result1 = carManager.GetCarsByBrandId();

            foreach (var car in result1.Data)
            {
                Console.WriteLine(car.ModelYear + " " + car.Description + " " + car.CarName);
            }

            NotImplementedException();
        }
    }

}