using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrastructure;
using System;

namespace Reseravtion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService ReservationService)
        {
            reservationService = ReservationService;
        }

        [HttpGet]
        public Reservation.API.Models.Reservation Get()
        {
            return reservationService.GetReservation();
        }


        [HttpGet("{Id}")]
        public Reservation.API.Models.Reservation GetResById(Guid Id)
        {
            return reservationService.GetReservationById(Id);
        }
    }
}
