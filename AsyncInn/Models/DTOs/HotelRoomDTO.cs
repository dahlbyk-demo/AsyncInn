﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.DTOs
{
    public class HotelRoomDTO
    {
        public long HotelId { get; set; }
        public int RoomNumber { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int RoomID { get; set; }
        public RoomDTO Room { get; set; }
    }
}
