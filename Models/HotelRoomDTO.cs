using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HotelRoomDTO
    {
        [Key]
        public int HotelRoomId { get; set; }

        [Required(ErrorMessage = "Please enter a name for the hotel room.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an occupancy limit for the hotel room.")]
        public int Occupancy { get; set; }

        [Required(ErrorMessage = "Please enter a regular nightly rate for the room.")]
        public double RegularRate { get; set; }

        public string Details { get; set; }

        public string SqFt { get; set; }
        public virtual ICollection<HotelRoomImageDTO> Images { get; set; }
        public List<string> ImageUrls {get; set;}
    }
}
