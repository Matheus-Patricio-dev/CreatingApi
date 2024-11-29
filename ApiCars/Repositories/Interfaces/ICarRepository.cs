using ApiCars.Models;

namespace ApiCars.Repositories.Interfaces
{
    public interface ICarRepository
    {
        Task<List<CarModel>> GetAllCar();
        Task<CarModel> GetCarById(int id);
        Task<CarModel> AddNewCar(CarModel car);
        Task<CarModel> UpdateCar(CarModel car, int id);
        Task<bool> DeleteCar(int id);
    }
}
