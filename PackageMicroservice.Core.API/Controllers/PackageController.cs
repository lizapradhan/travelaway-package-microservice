using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PackageMicroservice.Core.API.Interfaces;

namespace PackageMicroservice.Core.API.Controllers
{
    [Route("api")]
    [ApiController]
    [Authorize]
    public class PackageController : ControllerBase
    {
        private readonly IPackageRepository _packageRepository;
        public PackageController(IPackageRepository packageRepository)
        {
            _packageRepository = packageRepository;
        }

        [HttpGet("packages")]
        public async Task<IActionResult> GetAllPackages()
        {
            try
            {
                var packageResult = await _packageRepository.GetAllPackageAsync();
                return Ok(packageResult.Select(x => new ViewModels.Package
                {
                    PackageName = x.PackageName,
                    CategoryId = x.CategoryId,
                    Description = x.Description,
                    ImageUrl = x.Images.FirstOrDefault()?.ImageUrl,
                    PackageId = x.PackageId
                }));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("packages/{packageId}/details")]
        public async Task<IActionResult> GetPackageById(int packageId)
        {
            try
            {
                var packageDetailsResult = await _packageRepository.GetPackageByIdAsync(packageId);

                return Ok(new ViewModels.Package
                {
                    PackageId = packageDetailsResult.PackageId,
                    PackageName = packageDetailsResult.PackageName,
                    CategoryName = packageDetailsResult.Category.CategoryName,
                    CategoryId= packageDetailsResult.Category.CategoryId,
                    Description = packageDetailsResult.Description,
                    Images = packageDetailsResult.Images.Select(x => x.ImageUrl),
                    SubPackages = packageDetailsResult.SubPackages.Select(x => new ViewModels.SubPackage {
                       Days = x.Days,
                       Description = x.Description,
                       Nights = x.Nights,
                       PricePerAdult = x.PricePerAdult,
                       SubPackageId=x.SubPackageId,
                       PlaceToVisit=x.PlaceToVisit,
                       IsAccomodationAvailable=x.IsAccomodationAvailable
                    })
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("subpackages/{subPackageId}")]
        public async Task<IActionResult> GetSubPackagesById(int subPackageId)
        {
            try
            {
                return Ok(await _packageRepository.GetSubPackageById(subPackageId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("subpackages")]
        public async Task<IActionResult> GetSubPackages()
        {
            try
            {
                return Ok(await _packageRepository.GetSubPackages());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
