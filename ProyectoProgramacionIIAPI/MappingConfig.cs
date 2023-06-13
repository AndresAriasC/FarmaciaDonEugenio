using AutoMapper;
using ProyectoProgramacionIIAPI.Models;
using ProyectoProgramacionIIAPI.Models.Dto;

namespace ProyectoProgramacionIIAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig() {

            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();


            //CATEGORY

            CreateMap<Category, CreateCategoryDto>();
            CreateMap<CreateCategoryDto, Category>();

            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
        }
    }
}
