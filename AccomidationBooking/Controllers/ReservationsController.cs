using AccomidationBooking.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccomidationBooking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservationsController : ControllerBase
    {
        private readonly ILogger<ReservationsController> _logger;
        readonly IReservation _reservation;

        public ReservationsController(ILogger<ReservationsController> logger, IReservation reservation)
        {
            _logger = logger;
            _reservation = reservation;

        }

        [HttpGet]
        public IEnumerable<Reservation> GetAll()
        {
            return _reservation.GetAll();
        }
    }
}
