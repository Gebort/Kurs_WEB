using CW.Server.Model;
using CW.Shared.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CW.Server.Controllers {

    [Authorize] // контроллер требует авторизации для выполнения действий
    [ApiController] // аттрибут контроллера
    [Route("user")] // путь маршрутизации контроллера
    public class UserController : ControllerBase {

        private readonly ApplicationContext context;

        public UserController(ApplicationContext context) {
            this.context = context;
        }

        [Route("getwriting")] // путь маршрутизации действия
        [HttpGet("{id}")]
        // получить информацию о фанфике
        public async Task<ActionResult<Writing[]>> GetWriting([FromQuery] int id) {
            var writings = await context.Writings.Where(o => o.Id == id).ToArrayAsync();
            if (!writings.Any()) return NotFound();
            return writings;
        }

        [Route("addwriting")]
        [HttpPost]
        // добавить фанфик
        public async Task<ActionResult<Writing>> AddWriting(Writing writing) {
            context.Add(writing);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetWriting), new { id = writing.Id }, writing);
        }

        [Route("editwriting")]
        [HttpPatch]
        // изменить фанфик
        public async Task<ActionResult<Writing>> EditWriting([FromBody] Writing writing) {
            Writing oldWriting;
            try {
                oldWriting = context.Writings.Where(o => o.Id == writing.Id).First();
            } catch {
                return StatusCode(500); // Внутренняя ошибка сервера
            }
            if (User.Identity.Name != oldWriting.Author) {
                return StatusCode(403); // Отказано в доступе
            }
            context.Entry(oldWriting).CurrentValues.SetValues(writing);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetWriting), new { id = writing.Id }, writing);
        }

        [Route("deletewriting")]
        [HttpDelete]
        // удалить фанфик
        public async Task<ActionResult<Writing>> DeleteWriting([FromQuery] int id) {
            Writing oldWriting;
            try {
                oldWriting = context.Writings.Where(o => o.Id == id).First();
            } catch {
                return StatusCode(500); // Внутренняя ошибка сервера
            }
            if (User.Identity.Name != oldWriting.Author) {
                return StatusCode(403); // Отказано в доступе
            }
            context.Writings.Remove(oldWriting);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetWriting), id);
        }
    }
} 
