using ApiCars.Models;
using ApiCars.Repositories;
using ApiCars.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCars.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        //GET VERB
        [HttpGet]
        public async Task<ActionResult<List<CarModel>>> GetAllCar()
        {
            List<CarModel> car = await _carRepository.GetAllCar();
            return Ok(car);
        }


        //GET{ID} VERB
        [HttpGet("{id}")]
        public async Task<ActionResult<List<CarModel>>> GetCarById(int id)
        {
            CarModel car = await _carRepository.GetCarById(id);
            return Ok(car);
        }

        //POST VERB 
        [HttpPost]
        public async Task<ActionResult<CarModel>> AddNewCar([FromBody] CarModel car)
        {
            CarModel variavel = await _carRepository.AddNewCar(car);
            return Ok(variavel);
        }

        //PUT VERB
        [HttpPut("{id}")]
        public async Task<ActionResult<CarModel>> UpdateCar([FromBody] CarModel car, int id)
        {
            car.Id = id;
            CarModel variavel = await _carRepository.UpdateCar(car, id);
            return Ok(variavel);
        }

        //DELETE VERB
        [HttpDelete]
        public async Task<ActionResult<CarModel>> DeleteCar(int id)
        {
            bool deleted = await _carRepository.DeleteCar(id);
            return Ok(deleted);
        }
    }
}
