using AccomidationBooking.Models;
using AccomidationBooking.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccomidationBooking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly ILogger<RoomsController> _logger;
        private readonly IRoom _rooms;
        private readonly IAccomidation _accomidation;
        private readonly IHotel _hotel;
        private readonly IHotelType _hotelType;
        private readonly IRoomStatus _roomStatus;
        private readonly IRoomType _roomType;
        public RoomsController(ILogger<RoomsController> logger, 
            IRoom rooms, IAccomidation accomidation, IHotel hotels, IHotelType hotelType,
            IRoomStatus roomstatus, IRoomType roomType)
        {
            _logger = logger;
            _rooms = rooms;
            _accomidation = accomidation;
            _roomStatus = roomstatus;
            _roomType = roomType;
            _hotel = hotels;
            _hotelType = hotelType;

        }

        [HttpGet("/GetBookedRooms")]
        public IEnumerable<Room> GetBookedRooms()
        {
            var rooms = new List<RoomDto>();
            var availableRooms = _rooms.GetBookedRooms();
            var roomTypes = _roomType.GetAll();
            var roomStatuses = _roomStatus.GetAll();
            var hotels = _hotel.GetAll();
            var hotelTypes = _hotelType.GetAll();
            var accomidations = _accomidation.GetAll();

            foreach (var room in availableRooms)
            {
                var hotel = hotels.FirstOrDefault(h => h.Id == room.HotelId);
                var hotelType = hotelTypes.FirstOrDefault(ty => ty.Id == hotel.HotelTypeId);
                var accomidation = accomidations.FirstOrDefault(a => a.Id == hotel.Id);
                var roomStatus = roomStatuses.FirstOrDefault(s => s.Id == room.RoomStatusId);
                var roomType = roomTypes.FirstOrDefault(t => t.Id == room.RoomTypeId);

                var roomDto = new RoomDto
                {
                    Id = room.Id,
                    Availablepeople = room.Availablepeople,
                    IsAc = room.IsAc,
                    IsShared = room.IsShared,
                    Maxnoofpeople = room.Maxnoofpeople,
                    Number = room.Number,
                    RoomStatusId = room.RoomStatusId,
                    RoomTypeId = room.RoomTypeId,
                    HotelId = room.HotelId,
                    Hotel = hotel.Name,
                    Accomidation = accomidation.Name,
                    HotelType = hotelType.Name,
                    RoomStatus = roomStatus.Name,
                    RoomType = roomType.Name,
                };
                rooms.Add(roomDto);
            }
            return rooms;
        }

        [HttpGet("/GetAvailableRooms")]
        public IEnumerable<RoomDto> GetAvailableRooms()
        {
            var rooms = new List<RoomDto>();
            var availableRooms = _rooms.GetAvailableRooms();
            var roomTypes = _roomType.GetAll();
            var roomStatuses = _roomStatus.GetAll();
            var hotels = _hotel.GetAll();
            var hotelTypes = _hotelType.GetAll();
            var accomidations = _accomidation.GetAll();
            
            foreach(var room in availableRooms)
            {
                var hotel = hotels.FirstOrDefault(h => h.Id == room.HotelId);
                var hotelType = hotelTypes.FirstOrDefault(ty => ty.Id == hotel.HotelTypeId);
                var accomidation = accomidations.FirstOrDefault(a => a.Id == hotel.Id);
                var roomStatus = roomStatuses.FirstOrDefault(s => s.Id == room.RoomStatusId);
                var roomType = roomTypes.FirstOrDefault(t => t.Id == room.RoomTypeId);
                
                var roomDto = new RoomDto
                {
                    Id = room.Id,
                    Availablepeople = room.Availablepeople,
                    IsAc = room.IsAc,
                    IsShared = room.IsShared,
                    Maxnoofpeople = room.Maxnoofpeople,
                    Number = room.Number,
                    RoomStatusId = room.RoomStatusId,
                    RoomTypeId = room.RoomTypeId,
                    HotelId = room.HotelId,
                    Hotel = hotel.Name,
                    Accomidation = accomidation.Name,
                    HotelType = hotelType.Name,
                    RoomStatus = roomStatus.Name,
                    RoomType = roomType.Name,
                };
                rooms.Add(roomDto);
            }
            return rooms;
        }

        [HttpGet("/GetSharedRooms")]
        public IEnumerable<Room> GetSharedRooms()
        {
            var rooms = new List<RoomDto>();
            var availableRooms = _rooms.GetAvailableSharedRooms();
            var roomTypes = _roomType.GetAll();
            var roomStatuses = _roomStatus.GetAll();
            var hotels = _hotel.GetAll();
            var hotelTypes = _hotelType.GetAll();
            var accomidations = _accomidation.GetAll();

            foreach (var room in availableRooms)
            {
                var hotel = hotels.FirstOrDefault(h => h.Id == room.HotelId);
                var hotelType = hotelTypes.FirstOrDefault(ty => ty.Id == hotel.HotelTypeId);
                var accomidation = accomidations.FirstOrDefault(a => a.Id == hotel.Id);
                var roomStatus = roomStatuses.FirstOrDefault(s => s.Id == room.RoomStatusId);
                var roomType = roomTypes.FirstOrDefault(t => t.Id == room.RoomTypeId);

                var roomDto = new RoomDto
                {
                    Id = room.Id,
                    Availablepeople = room.Availablepeople,
                    IsAc = room.IsAc,
                    IsShared = room.IsShared,
                    Maxnoofpeople = room.Maxnoofpeople,
                    Number = room.Number,
                    RoomStatusId = room.RoomStatusId,
                    RoomTypeId = room.RoomTypeId,
                    HotelId = room.HotelId,
                    Hotel = hotel.Name,
                    Accomidation = accomidation.Name,
                    HotelType = hotelType.Name,
                    RoomStatus = roomStatus.Name,
                    RoomType = roomType.Name,
                };
                rooms.Add(roomDto);
            }
            return rooms;
        }

    }
}
