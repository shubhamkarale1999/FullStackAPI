using FullStackAPI.Deta;
using FullStackAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FullStackAPI.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CarsController : Controller
    {
        private readonly FullStackDBContext _fullStackDBContext;

        public CarsController(FullStackDBContext fullStackDBContext)
        {
            _fullStackDBContext= fullStackDBContext;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            var cars= await _fullStackDBContext.Cars.ToListAsync();
            return Ok(cars);
        }

        [HttpPost]
        public async Task<IActionResult> AddCars([FromBody] Cars carRequest) 
        {
            carRequest.Id = Guid.NewGuid();
            await _fullStackDBContext.Cars.AddAsync(carRequest);
            await _fullStackDBContext.SaveChangesAsync();

            return Ok(carRequest);
        }
    }
}
