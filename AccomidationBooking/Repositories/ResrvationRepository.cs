using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class ReservationRepository : Repository<Reservation>, IReservation
    {
        public ReservationRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
