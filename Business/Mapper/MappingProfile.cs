using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Data;
using Models;

namespace Business.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<HotelRoomDTO, RoomModel>();
            CreateMap<RoomModel, HotelRoomDTO>();
            CreateMap<HotelRoomImage, HotelRoomImageDTO>().ReverseMap();
            CreateMap<HotelRoomAmenity, HotelRoomAmenityDTO>().ReverseMap();
        }
    }
}
