using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<CarRentalDetailDto> GetCarRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on re.CarId equals ca.Id

                             join cus in context.Customers
                             on re.CustomerId equals cus.CustomerId
                             
                             join b in context.Brands
                             on ca.BrandId equals b.BrandId

                             join us in context.Users
                             on cus.UserId equals us.UserId

                             select new CarRentalDetailDto
                             {
                                 RentalId = re.RentalId,
                                 CarName = b.BrandName,
                                 CustomerFirstName = us.FirstName + " " + us.LastName,
                                 UserName = us.FirstName + " " + us.LastName,
                                 DailyPrice = ca.DailyPrice,
                                 RentDate = re.RentDate,
                                 ReturnDate = re.ReturnDate,

                             };
                return result.ToList();
            }
        }
    }
}
