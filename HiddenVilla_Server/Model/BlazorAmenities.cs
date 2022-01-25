using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiddenVilla_Server.Model
{
    public class BlazorAmenities
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public BlazorAmenities(int inputId, string inputName, string inputValue)
        {
            Id = inputId;
            Name = inputName;
            Value = inputValue; 
        }
    }
}
