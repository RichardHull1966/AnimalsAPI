using AutoMapper;
using AnimalsAPI.Domain.Models;
using AnimalsAPI.Resources;

namespace AnimalsAPI.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Hamster, HamsterResource>();
        }
    }
}