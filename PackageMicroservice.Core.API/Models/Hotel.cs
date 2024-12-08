namespace PackageMicroservice.Core.API.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }

}
