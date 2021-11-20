using System;

namespace ReservationSystem.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Place { get; set; }
        public DateTime Date { get; set; }
        public bool Approved { get; set; }
    }

}