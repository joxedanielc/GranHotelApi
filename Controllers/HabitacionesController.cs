using GranHotelApi.Models;
using GranHotelApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GranHotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionesController : ControllerBase
    {
        private readonly IHabitacionService _habitacionService;

        public HabitacionesController(IHabitacionService habitacionService)
        {
            _habitacionService = habitacionService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<int>>> GetHabitacionesDisponibles()
        {
            IEnumerable<Habitacion> habitaciones = await _habitacionService.GetAllAsync();
            IEnumerable<int> habitacionesDisponibles = habitaciones
                .Where(h => h.Ocupada == false)
                .Select(h => h.Id);

            return Ok(habitacionesDisponibles);
        }

    }
}
