using System;
using rent_car_api.DTO;
using rent_car_api.Models;
using AutoMapper;
using rent_car_api.Models;
using rent_car_api.DTO;

namespace rent_car_api.Mappings
{
	public class MappingFilter: Profile
	{
        public MappingFilter()
        {
            CreateMap<Filter, FilterDto>()
            .ForMember(dest => dest.FilterTypes, opt => opt.MapFrom(src => src.FilterTypes));

            CreateMap<FilterType, FilterTypeDto>();
        }
    }
}

