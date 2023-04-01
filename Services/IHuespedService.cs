using System.Collections.Generic;
using System.Threading.Tasks;
using GranHotelApi.Models;

namespace GranHotelApi.Services
{
    public interface IHuespedService
    {
        Task<IEnumerable<Huesped>> GetAllAsync();
        Task<Huesped> GetByIdAsync(int id);
        Task<Huesped> AddAsync(Huesped huesped);
        Task<Huesped> UpdateAsync(Huesped huesped);
        Task<IEnumerable<Huesped>> GetAllCurrentHuespedes();
    }
}
