using ApiCars.Models;

namespace ApiCars.Repositorys.Interfaces
{
    public interface IFabricanteRepository
    {
        Task<List<fabricanteModel>> GetallFabricantes();
        Task<fabricanteModel> GetFabricantesById(int id);
        Task<fabricanteModel> AddNewFabricante(fabricanteModel fabricante);
        Task<fabricanteModel> UpdateFabricante(fabricanteModel fabricante, int id);
        Task<bool> DeleteFabricante (int id);
    }
}
