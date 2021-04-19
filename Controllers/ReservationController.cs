using CoffeeShopWebAPI.Models;
using CoffeeShopWebAPI.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        
        // POST api/<ReservationController>
        [HttpPost]
        [ProducesResponseType(typeof(Reservation), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Reservation reservation)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var booking_details = _reservationService.BookReservation(reservation);

            if (booking_details != null)
                return Ok(new { statusCode = StatusCodes.Status201Created , message = "ThankYou! Your Reservation For " + booking_details.TotalPeople + " Members is Confirmed on " + booking_details.Date + " .Your Booking Id is " + booking_details.Id + " Please confirm your Bookings sent on Email Id "+ booking_details.Email});

            return BadRequest(new { statusCode = StatusCodes.Status400BadRequest, message = "Sorry! Something Went Wrong. Please Review your Booking and Try again" });
        }
    }
}
