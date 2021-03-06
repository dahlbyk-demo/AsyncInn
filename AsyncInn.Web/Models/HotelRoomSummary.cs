﻿namespace AsyncInn.Web.Models
{
    public class HotelRoomSummary
    {
        public long HotelId { get; set; }
        public int RoomNumber { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int RoomID { get; set; }
        public RoomSummary Room { get; set; }
    }
}