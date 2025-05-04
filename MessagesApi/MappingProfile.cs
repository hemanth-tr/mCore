using AutoMapper;
using MessagesApi.Models;

namespace MessagesApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<UserModel, User>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
        }
    }
}