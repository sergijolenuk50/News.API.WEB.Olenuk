using AutoMapper;
using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.AutoMapper
{
    public class AutoMapperNewsProFile : Profile
    {
        public AutoMapperNewsProFile()
        {
            CreateMap<NewsDto, News>().ReverseMap();
            CreateMap<RoleDto, Role>().ReverseMap();
            CreateMap<UsersDto, Users>().ReverseMap();
            CreateMap<AuthorDto, Author>().ReverseMap();
            CreateMap<StatisticsDto, Statistics>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();

        }
    }
}
