using AutoMapper;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Resources;

namespace Movies.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveHamsterResource, Hamster>();
            CreateMap<SaveCatResource, Cat>();
        }
    }
}