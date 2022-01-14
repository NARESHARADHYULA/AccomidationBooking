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
    public class HotelsController : ControllerBase
    {
        private readonly ILogger<HotelsController> _logger;
        readonly IHotel _hotel;

        public HotelsController(ILogger<HotelsController> logger, IHotel hotel)
        {
            _logger = logger;
            _hotel = hotel;

        }

        [HttpGet]
        public IEnumerable<Hotel> GetAll()
        {
            return _hotel.GetAll();
        }
    }
}
