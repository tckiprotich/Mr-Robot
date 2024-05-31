using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mr_Robot.Data;
using Mr_Robot.Models;

namespace Mr_Robot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class createSeasons : ControllerBase
    {
        private readonly AppDbContext _context;
        public createSeasons(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpPost("createSeason")]
        
        public IActionResult createSeason(SeasonModel season)
        {
            var season1 = new SeasonModel
            {
                Id = 1,
                SeasonNumber = 1,
                NumberOfEpisodes = 10,
                FirstAired = new DateTime(2015, 6, 24),
                LastAired = new DateTime(2015, 9, 2)
            };

            var season2 = new SeasonModel
            {
                Id = 2,
                SeasonNumber = 2,
                NumberOfEpisodes = 12,
                FirstAired = new DateTime(2016, 7, 13),
                LastAired = new DateTime(2016, 9, 21)
            };

            var season3 = new SeasonModel
            {
                Id = 3,
                SeasonNumber = 3,
                NumberOfEpisodes = 10,
                FirstAired = new DateTime(2017, 10, 11),
                LastAired = new DateTime(2017, 12, 13)
            };

            var season4 = new SeasonModel
            {
                Id = 4,
                SeasonNumber = 4,
                NumberOfEpisodes = 13,
                FirstAired = new DateTime(2019, 10, 6),
                LastAired = new DateTime(2019, 12, 22)
            };

            _context.Seasons.Add(season1);
            _context.Seasons.Add(season2);
            _context.Seasons.Add(season3);
            _context.Seasons.Add(season4);

            _context.SaveChanges(); 

            return Ok(_context.Seasons.ToList());
        }

        [HttpGet("getSeasons")]
        public IActionResult getSeasons()
        {
            var response = _context.Seasons.ToList();
            return Ok(response);
        }
    }
}