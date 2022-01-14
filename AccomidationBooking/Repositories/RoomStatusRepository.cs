using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class RoomStatusRepository : Repository<RoomStatus>, IRoomStatus
    {
        public RoomStatusRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
