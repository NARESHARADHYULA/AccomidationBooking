using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class GuestRepository : Repository<Guest>, IGuest
    {
        public GuestRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
