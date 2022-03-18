using Business.Abstract;
using Business.Concrete;
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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Update(new Rental
            {
                Id=10,
                CarId = 1,
                CustomerId=2,
                RentDate=rentalManager.GetById(10).Data.RentDate,
                ReturnDate=DateTime.Now
            }) ; 
        }
    }
}
