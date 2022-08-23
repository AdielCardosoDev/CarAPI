using CarAPI.Model;

namespace CarAPI.Repositories
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> Get();
        Task<Car> Get(int id);
        Task<Car> Create(Car car);
        Task<Car> Update(Car car);
        Task Delete(int id);
    }
}
