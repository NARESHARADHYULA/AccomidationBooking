using System;
using System.Collections.Generic;

#nullable disable

namespace AccomidationBooking.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
        public int NoofPeople { get; set; }
        public string Guest { get; set; }
        public string BookedBy { get; set; }
        public int RoomId { get; set; }
        public int HotelId { get; set; }
        public int RoomType { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual Room Room { get; set; }
    }
}
