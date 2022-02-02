using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepoosiory
{
    public interface IHotelRoomAmenityRepository
    {
        public Task<HotelRoomAmenityDTO> CreateHotelRoomAmenity(HotelRoomAmenityDTO inputDTO);
        public Task<HotelRoomAmenityDTO> UpdateHotelRoomAmenity(int inputId, HotelRoomAmenityDTO inputDTO);
        public Task<int> DeleteHotelRoomAmenity(int inputId);
        public Task<HotelRoomAmenityDTO> GetHotelRoomAmenity(int inputId);
        public Task<HotelRoomAmenityDTO> IsHotelRoomAmenityUnique(string amenityName);
        public Task<IEnumerable<HotelRoomAmenityDTO>> GetAllHotelRoomAmenities();

    }
}
