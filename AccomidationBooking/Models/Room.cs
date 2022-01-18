using System;
using System.Collections.Generic;

#nullable disable

namespace AccomidationBooking.Models
{
    public partial class Room
    {
        public Room()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public int Maxnoofpeople { get; set; }
        public int Availablepeople { get; set; }
        public bool IsShared { get; set; }
        public bool IsAc { get; set; }
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public int RoomStatusId { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
