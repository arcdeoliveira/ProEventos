using System;

namespace ProEventos.API.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public DateTime DateEvent { get; set; }
        public string Theme { get; set; }
        public int QuantityPeople { get; set; }
        public string Batch { get; set; }
        public string ImageUrl { get; set; }
    }
}
