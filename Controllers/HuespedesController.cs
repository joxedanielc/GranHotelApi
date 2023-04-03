using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GranHotelApi.Models;
using GranHotelApi.Services;

namespace GranHotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HuespedesController : ControllerBase
    {
        private readonly IHuespedService _huespedService;
        private readonly IHabitacionService _habitacionService;

        public HuespedesController(IHuespedService service, IHabitacionService habitacionService)
        {
            _huespedService = service;
            _habitacionService = habitacionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Huesped>>> GetHabitacionesAlquiladas()
        {
            IEnumerable<Huesped> currentHuespedes = await _huespedService.GetAllCurrentHuespedes();
            
            return Ok(currentHuespedes);
        }


        [HttpPost("CheckIn")]
        public async Task<ActionResult<Huesped>> CheckInHuesped(Huesped huesped)
        {
            Habitacion habitacionDisponible = await _habitacionService.GetByIdAsync(huesped.HabitacionId);

            if (habitacionDisponible == null)
            {
                return BadRequest("No hay habitaciones disponibles.");
            }

            habitacionDisponible.Ocupada = true;
            await _habitacionService.UpdateAsync(habitacionDisponible);

            huesped.HabitacionId = habitacionDisponible.Id;
            huesped.Ingreso = DateTime.UtcNow;
            await _huespedService.AddAsync(huesped);

            return Ok(new { id = huesped.Id });

        }

        [HttpPut("CheckOut/{id}")]
        public async Task<IActionResult> CheckOutHuesped(int id)
        {
            var huesped = await _huespedService.GetByIdAsync(id);

            if (huesped == null)
            {
                return NotFound();
            }

            huesped.Salida = DateTime.UtcNow;
            await _huespedService.UpdateAsync(huesped);

            var habitacion = await _habitacionService.GetByIdAsync(huesped.HabitacionId);
            habitacion.Ocupada = false;
            await _habitacionService.UpdateAsync(habitacion);

            return NoContent();
        }
    }
}
