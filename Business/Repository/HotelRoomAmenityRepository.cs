using AutoMapper;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepoosiory
{
    public class HotelRoomAmenityRepository : IHotelRoomAmenityRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HotelRoomAmenityRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<HotelRoomAmenityDTO> CreateHotelRoomAmenity(HotelRoomAmenityDTO inputDTO)
        {
            HotelRoomAmenity newAmenity = _mapper.Map<HotelRoomAmenityDTO,HotelRoomAmenity>(inputDTO);
            newAmenity.CreatedDate = DateTime.Now;
            var addedAmenity = await _db.HotelRoomAmenity.AddAsync(newAmenity);
            await _db.SaveChangesAsync();
            return _mapper.Map<HotelRoomAmenity, HotelRoomAmenityDTO>(addedAmenity.Entity);
        }


        public async Task<int> DeleteHotelRoomAmenity(int inputId)
        {
            var amenityToBeDeleted = await _db.HotelRoomAmenity.FirstOrDefaultAsync(x => x.Id == inputId);
            if(amenityToBeDeleted != null)
            {
                _db.HotelRoomAmenity.Remove(amenityToBeDeleted);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<IEnumerable<HotelRoomAmenityDTO>> GetAllHotelRoomAmenities()
        {
            IEnumerable<HotelRoomAmenityDTO> allAmenities = _mapper.Map<IEnumerable<HotelRoomAmenity>,IEnumerable<HotelRoomAmenityDTO>>(_db.HotelRoomAmenity);
            return allAmenities;
        }

        public async Task<HotelRoomAmenityDTO> GetHotelRoomAmenity(int inputId)
        {
            HotelRoomAmenity foundAmenity = await _db.HotelRoomAmenity.FirstOrDefaultAsync(x=>x.Id==inputId);
            try
            {
                return _mapper.Map<HotelRoomAmenity, HotelRoomAmenityDTO>(foundAmenity);
            }
            catch(Exception ex)
            {
                if(foundAmenity == null)
                {
                    throw new Exception("ID does not match any existing amenities.");
                }
                else
                {
                    throw new Exception(ex.ToString());
                }
            }
        }

        public async Task<HotelRoomAmenityDTO> IsHotelRoomAmenityUnique(string amenityName)
        {
            var matchingAmenities = await _db.HotelRoomAmenity.FirstOrDefaultAsync(x => x.Name == amenityName);
            if(matchingAmenities == null)
            {
                Console.WriteLine("No matching Amenities found.");
                return null;
            }
            else
            {
                Console.WriteLine("Input amenity name is not unique.");
                return _mapper.Map<HotelRoomAmenity, HotelRoomAmenityDTO>(matchingAmenities);
            }
        }

        public async Task<HotelRoomAmenityDTO> UpdateHotelRoomAmenity(int inputId, HotelRoomAmenityDTO inputDTO)
        {
            try
            {
                HotelRoomAmenity amenityToBeUpdated = _db.HotelRoomAmenity.FirstOrDefault(x => x.Id == inputId);
                //it seems that taking the original amenity AND the dto and passing them both into the mapper lays the dto over onto the original?
                HotelRoomAmenity inputAmenity = _mapper.Map<HotelRoomAmenityDTO, HotelRoomAmenity>(inputDTO, amenityToBeUpdated);
                inputAmenity.UpdatedDate = DateTime.Now;
                var updatedAmenity = _db.HotelRoomAmenity.Update(inputAmenity);
                await _db.SaveChangesAsync();
                return _mapper.Map<HotelRoomAmenity, HotelRoomAmenityDTO>(updatedAmenity.Entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Potentially the original does not exist in the database?" + ex.ToString());
            }
        }
    }
}
