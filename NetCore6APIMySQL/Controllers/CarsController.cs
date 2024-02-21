using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore6APIMySQL.Data.Repositories;

namespace NetCore6APIMySQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarRepository _carRepository;
        private object await_carRepository;

        public CarsController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCars()
        {
            return Ok(await_carRepository.GetAllCars());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCarDetails(int id)
        {
            return Ok(await _carRepository.GetDetails(id));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCar()[¨FromBody] Car car)
            { 
             if(CarRepository ==null)
            return BadResquest();
        if(!ModelState.IsValid)
            return BadResquest(ModelState);
          await _carRepository.UpdateCar(car);

        return NoContent();

            }
    [HttpDelete]
    public async Task<IActionResult> DeleteCar(int id)
    {
        await _carRepository.DeleteCar(new Car { id = id });

        return NoContentResult();
    }
}
}
