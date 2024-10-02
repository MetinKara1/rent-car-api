using System;
using Microsoft.AspNetCore.Mvc;
using rent_car_api.Data;
using rent_car_api.Models;
using Microsoft.EntityFrameworkCore;
using rent_car_api.DTO;
using AutoMapper;

namespace rent_car_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly RentCarDbContext _context;
        private readonly IMapper _mapper;

        public CarsController(RentCarDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CarDto>>> GetCars()
        {
            var cars = await _context.Cars
                .Include(c => c.Images) // Images ilişkisini dahil et
                .Include(c => c.Reviews) // Reviews ilişkisini dahil et
                .ToListAsync();

            var carDtos = _mapper.Map<List<CarDto>>(cars);

            return Ok(carDtos);
            // return await _context.Cars.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCars), new { id = car.Id }, car);
        }
    }
}