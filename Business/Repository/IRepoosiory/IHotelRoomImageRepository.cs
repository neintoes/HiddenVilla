using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepoosiory
{
    public interface IHotelRoomImageRepository
    {
        public Task<int> CreateHotelRoomImage(HotelRoomImageDTO image);
        public Task<int> DeleteImageById(int id);
        public Task<int> DeleteImageByHotelRoomId(int hotelRoomId);
        public Task<int> DeleteImageByImageUrl(string imageUrl);
        public Task<IEnumerable<HotelRoomImageDTO>> GetImagesByHotelRoomId(int hotelRoomId);
        public Task<IEnumerable<HotelRoomImageDTO>> GetAllHotelRoomImages();
    }
}
