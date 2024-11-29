using ApiCars.Data;
using ApiCars.Models;
using ApiCars.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiCars.Repositories
{
    public class FabricanteRepository : IFabricanteRepository
    {
        private readonly ApiDBContext _dbContext;
        public FabricanteRepository(ApiDBContext apiDBContext)
        {
            _dbContext = apiDBContext;
        }
        public async Task<List<FabricanteModel>> GetAllFabricantes()
        {
            return await _dbContext.Fabricante.ToListAsync();
        }

        public async Task<FabricanteModel> GetFabricantesById(int id)
        {
            return await _dbContext.Fabricante.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<FabricanteModel> AddNewFabricante(FabricanteModel fabricante)
        {
            await _dbContext.Fabricante.AddAsync(fabricante);
            await _dbContext.SaveChangesAsync();


            return fabricante;
        }

        public async Task<bool> DeleteFabricante(int id)
        {
            FabricanteModel fabricanteForId = await GetFabricantesById(id);
            if (fabricanteForId == null)
            {
                throw new Exception($"A Fabricante para o id: {id} não foi encontrado no banco de dados.");

            }
            _dbContext.Fabricante.Remove(fabricanteForId);
            await _dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<FabricanteModel> UpdateFabricante(FabricanteModel fabricante, int id)
        {
            FabricanteModel fabricanteForId = await GetFabricantesById(id);
            if (fabricanteForId == null)
            {
                throw new Exception($"A Fabricante para o id: {id} não foi encontrado no banco de dados.");

            }

            fabricanteForId.Name = fabricante.Name;
            fabricanteForId.Country = fabricante.Country;
            
            _dbContext.Fabricante.Update(fabricanteForId);
            await _dbContext.SaveChangesAsync();
            return fabricanteForId;
        }
    }
}
