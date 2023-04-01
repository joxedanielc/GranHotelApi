using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GranHotelApi.Models;
using GranHotelApi.Data;

namespace GranHotelApi.Repositories
{
    public class HabitacionRepository : IHabitacionRepository
    {
        private readonly GranHotelContext _context;

        public HabitacionRepository(GranHotelContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Habitacion>> GetAllAsync()
        {
            return await _context.Habitaciones.ToListAsync();
        }

        public async Task<Habitacion> GetByIdAsync(int id)
        {
            return await _context.Habitaciones.FindAsync(id);
        }

        public async Task<Habitacion> AddAsync(Habitacion habitacion)
        {
            _context.Habitaciones.Add(habitacion);
            await _context.SaveChangesAsync();
            return habitacion;
        }

        public async Task UpdateAsync(Habitacion habitacion)
        {
            _context.Entry(habitacion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Habitaciones.AnyAsync(e => e.Id == id);
        }
    }
}
