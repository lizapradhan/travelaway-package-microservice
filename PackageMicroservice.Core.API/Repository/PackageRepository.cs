using Microsoft.EntityFrameworkCore;
using PackageMicroservice.Core.API.Interfaces;
using PackageMicroservice.Core.API.Models;

namespace PackageMicroservice.Core.API.Repository
{
    public class PackageRepository : IPackageRepository
    {
        private readonly PackageDbContext _context;
        public PackageRepository(PackageDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Models.Package>> GetAllPackageAsync()
        {
            try
            {
                return await _context.Packages.Include(p => p.Images).ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Models.Package> GetPackageByIdAsync(int packageId)
        {
            try
            {
                return await _context.Packages.Where(x => x.PackageId == packageId)
                                                .Include(x => x.Images)
                                                .Include(x => x.Category)
                                                .Include(x => x.SubPackages).FirstOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Models.SubPackage> GetSubPackageById(int subPackageId)
        {
            try
            {
                return await _context.SubPackages.FindAsync(subPackageId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<Models.SubPackage>> GetSubPackages()
        {
            try
            {
                return await _context.SubPackages.ToListAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
