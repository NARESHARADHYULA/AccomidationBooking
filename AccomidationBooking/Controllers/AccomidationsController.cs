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
    public class AccomidationsController : ControllerBase
    {
        private readonly ILogger<AccomidationsController> _logger;
        readonly IAccomidation _accomidation;

        public AccomidationsController(ILogger<AccomidationsController> logger, IAccomidation accomidation)
        {
            _logger = logger;
            _accomidation = accomidation;

        }

        [HttpGet]
        public IEnumerable<Accomidation> GetAll()
        {
            return _accomidation.GetAll();
        }
    }
}
