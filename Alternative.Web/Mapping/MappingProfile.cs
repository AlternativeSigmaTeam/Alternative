using System.IO;
using System.Linq;
using Alternative.BLL.DtoEntities;
using Alternative.Model.Entities;
using Alternative.Web.ViewModels;
using Alternative.Web.ViewModels.DomainEntitysViewModel;
using AutoMapper;

namespace Alternative.Web.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ReverseMap();

            CreateMap<Model.Entities.Alternative, AlternativeViewModel>()
                .ForMember(x=>x.Priority, w=>w.MapFrom(x=>x.UsersAlternatives.FirstOrDefault().Priority)).ReverseMap();

            CreateMap<Teacher, TeacherViewModel>()
                .ForMember(x => x.TeacherId, w => w.MapFrom(x => x.Id))
                .ForMember(x => x.Photo, w => w.Ignore())
                .ForMember(x => x.PhotoByte, x => x.MapFrom(w => w.Photo))
                .ForMember(x => x.SelectedUser, w => w.MapFrom(x => x.UserId));

            CreateMap<TeacherViewModel, Teacher>()
                .ForMember(x => x.Photo, w => w.Ignore());

            CreateMap<Specialty, SpecialtyViewModel>().ForMember(x=>x.SpecialtyId, x=>x.MapFrom(w=>w.Id)).ReverseMap();

            CreateMap<FilterViewModel, FilterDto>().ReverseMap();

            CreateMap<AlternativeFilterViewModel, UserAlternativeDto>()
                .ForMember(x=>x.AlternativeId, w=>w.MapFrom(x=>x.Id)).ReverseMap();
        }

    }
}
