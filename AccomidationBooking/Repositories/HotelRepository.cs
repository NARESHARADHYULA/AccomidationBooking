using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class HotelRepository : Repository<Hotel>, IHotel
    {
        public HotelRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
