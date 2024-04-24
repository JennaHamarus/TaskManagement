using AutoMapper;
using backend.Core.Context;
using backend.Core.Dtos.Activity;
using backend.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private ApplicationDbContext _context { get; }
        private IMapper _mapper {  get; }
        public ActivityController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        //CRUD

        //Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateActivity([FromBody] ActivityCreateDto dto)
        {
          Activity newActivity = _mapper.Map<Activity>(dto);
            await _context.Activities.AddAsync(newActivity);
            await _context.SaveChangesAsync();

            return Ok("Activity created successfully");
        }

        //Read
        [HttpGet]
        [Route("Get")]
        public async Task<ActionResult<IEnumerable<ActivityGetDto>>> GetActivities()
        {
            var activities = await _context.Activities.OrderByDescending(q => q.CreatedAt).ToListAsync();
            var convertedActivities = _mapper.Map<IEnumerable<ActivityGetDto>>(activities);

            return Ok(convertedActivities);
        }

        // Read (Get Company By ID)

        //Update

        //Delete
    }
}
