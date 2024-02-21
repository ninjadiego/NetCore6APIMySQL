using NetCore6APIMySQL.Data.Repositories;
using NetCore6APIMySQL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6APIMySQL.Data.Repositories
{
    public interface CarRepository : ICarRepository

    {
        Task<IEnumerable<Car>> GetAllCars();
        Task<Car> GetDetails(int id);
        Task<bool> InserCar(Car car);
        Task<bool> UpdateCar(Car car);
        Task<bool> DeleteCar(Car car);

    }
}