using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class RoomTypeRepository : Repository<RoomType>, IRoomType
    {
        public RoomTypeRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
