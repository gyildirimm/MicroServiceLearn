using AutoMapper;
using MicroServiceProject.Services.Catalog.Dtos;
using MicroServiceProject.Services.Catalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroServiceProject.Services.Catalog.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {

            CreateMap<Course, CourseDto>().ReverseMap();
            CreateMap<Course, CourseCreateDto>().ReverseMap();
            CreateMap<Course, CourseUpdateDto>().ReverseMap();

            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Feature, FeatureDto>().ReverseMap();
            
        }
    }
}
