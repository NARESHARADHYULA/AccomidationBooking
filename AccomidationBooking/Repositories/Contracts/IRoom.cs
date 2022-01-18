using AccomidationBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace AccomidationBooking
{
    public interface IRoom : IRepository<Room>
    {
        public IEnumerable<Room> GetBookedRooms();
        public IEnumerable<Room> GetAvailableRooms();
        public IEnumerable<Room> GetAvailableSharedRooms();
        public IEnumerable<Room> GetBookedSharedRooms();
    }
}
