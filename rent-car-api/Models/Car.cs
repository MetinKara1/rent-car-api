using System;
namespace rent_car_api.Models
{
	public class Car
	{

        public Car()
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

        // İlişkilendirilmiş images
        public List<Image> Images { get; set; } // Image sınıfını tanımladığından emin ol
        public List<Review> Reviews { get; set; } // Image sınıfını tanımladığından emin ol


    }
}

