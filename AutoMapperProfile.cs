using AutoMapper;

namespace MyPetAppAPI
{
    public class AutoMapperProfile :Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Pet, GetPetDto>();
            CreateMap<AddPetDto, Pet>();
           // CreateMap<Pet, UpdatePetDto>();
        }
    }
}
