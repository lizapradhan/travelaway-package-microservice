using Microsoft.EntityFrameworkCore;
using PackageMicroservice.Core.API.Interfaces;
using PackageMicroservice.Core.API.Models;

namespace PackageMicroservice.Core.API.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly PackageDbContext _context;
        public CategoryRepository(PackageDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllCategoryAsync()
        {
            try
            {
                return await _context.Categories.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
