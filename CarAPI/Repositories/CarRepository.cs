using CarAPI.Model;

namespace CarAPI.Repositories
{
    public class CarRepository : ICarRepository
    {
        public Task<Car> Create(Car car)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Car> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Car> Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
