using System;
namespace rent_car_api.Models
{
	public class Review
	{
		public Review()
		{
		}

        public int Id { get; set; }
        public string ReviewerName { get; set; } // Resim URL'si
        public string ReviewerJob { get; set; } // Resim URL'si
        public string Comment { get; set; } // Resim URL'si
        public DateTime Date { get; set; } // Resim URL'si
        public int CarId { get; set; } // Hangi araca ait olduğunu gösterir
        public Car Car { get; set; } // Araba nesnesi ile ilişki
    }
}

