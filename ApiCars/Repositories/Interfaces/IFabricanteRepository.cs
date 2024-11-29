using ApiCars.Models;

namespace ApiCars.Repositories.Interfaces
{
    public interface IFabricanteRepository
    {
        Task<List<FabricanteModel>> GetAllFabricantes();
        Task<FabricanteModel> GetFabricantesById(int id);
        Task<FabricanteModel> AddNewFabricante(FabricanteModel fabricante);
        Task<FabricanteModel> UpdateFabricante(FabricanteModel fabricante, int id);
        Task<bool> DeleteFabricante(int id);
    }
}
