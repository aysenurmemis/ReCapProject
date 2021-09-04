using Business.Concretes;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalAddTest();

        }
        private static void RentalAddTest()
        {
            RentalManager addRental = new RentalManager(new EfRentalDal());
            addRental.Add(new Rental
            {
                CarId = 2,
                CustomerId = 1,
                RentDate = new DateTime(2021, 07, 12, 10, 45, 00),
                ReturnDate = new DateTime(2021, 09, 17, 20, 30, 00)
            });
        }
    }
}
