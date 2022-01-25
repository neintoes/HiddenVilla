using AutoMapper;
using Business.Repository.IRepoosiory;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class HotelRoomImageRepository : IHotelRoomImageRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HotelRoomImageRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<int> CreateHotelRoomImage(HotelRoomImageDTO image)
        {
            HotelRoomImage hotelRoomImage = _mapper.Map<HotelRoomImageDTO,HotelRoomImage>(image);
            await _db.HotelRoomImage.AddAsync(hotelRoomImage);
            return await _db.SaveChangesAsync();
        }

        public Task<int> DeleteImageByHotelRoomId(int hotelRoomId)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteImageById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HotelRoomImageDTO>> GetImagesByHotelRoomId(int hotelRoomId)
        {
            throw new NotImplementedException();
        }
    }
}
