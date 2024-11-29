using ApiCars.Data;
using ApiCars.Models;
using ApiCars.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiCars.Repositories
{
    public class CarRepository : ICarRepository
    {
        private readonly ApiDBContext _dbContext;
        public CarRepository(ApiDBContext apiDBContext)
        {
            _dbContext = apiDBContext;
        }
        //GET
        public async Task<List<CarModel>> GetAllCar()
        {
            return await _dbContext.Car.Include(x => x.fabricante).ToListAsync();
        }
        //GET BY ID
        public async Task<CarModel> GetCarById(int id)
        {
            return await _dbContext.Car.Include(x => x.fabricante).FirstOrDefaultAsync(x => x.Id == id);
        }

        //ADD
        public async Task<CarModel> AddNewCar(CarModel car)
        {
            await _dbContext.Car.AddAsync(car);
            await _dbContext.SaveChangesAsync();


            return car;
        }
        //DELETE
        public async Task<bool> DeleteCar(int id)
        {
            CarModel CarById = await GetCarById(id);
            if (CarById == null)
            {
                throw new Exception($"O carro com o id: {id} não foi encontrado no banco de dados.");

            }
            _dbContext.Car.Remove(CarById);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        //UPDATE
        public async Task<CarModel> UpdateCar(CarModel car, int id)
        {
            CarModel carById = await GetCarById(id);
            if (carById == null)
            {
                throw new Exception($"O carro com o id: {id} não foi encontrado no banco de dados.");

            }

            carById.Model = car.Model;
            carById.Type = car.Type;
            carById.FabricationYear = car.FabricationYear;
            carById.FabricanteId = car.FabricanteId;

            _dbContext.Car.Update(carById);
            await _dbContext.SaveChangesAsync();
            return carById;
        }

        public Task<List<CarModel>> GetallCar()
        {
            throw new NotImplementedException();
        }
    }
}
