using System.Collections.Generic;
using System.Linq;
using System.Net;

using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using RMotownFestival.Api.DAL;
using RMotownFestival.Api.Domain;

namespace RMotownFestival.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FestivalController : ControllerBase
    {
        private readonly MotownDbContext _context;
        private readonly TelemetryClient _telemetryClient;

        public FestivalController(MotownDbContext context, TelemetryClient telemetryClient)
        {
            _context = context;
            _telemetryClient = telemetryClient;
        }

        [HttpGet("LineUp")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(Schedule))]
        public ActionResult GetLineUp()
        {
            var lineUp = _context.Set<Schedule>()
                .Include(x => x.Items).ThenInclude(x => x.Artist)
                .Include(x => x.Items).ThenInclude(x => x.Stage)
                .Single();

            return Ok(lineUp);
        }

        [HttpGet("Artists")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Artist>))]
        public ActionResult GetArtists(bool? withRatings)
        {
            if (withRatings.HasValue && withRatings.Value)
                _telemetryClient.TrackEvent("List of artists with ratings.");
            else
                _telemetryClient.TrackEvent("List of artists without ratings.");

            return Ok(_context.Set<Artist>());
        }

        [HttpGet("Stages")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Stage>))]
        public ActionResult GetStages()
        {
            return Ok(_context.Set<Stage>());
        }

        [HttpPost("Favorite")]
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(ScheduleItem))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public ActionResult SetAsFavorite(int id)
        {
            var schedule = _context.Set<ScheduleItem>()
                .FirstOrDefault(si => si.Id == id);
            if (schedule == null)
                return NotFound();

            schedule.IsFavorite = !schedule.IsFavorite;
            _context.SaveChanges();
            return Ok(schedule);
        }

    }
}