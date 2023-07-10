

namespace MyPetAppAPI.Services
{
    public interface IPetServices
    {

        Task<ServiceResponse<List<GetPetDto>>> GetAllPets();

        Task<ServiceResponse<GetPetDto>> GetPetById(int id);

        Task<ServiceResponse<List<GetPetDto>>> AddPet(AddPetDto newPet);

        Task<ServiceResponse<GetPetDto>> UpdatePet(UpdatePetDto updatedPet);

    }
}
