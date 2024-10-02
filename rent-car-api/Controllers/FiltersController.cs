using System;
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
    public class FiltersController: ControllerBase
	{

        private readonly RentCarDbContext _context;
        private readonly IMapper _mapper;
        public FiltersController(RentCarDbContext context, IMapper mapper)
		{
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<FilterDto>>> GetFilters()
        {
            var filters = await _context.Filters
                .Include(c => c.FilterTypes)
                .ToListAsync();

            var filterDtos = _mapper.Map<List<FilterDto>>(filters);

            return Ok(filterDtos);
            // return await _context.Cars.ToListAsync();
        }
    }
}

