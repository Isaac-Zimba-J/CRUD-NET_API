
using MyPetAppAPI.Models;

namespace MyPetAppAPI.Services
{
    public class PetServices : IPetServices 
    {

        private static List<Pet> pets = new List<Pet>
        {
            new Pet(),
            new Pet { Id =1, Name = "sphynx"}
        };
        private readonly IMapper _mapper;

        public PetServices(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ServiceResponse<List<GetPetDto>>> AddPet(AddPetDto newPet)
        {
            var  serviceResponse = new ServiceResponse<List<GetPetDto>>();
            var pet = _mapper.Map<Pet>(newPet);
            pet.Id = pets.Max(c => c.Id) + 1;
            pets.Add(pet);
            serviceResponse.Data =  pets.Select(c => _mapper.Map<GetPetDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetPetDto>>> GetAllPets()
        {
            var serviceResponse = new ServiceResponse<List<GetPetDto>>();
            serviceResponse.Data = pets.Select(c => _mapper.Map<GetPetDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPetDto>> GetPetById(int id)
        {
            var serviceResponse = new ServiceResponse<GetPetDto>();
            var pet = pets.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetPetDto>(pet);
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetPetDto>> UpdatePet(UpdatePetDto updatedPet)
        {
            var serviceResponse = new ServiceResponse<GetPetDto>();

            try {

              
                var pet = pets.FirstOrDefault(c => c.Id == updatedPet.Id);
                
                pet.Name = updatedPet.Name;
                pet.DOB = updatedPet.DOB;
                pet.Weight = updatedPet.Weight;
                pet.Gender = updatedPet.Gender;
                pet.Species = updatedPet.Species;
                pet.Breed = updatedPet.Breed;
                pet.Vaccinated = updatedPet.Vaccinated;
                pet.Vaccine = updatedPet.Vaccine;
                pet.Dose = updatedPet.Dose;
                pet.LastModified = updatedPet.LastModified;
                pet.Created = updatedPet.Created;
                pet.Comment = updatedPet.Comment;
                pet.Description = updatedPet.Description;

                serviceResponse.Data = _mapper.Map<GetPetDto>(pet);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    }
}
