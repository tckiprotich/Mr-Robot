using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mr_Robot.Models;

namespace Mr_Robot.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class addEpisodesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public addEpisodesController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("addEpisode/{seasonId}")]
        public async Task<ActionResult<List<EpisodesModel>>> PostEpisode([FromRoute] int seasonId, [FromBody] List<EpisodesModel> episodes)
        {
            Console.WriteLine("Adding episodes to season with id: " + seasonId);
            foreach (var episode in episodes)
            {
                episode.seasonId = seasonId;
                episode.Season = _context.Seasons.Find(seasonId);
                Console.WriteLine("Adding episode: " + episode.Title);

                // we are just testin g lets clear episodes modelsdata
                // _context.Episodes.RemoveRange(_context.Episodes);
                // await _context.SaveChangesAsync();

                _context.Episodes.Add(episode);
                await _context.SaveChangesAsync();
            }

            return Ok(_context.Episodes);
        }







        [HttpGet]
[Route("getEpisodes")]
public async Task<ActionResult<List<EpisodesModel>>> GetEpisodes()
{
    var response = await _context.Episodes.Include(e => e.Season).ToListAsync();
    return Ok(response);
}
    }
}