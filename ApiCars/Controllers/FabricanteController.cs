using ApiCars.Models;
using ApiCars.Repositorys.Interfaces;
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

        [HttpGet]
        public async Task<ActionResult<List<fabricanteModel>>> GetallFabricantes()
        {
            List<fabricanteModel> fabricantes = await _fabricanteRepository.GetallFabricantes();
            return Ok(fabricantes);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<List<fabricanteModel>>> GetFabricantesById(int id)
        {
            fabricanteModel fabricante = await _fabricanteRepository.GetFabricantesById(id);
            return Ok(fabricante);
        }
        [HttpPost]
        public async Task<ActionResult<fabricanteModel>> AddNewFabricante([FromBody] fabricanteModel fabricante)
        {
            fabricanteModel variavel = await _fabricanteRepository.AddNewFabricante(fabricante);
            return Ok(variavel);
        }
    }
}
