using AutoMapper;
using MoviesAPI.Domain.Models;
using MoviesAPI.Resources;

namespace Movies.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveHamsterResource, Hamster>();
        }
    }
}