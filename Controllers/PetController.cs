using Microsoft.AspNetCore.Mvc;
using MyPetAppAPI.Models;
using MyPetAppAPI.Services;

namespace MyPetAppAPI.Controllers
{
    [ApiController] // used to initiate API attributes
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {


   
        private readonly IPetServices _petServices;

        public PetController(IPetServices petServices)
        {
            _petServices = petServices;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<ServiceResponse<List<GetPetDto>>>> Get()
        {
            return Ok( await _petServices.GetAllPets());
        }

        [HttpGet("GetSingle {id}")]
        public async Task<ActionResult<ServiceResponse<List<GetPetDto>>>> GetResult(int id)
        {
            return Ok(await _petServices.GetPetById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<ServiceResponse<GetPetDto>>>> AddPpet(AddPetDto newPet)
        {

            return Ok(await _petServices.AddPet(newPet));
        }



        [HttpPut]
 
        public async Task<ActionResult<List<ServiceResponse<GetPetDto>>>> UpdatedPet(UpdatePetDto updatedPet)
        {

            return Ok(await _petServices.UpdatePet(updatedPet));
        }



    }
}
