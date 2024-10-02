using System;
namespace rent_car_api.DTO
{
	public class FilterDto
	{
		public FilterDto()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }
        public List<FilterTypeDto> FilterTypes { get; set; }
    }
}

