using Business.Repository.IRepoosiory;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Business.Repository
{
    public class HotelRoomRepository : IHotelRoomRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HotelRoomRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<HotelRoomDTO> CreateHotelRoom(HotelRoomDTO hotelRoomDTO)
        {
            RoomModel hotelRoom = _mapper.Map<HotelRoomDTO, RoomModel>(hotelRoomDTO);
            hotelRoom.CreatedDate = DateTime.Now;
    
            hotelRoom.CreatedBy = "";
            var addedHotelRoom = await _db.RoomModel.AddAsync(hotelRoom);
            await _db.SaveChangesAsync();
            return _mapper.Map<RoomModel, HotelRoomDTO>(addedHotelRoom.Entity);
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRoomsWithImages()
        {
            IEnumerable<HotelRoomDTO> hotelRooms = _mapper.Map<IEnumerable<RoomModel>, IEnumerable<HotelRoomDTO>>(_db.RoomModel.Include(x=>x.Images));

            return hotelRooms;
        }

        public async Task<IEnumerable<HotelRoomDTO>> GetAllHotelRooms()
        {
            IEnumerable<HotelRoomDTO> hotelRooms = _mapper.Map<IEnumerable<RoomModel>, IEnumerable<HotelRoomDTO>>(_db.RoomModel);

            return hotelRooms;
        }

        public async Task<HotelRoomDTO> GetHotelRoom(int hotelRoomId)
        {
            try
            {
                return _mapper.Map<RoomModel, HotelRoomDTO>(await _db.RoomModel.Include(x=>x.Images).FirstOrDefaultAsync(x => x.HotelRoomId == hotelRoomId));
            }
            catch (Exception ex)
            {
                if(await _db.RoomModel.FirstOrDefaultAsync(x => x.HotelRoomId == hotelRoomId) == null)
                {
                    Console.WriteLine("Error as the input ID does not match any held hotel rooms");
                }
                throw new Exception(ex.ToString());
            }
        }

        //If hotel is unique, return null, else return the hotel with the same name.
        public async Task<HotelRoomDTO> IsHotelUnique(string name)
        {
            try
            {
                return _mapper.Map<RoomModel, HotelRoomDTO>(await _db.RoomModel.FirstOrDefaultAsync(x => x.Name == name));
            }
            catch
            {
                Console.WriteLine("No matching room found.");
                return null;
            }
        }

        //Getting the current room details.. mapping our new details INTO them and then updating the system with the new details. 
        public async Task<HotelRoomDTO> UpdateHotelRoom(int hotelRoomId, HotelRoomDTO hotelRoom)
        {
            try
            {
                RoomModel currentRoomDetails = await _db.RoomModel.FirstOrDefaultAsync(x => x.HotelRoomId == hotelRoomId);
                RoomModel newRoomDetails = _mapper.Map<HotelRoomDTO, RoomModel>(hotelRoom, currentRoomDetails);
                newRoomDetails.UpdatedBy = "";
                newRoomDetails.UpdatedDate = DateTime.Now;
                var updatedRoom = _db.RoomModel.Update(newRoomDetails);
                await _db.SaveChangesAsync();
                return _mapper.Map<RoomModel, HotelRoomDTO>(updatedRoom.Entity);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            
        }

        public async Task<int> DeleteHotelRoom(int hotelRoomId)
        {
            var roomToBeDeleted = await _db.RoomModel.FirstOrDefaultAsync(x => x.HotelRoomId == hotelRoomId);
            if(roomToBeDeleted != null)
            {
                _db.RoomModel.Remove(roomToBeDeleted);
                return await _db.SaveChangesAsync();
            }
            return 0;
        }
    }
}
