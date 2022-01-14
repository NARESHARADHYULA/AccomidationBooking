using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class HotelTypeRepository : Repository<HotelType>, IHotelType
    {
        public HotelTypeRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
