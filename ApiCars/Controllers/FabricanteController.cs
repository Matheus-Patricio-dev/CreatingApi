using ApiCars.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCars.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FabricanteController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<fabricanteModel>> GetFab()
        {

            return Ok();
        }
    }
}
