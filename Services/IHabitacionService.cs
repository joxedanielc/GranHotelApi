using System.Collections.Generic;
using System.Threading.Tasks;
using GranHotelApi.Models;

namespace GranHotelApi.Services
{
    public interface IHabitacionService
    {
        Task<IEnumerable<Habitacion>> GetAllAsync();
        Task<Habitacion> GetByIdAsync(int id);
        Task<Habitacion> AddAsync(Habitacion habitacion);
        Task UpdateAsync(Habitacion habitacion);
    }
}
