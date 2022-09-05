using CarAPI.Model;
using CarAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Car>> Get()
        {
            return await _carRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            return await _carRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Car>> PostCar([FromBody] Car car)
        {
            var newCar = await _carRepository.Create(car);
            return CreatedAtAction(nameof(GetCar), new {id = newCar.id}, newCar);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var carToDelete = await _carRepository.Get(id);

            if (carToDelete == null)
                return NotFound();

            await _carRepository.Delete(carToDelete.id);
            return NoContent();
        }

        [HttpPut]
        public async Task<ActionResult> PutCars(int id, [FromBody] Car car)
        {
            if(id == car.id)
                return BadRequest();

            await _carRepository.Update(car);
            return NoContent();
        }

    }
}



