using System;
namespace rent_car_api.Models
{
	public class FilterType
	{
		public FilterType()
		{
		}

        public int Id { get; set; }
        public string Text { get; set; } 
        public bool Is_Selected { get; set; } 
        public int FilterId { get; set; } 
        public Filter Filter { get; set; } 
    }
}

