using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfRentalDal : EfEntityRepositoryBase<Rentals, RentCarContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rentals, bool>> filter = null)
        {
            using (RentCarContext context = new RentCarContext())
            {
                var result = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cus in context.Customers
                             on r.CustomerId equals cus.CustomerId
                             join u in context.Users
                             on cus.UserId equals u.UserId
                             select new RentalDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarId = r.CarId,
                                 CompanyName = cus.CompanyName,
                                 UserName = u.FirstName + u.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };

                return result.ToList();
            }
        }
    }
}
