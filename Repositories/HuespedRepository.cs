using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GranHotelApi.Models;
using GranHotelApi.Data;

namespace GranHotelApi.Repositories
{
    public class HuespedRepository : IHuespedRepository
    {
        private readonly GranHotelContext _context;

        public HuespedRepository(GranHotelContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Huesped>> GetAllAsync()
        {
            return await _context.Huespedes.ToListAsync();
        }

        public async Task<Huesped> GetByIdAsync(int id)
        {
            return await _context.Huespedes.FindAsync(id);
        }

        public async Task<Huesped> AddAsync(Huesped huesped)
        {
            _context.Huespedes.Add(huesped);
            await _context.SaveChangesAsync();
            return huesped;
        }

        public async Task<Huesped> UpdateAsync(Huesped huesped)
        {
            _context.Entry(huesped).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return huesped;
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await _context.Huespedes.AnyAsync(e => e.Id == id);
        }
    }
}
