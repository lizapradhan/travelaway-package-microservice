using PackageMicroservice.Core.API.Models;

namespace PackageMicroservice.Core.API.Interfaces
{
    public interface IMasterdataRepository
    {
        Task<IEnumerable<City>> GetAllCityAsync();
        Task<IEnumerable<Hotel>> GetAllHotelAndRoomAsync();
    }
}
