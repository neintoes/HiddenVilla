using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class HotelRoomAmenityDTO
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a name for the amenity.")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Timing { get; set; }
        [Required(ErrorMessage = "Please enter an icon style for this amenity.")]
        public string IconStyle { get; set; }

    }
}
