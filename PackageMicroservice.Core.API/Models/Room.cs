using System.Text.Json.Serialization;

namespace PackageMicroservice.Core.API.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomType { get; set; } // Single, Double, Deluxe, Suite
        public decimal PricePerNight { get; set; }
        public int HotelId { get; set; }
        [JsonIgnore]
        public Hotel Hotel { get; set; }
    }

}
