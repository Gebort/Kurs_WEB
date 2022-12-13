using CW.Server.Model;
using CW.Shared;
using CW.Shared.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CW.Server.Controllers {
    [ApiController]
    [Route("api")]
    public class GuestController : ControllerBase {
        private readonly ApplicationContext context;

        public GuestController(ApplicationContext context) {
            this.context = context;
        }

        [Route("byauthor")]
        [HttpGet("{author}")]
        public async Task<ActionResult<Writing[]>> GetWritingsByAuthor([FromQuery] string author) {
            var writings = await context.Writings.Where(o => o.Author == author).ToArrayAsync();
            if (!writings.Any()) return NotFound();
            return writings;
        }

        [Route("getwriting")]
        [HttpGet]
        public async Task<ActionResult<Writing[]>> GetWriting([FromQuery] int id) {
            var writings = await context.Writings.Where(o => o.Id == id).ToArrayAsync();
            if (!writings.Any()) return NotFound();
            return writings;
        }


        [Route("search")]
        [HttpGet]
        public async Task<ActionResult<Writing[]>> GetWritingsByQuery([FromQuery] string genres, [FromQuery] string title) {
            IQueryable<Writing> query = context.Writings.AsQueryable();
            if (title != null && title != string.Empty) {
                query = query.Where(o => o.Title.Contains(title));
            }
            if (genres != null && genres != string.Empty) {
                query = query.Where(o => o.Genres.Contains(genres));
            }
            var writings = await query.ToArrayAsync();
            if (!writings.Any()) return NotFound();
            return writings;
        }

    }
}
