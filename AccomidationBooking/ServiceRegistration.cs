using Microsoft.Extensions.DependencyInjection;

namespace AccomidationBooking
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IReservation, ReservationRepository>();
            services.AddScoped<IAccomidation, AccomidationRepository>();
            services.AddScoped<IHotel, HotelRepository>();
            services.AddScoped<IRoom, RoomRepository>();
            services.AddScoped<IRoomType, RoomTypeRepository>();
            services.AddScoped<IRoomStatus, RoomStatusRepository>();
            services.AddScoped<IHotelType, HotelTypeRepository>();
            services.AddScoped<IGuest, GuestRepository>();
        }
    }
}
