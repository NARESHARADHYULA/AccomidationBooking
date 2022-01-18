using AccomidationBooking.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AccomidationBooking
{
    public class RoomRepository : Repository<Room>, IRoom
    {
        public RoomRepository(AccomidationsContext dbContext) : base(dbContext) { }

        public IEnumerable<Room> GetAvailableRooms()
        {
            return _dbSet
                .Where(room =>
                !room.IsShared && room.RoomStatus.Name == "Available").ToList();

        }
        public IEnumerable<Room> GetBookedRooms()
        {
            return _dbSet.Include(d => d.Hotel)
                .Include(s => s.RoomStatus)
                .Include(s => s.RoomType).Where(room =>
                !room.IsShared && room.RoomStatus.Name == "Booked").ToList();
        }

        public IEnumerable<Room> GetAvailableSharedRooms()
        {
            return _dbSet.Include(d => d.Hotel)
                .Include(s => s.RoomStatus)
                .Include(s => s.RoomType).Where(room =>
                room.IsShared && room.RoomStatus.Name == "Available").ToList();
        }

        public IEnumerable<Room> GetBookedSharedRooms()
        {
            return _dbSet.Include(d => d.Hotel)
                .Include(s => s.RoomStatus)
                .Include(s => s.RoomType).Where(room =>
                room.IsShared && room.RoomStatus.Name == "Booked").ToList();
        }
    }
}
