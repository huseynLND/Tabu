using AutoMapper;
using FirstAPI.DTOs.Languages;
using FirstAPI.Entities;
namespace FirstAPI.Profiles;

public class LanguageProfile : Profile
{
    public LanguageProfile()
    {
        CreateMap<LanguageCreateDTO, Language>().ForMember(x=> x.Icon, y=> y.MapFrom(z=> z.IconUrl));
        CreateMap<Language, LanguageGetDto>();
    }
}
