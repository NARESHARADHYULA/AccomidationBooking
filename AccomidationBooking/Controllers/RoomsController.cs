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
    public class RoomsController : ControllerBase
    {
        private readonly ILogger<RoomsController> _logger;
        readonly IRoom _rooms;

        public RoomsController(ILogger<RoomsController> logger, IRoom rooms)
        {
            _logger = logger;
            _rooms = rooms;

        }

        [HttpGet]
        public IEnumerable<Room> GetAll()
        {
            return _rooms.GetAll();
        }
    }
}
