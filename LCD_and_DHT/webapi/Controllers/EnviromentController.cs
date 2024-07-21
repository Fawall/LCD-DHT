using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using webapi.Models;
using webapi.Repository;
using webapi.Repository.Interfaces;

namespace webapi.Controllers 
{
    [Route("api/[controller]")]
    [ApiController]

    public class EnviromentController : ControllerBase 
    {   
        private readonly IEnviroment _enviromentRepository;

        public EnviromentController(IEnviroment enviromentRepository)
        {
            _enviromentRepository = enviromentRepository;

        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] EnviromentModel enviroment)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            await _enviromentRepository.CreateEnviromentState(enviroment.Temperature, enviroment.Humidity);      

            return StatusCode(200, ModelState);

        }
        




    }



}