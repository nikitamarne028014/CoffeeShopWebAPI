using CoffeeShopWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Services.Abstractions
{
    public interface IReservationService
    {
        public Reservation BookReservation(Reservation reservation);
    }
}
