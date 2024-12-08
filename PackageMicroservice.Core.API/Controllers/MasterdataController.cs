using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PackageMicroservice.Core.API.Interfaces;

namespace PackageMicroservice.Core.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [ResponseCache(Duration = 1800)]
    public class MasterdataController : ControllerBase
    {
        private readonly IMasterdataRepository _masterRepository;
        public MasterdataController(IMasterdataRepository masterRepository)
        {
            _masterRepository = masterRepository;
        }

        [HttpGet("cities")]
        public async Task<IActionResult> GetAllCities()
        {
            try
            {
                return Ok(await _masterRepository.GetAllCityAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("hotels")]
        public async Task<IActionResult> GetAllHotelsAndRoom()
        {
            try
            {
                return Ok(await _masterRepository.GetAllHotelAndRoomAsync());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
