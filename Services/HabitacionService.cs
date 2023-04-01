using System.Collections.Generic;
using System.Threading.Tasks;
using GranHotelApi.Models;
using GranHotelApi.Repositories;

namespace GranHotelApi.Services
{
    public class HabitacionService : IHabitacionService
    {
        private readonly IHabitacionRepository _repository;

        public HabitacionService(IHabitacionRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Habitacion>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Habitacion> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Habitacion> AddAsync(Habitacion habitacion)
        {
            return await _repository.AddAsync(habitacion);
        }

        public async Task UpdateAsync(Habitacion habitacion)
        {
            await _repository.UpdateAsync(habitacion);
        }
    }
}
