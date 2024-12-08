using PackageMicroservice.Core.API.Models;

namespace PackageMicroservice.Core.API.Interfaces
{
    public interface IPackageRepository
    {
        Task<IEnumerable<Package>> GetAllPackageAsync();
        Task<Package> GetPackageByIdAsync(int packageId);
        Task<SubPackage> GetSubPackageById(int subPackageId);
        Task<IEnumerable<SubPackage>> GetSubPackages();
    }
}
