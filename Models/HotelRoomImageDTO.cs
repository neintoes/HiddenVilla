using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HotelRoomImageDTO
    {
        public int Id { get; set; }
        public int HotelRoomId { get; set; }
        public string ImageUrl { get; set; }
    }
}
