using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEnumerable<Event> _events = new Event[]
        {
            new Event
            {
                Id             = 1,
                Batch          = "Primeiro lote",
                DateEvent      = new System.DateTime(2022, 6, 30),
                QuantityPeople = 250,
                Local          = "Rio de Janeiro",
                Theme          = "Angular 11 + .Net Core 5",
                ImageUrl       = "Photo.png"
            },
            new Event
            {
                Id             = 4,
                Batch          = "Nono lote",
                DateEvent      = new System.DateTime(2022, 7, 8),
                QuantityPeople = 345,
                Local          = "Sao Paulo",
                Theme          = "Angular e suas novidades",
                ImageUrl       = "Self.png"
            }
        };

        public EventController()
        {
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _events;
        }

        [HttpGet("{id}")]
        public Event Get(int id)
        {
            return _events.FirstOrDefault(f => f.Id == id);
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
