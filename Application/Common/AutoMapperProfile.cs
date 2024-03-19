using Application.DTOs.StudentDtos;
using AutoMapper;
using Domain;

namespace Application.Common;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Student, StudentDto>()
            .ForMember(dest => dest.AvatarUrl, opt => opt.MapFrom(src => src.AvatarUrl))
            .ReverseMap();

    }

}
