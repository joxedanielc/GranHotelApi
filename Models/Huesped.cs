using System;

namespace GranHotelApi.Models
{
    public class Huesped
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Identificacion { get; set; }
        public int HabitacionId { get; set; }
        public DateTime Ingreso { get; set; }
        public DateTime? Salida { get; set; }

        public Habitacion? Habitacion { get; set; }
    }
}
