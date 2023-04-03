using System.Collections.Generic;

namespace GranHotelApi.Models
{
    public class Habitacion
    {
        public int Id { get; set; }
        public bool Ocupada { get; set; }

        public ICollection<Huesped>? Huespedes { get; set; }
    }
}
