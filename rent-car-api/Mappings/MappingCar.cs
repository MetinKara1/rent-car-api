using System;
using AutoMapper;
using rent_car_api.Mappings;
using rent_car_api.Models;
using rent_car_api.DTO;
namespace rent_car_api.Mappings
{
	public class MappingCar : Profile
    {
		public MappingCar()
		{
            CreateMap<Car, CarDto>()
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.Reviews, opt => opt.MapFrom(src => src.Reviews)); // Reviews için eşleme

            CreateMap<Image, ImageDto>(); 
            CreateMap<Review, ReviewDto>(); 
        }

        
    }
}

