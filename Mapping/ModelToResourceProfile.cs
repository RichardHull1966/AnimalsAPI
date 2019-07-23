using AutoMapper;
using MoviesAPI.Domain.Models;
using MoviesAPI.Resources;

namespace MoviesAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Hamster, HamsterResource>();
        }
    }
}