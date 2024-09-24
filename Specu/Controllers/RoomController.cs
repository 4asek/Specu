using Microsoft.AspNetCore.Mvc;
using Specu.Application.Entities;

namespace Specu.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private static List<Room> rooms = new List<Room>();
        private static int nextId = 1;

        [HttpGet]
        public ActionResult<IEnumerable<Room>> GetRooms()
        {
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public ActionResult<Room> GetRoom(int id)
        {
            var room = rooms.FirstOrDefault(r => r.Id == id);
            if (room == null) return NotFound();
            return Ok(room);
        }

        [HttpPost]
        public ActionResult<Room> CreateRoom(Room room)
        {
            room.Id = nextId++;
            rooms.Add(room);
            return CreatedAtAction(nameof(GetRoom), new { id = room.Id }, room);
        }
        [HttpGet("search")]
        public ActionResult<IEnumerable<Room>> SearchByName([FromQuery] string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return BadRequest("Щось не так.");
            }

            var filteredRooms = rooms.Where(r => r.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!filteredRooms.Any())
            {
                return NotFound("Немає номерів з такою назвою.");
            }

            return Ok(filteredRooms);
        }
    }
}