using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepoosiory
{
    public interface IHotelRoomRepository
    {
        public Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO);
        public Task<HotelRoomDTO> UpdateHotelRoom(int hotelRoomId, HotelRoomDTO hotelRoom);
        public Task<HotelRoomDTO> GetHotelRoom(int hotelRoomId);
        public Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms();
        public Task<HotelRoomDTO> IsHotelUnique(string name);

        public Task<int> DeleteHotelRoom(int hotelRoomId);

        public Task<IEnumerable<HotelRoomDTO>> GetAllHotelRoomsWithImages();
    }
}
