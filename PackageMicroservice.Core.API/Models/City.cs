namespace PackageMicroservice.Core.API.Models
{
    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public ICollection<Hotel> Hotels { get; set; }
    }

}
