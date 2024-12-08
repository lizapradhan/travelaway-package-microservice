using Microsoft.EntityFrameworkCore;
using PackageMicroservice.Core.API.Interfaces;
using PackageMicroservice.Core.API.Models;

namespace PackageMicroservice.Core.API.Repository
{
    public class MasterdataRepository : IMasterdataRepository
    {
        private readonly PackageDbContext _context;
        public MasterdataRepository(PackageDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<City>> GetAllCityAsync()
        {
            try
            {
                return await _context.Cities.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Hotel>> GetAllHotelAndRoomAsync()
        {
            try
            {
                return await _context.Hotels.Include(x => x.Rooms)
                                            .ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
