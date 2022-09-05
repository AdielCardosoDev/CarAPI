using CarAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace CarAPI.Repositories
{
    public class CarRepository : ICarRepository
    {

        public readonly CarContext _CarContext;

        public CarRepository(CarContext Context)
        {
            _CarContext = Context;
        }

        public async Task<Car> Create(Car car)
        {
            _CarContext.Cars.Add(car);
            await _CarContext.SaveChangesAsync();
            return car;
        }

        public async Task Delete(int id)
        {
            var carDelete = await _CarContext.Cars.FindAsync(id);
            _CarContext.Cars.Remove(carDelete);
            await _CarContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Car>> Get()
        {
          return await  _CarContext.Cars.ToListAsync();
        }

        public async Task<Car> Get(int id)
        {
            return await _CarContext.Cars.FindAsync(id);
        }

        public async Task Update(Car car)
        {
            _CarContext.Entry(car).State = EntityState.Modified;
            await _CarContext.SaveChangesAsync();
        }

    }
}
