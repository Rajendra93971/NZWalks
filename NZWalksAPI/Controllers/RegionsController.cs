using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalksAPI.Models;

namespace NZWalksAPI.Controllers
{
    // https://localhost:port/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {

        //Get: https://localhost:port/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = 1,
                    code = "AKL",
                    RegionImageUrl = "https://images.unsplash.com/photo-1507699622108-4be3abd695ad"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = 2,
                    code = "WLG",
                    RegionImageUrl = "https://images.unsplash.com/photo-1502786129293-79981df4e689"
                }
            };

            return Ok(regions);
        }
    }
}
