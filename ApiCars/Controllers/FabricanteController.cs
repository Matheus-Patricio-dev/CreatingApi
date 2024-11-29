using ApiCars.Models;
using ApiCars.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FabricanteController : ControllerBase
    {
        private readonly IFabricanteRepository _fabricanteRepository;

        public FabricanteController(IFabricanteRepository fabricanteRepository)
        {
            _fabricanteRepository = fabricanteRepository;
        }

        //GET VERB
        [HttpGet]
        public async Task<ActionResult<List<FabricanteModel>>> GetAllFabricantes()
        {
            List<FabricanteModel> fabricanteModel = await _fabricanteRepository.GetAllFabricantes();
            return Ok(fabricanteModel);
        }


        //GET{ID} VERB
        [HttpGet("{id}")]

        public async Task<ActionResult<List<FabricanteModel>>> GetFabricantesById(int id)
        {
            FabricanteModel fabricanteModel = await _fabricanteRepository.GetFabricantesById(id);
            return Ok(fabricanteModel);
        }

        //POST VERB 
        [HttpPost]
        public async Task<ActionResult<FabricanteModel>> AddNewFabricante([FromBody] FabricanteModel fabricante)
        {
            FabricanteModel variavel = await _fabricanteRepository.AddNewFabricante(fabricante);
            return Ok(variavel);
        }

        //PUT VERB
        [HttpPut("{id}")]
        public async Task<ActionResult<FabricanteModel>> UpdateFabricante([FromBody] FabricanteModel fabricante, int id)
        {
            fabricante.Id = id;
            FabricanteModel variavel = await _fabricanteRepository.UpdateFabricante(fabricante, id);
            return Ok(variavel);
        }

        //DELETE VERB
        [HttpDelete]
        public async Task<ActionResult<FabricanteModel>> Delete(int id)
        {
            bool deleted = await _fabricanteRepository.DeleteFabricante(id);
            return Ok(deleted);
        }
    }
}
