using System;
using System.Collections.Generic;

#nullable disable

namespace AccomidationBooking.Models
{
    public partial class Accomidation
    {
        public Accomidation()
        {
            Hotels = new HashSet<Hotel>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        public virtual ICollection<Hotel> Hotels { get; set; }
    }
}
