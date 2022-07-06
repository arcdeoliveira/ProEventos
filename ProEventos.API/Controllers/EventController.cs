using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;
using ProEventos.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events.AsNoTracking();
        }

        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _context.Events.Find(id);
        }

        [HttpPost]
        public string Post()
        {
            return "Example for post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Example for put = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Example for delete = {id}";
        }
    }
}
