using System;
namespace rent_car_api.Models
{
	public class Filter
	{
		public Filter()
		{
		}

        public int Id { get; set; }
        public string Title { get; set; }

        public List<FilterType> FilterTypes { get; set; } 
    }
}

