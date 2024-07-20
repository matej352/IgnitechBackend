using AutoMapper;
using IgnitechWebApi.Data.Entities;
using IgnitechWebApi.DTOs;

namespace IgnitechWebApi.Profiles
{
    public class GradeProfile : Profile
    {

        public GradeProfile()
        {
            CreateMap<GradeDto, GradeEntity>();

            CreateMap<GradeEntity, GradeDto>();
        }
    }
}
