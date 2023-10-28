using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles;

public class PlatformsProfile : Profile
{
    public PlatformsProfile()
    {
        // Source (Model) -> Target (Dto)

        // When reading from the database the model is the source and the target is the Dto
        CreateMap<Platform, PlatformReadDto>();
        
        // When creating the Dto is the source and we are mapping to a model to add to the database
        CreateMap<PlatformCreateDto, Platform>();
        

    }
}