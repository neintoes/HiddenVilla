using AutoMapper;
using Business.Repository.IRepoosiory;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
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
            try
            {
                HotelRoomImage hotelRoomImage = _mapper.Map<HotelRoomImageDTO, HotelRoomImage>(image);
                await _db.HotelRoomImage.AddAsync(hotelRoomImage);
                return await _db.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<int> DeleteImageById(int id)
        {
            try
            {
                var imageToBeDeleted = await _db.HotelRoomImage.FirstOrDefaultAsync(x => x.Id == id);
                if (imageToBeDeleted != null)
                {
                    _db.HotelRoomImage.Remove(imageToBeDeleted);
                    return await _db.SaveChangesAsync();
                }
                return 0;
            } 
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<int> DeleteImageByHotelRoomId(int hotelRoomId)
        {
            try
            {
                var imagesToBeDeleted = await _db.HotelRoomImage.Where(x => x.HotelRoomId == hotelRoomId).ToListAsync();
                if (imagesToBeDeleted != null)
                {
                    _db.HotelRoomImage.RemoveRange(imagesToBeDeleted);
                    return await _db.SaveChangesAsync();
                }
                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<IEnumerable<HotelRoomImageDTO>> GetImagesByHotelRoomId(int hotelRoomId)
        {
            try
            {
                return _mapper.Map<IEnumerable<HotelRoomImage>, IEnumerable<HotelRoomImageDTO>>(
                await _db.HotelRoomImage.Where(x => x.HotelRoomId == hotelRoomId).ToListAsync());
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }

        public async Task<IEnumerable<HotelRoomImageDTO>> GetAllHotelRoomImages()
        {
            IEnumerable<HotelRoomImageDTO> hotelRoomImages = _mapper.Map<IEnumerable<HotelRoomImage>, IEnumerable<HotelRoomImageDTO>>(_db.HotelRoomImage);

            return hotelRoomImages;
        }
    }
}
