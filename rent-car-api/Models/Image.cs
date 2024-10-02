using System;
namespace rent_car_api.Models
{
	public class Image
	{
		public Image()
		{
		}

        public int Id { get; set; }
        public string ImageUrl { get; set; } // Resim URL'si
        public int CarId { get; set; } // Hangi araca ait olduğunu gösterir
        public Car Car { get; set; } // Araba nesnesi ile ilişki
    }
}

