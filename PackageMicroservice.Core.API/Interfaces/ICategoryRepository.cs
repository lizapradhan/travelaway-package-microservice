using PackageMicroservice.Core.API.Models;

namespace PackageMicroservice.Core.API.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoryAsync();
    }
}
