using System;
namespace rent_car_api.DTO
{
	public class FilterTypeDto
	{
		public FilterTypeDto()
		{
		}

        public int Id { get; set; }
        public string Text { get; set; }
        public bool Is_Selected { get; set; }
    }
}

