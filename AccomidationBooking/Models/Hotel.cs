using System;
using System.Collections.Generic;

#nullable disable

namespace AccomidationBooking.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Reservations = new HashSet<Reservation>();
            Rooms = new HashSet<Room>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int AccomidationsId { get; set; }
        public int HotelTypeId { get; set; }

        public virtual Accomidation Accomidations { get; set; }
        public virtual HotelType HotelType { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
