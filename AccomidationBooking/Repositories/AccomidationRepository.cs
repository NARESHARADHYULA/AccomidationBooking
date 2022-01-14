using AccomidationBooking.Models;

namespace AccomidationBooking
{
    public class AccomidationRepository : Repository<Accomidation>, IAccomidation
    {
        public AccomidationRepository(AccomidationsContext dbContext) : base(dbContext){}
       
    }
}
