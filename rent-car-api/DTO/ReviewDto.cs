using System;
namespace rent_car_api.DTO
{
	public class ReviewDto
	{
		public ReviewDto()
		{
		}

        public int Id { get; set; }
        public string ReviewerName { get; set; }
        public string ReviewerJob { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}

