// Services/HuespedService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using GranHotelApi.Models;
using GranHotelApi.Repositories;

namespace GranHotelApi.Services
{
    public class HuespedService : IHuespedService
    {
        private readonly IHuespedRepository _repository;

        public HuespedService(IHuespedRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Huesped>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Huesped> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Huesped> AddAsync(Huesped huesped)
        {
            return await _repository.AddAsync(huesped);
        }

        public async Task<Huesped> UpdateAsync(Huesped huesped)
        {
            return await _repository.UpdateAsync(huesped);
        }

        public async Task<IEnumerable<Huesped>> GetAllCurrentHuespedes()
        {
            IEnumerable<Huesped> huespedes = await _repository.GetAllAsync();
            IEnumerable<Huesped> currentHuespedes = huespedes.Where(x => x.Habitacion.Ocupada == true);

            return currentHuespedes;
        }
    }
}
