using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccomidationBooking.Models.Dtos
{
    public class RoomDto:Room
    {
        public string RoomType { get; set; }
        public string RoomStatus { get; set; }
        public string HotelType { get; set; }
        public string Hotel { get; set; }
        public string Accomidation { get; set; }
    }
}
