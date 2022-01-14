using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class RoomRepository : Repository<Room>, IRoom
    {
        public RoomRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
