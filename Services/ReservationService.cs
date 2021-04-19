using CoffeeShopWebAPI.Data;
using CoffeeShopWebAPI.Models;
using CoffeeShopWebAPI.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Services
{
    public class ReservationService : IReservationService
    {
        private readonly CoffeeShopDBContext _dbContext;

        public ReservationService(CoffeeShopDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Reservation BookReservation(Reservation reservation)
        {
            var BookingDetails = _dbContext.Reservations.Add(reservation);
            _dbContext.SaveChanges();
            return BookingDetails.Entity;
        }
    }
}
