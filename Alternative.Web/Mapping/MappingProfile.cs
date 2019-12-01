using Alternative.Model.Entities;
using Alternative.Web.ViewModels;
using AutoMapper;

namespace Alternative.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }

    }
}
