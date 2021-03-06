﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.DTOs
{
    public class RoomDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public List<AmenityDTO> Amenities { get; set; }
    }
}
