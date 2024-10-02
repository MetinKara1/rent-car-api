using System;
using System.Collections.Generic;
using rent_car_api.DTO;

namespace rent_car_api.DTO
{
	public class CarDto
	{
		public CarDto()
		{
		}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Steering { get; set; }
        public string Detail { get; set; }
        public string SearchKey { get; set; }
        public string ImageUrl { get; set; }
        public string Capacity { get; set; }
        public string Gas { get; set; }
        public string Price { get; set; }
        public string ReviewCount { get; set; }
        public List<ImageDto> Images { get; set; }
        public List<ReviewDto> Reviews { get; set; }
    }
}

