using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Entities;
using Gestor_TipoCaracteristicas.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Gestor_TipoCaracteristicas.Repositories
{
    public class TipoCRepository : ITipoRepository
    {
        private readonly ApiDataContext _context;

        public TipoCRepository(ApiDataContext context)
        {
            _context = context;
        }

        public async Task<PropertyType> createAsyc(PropertyType tipo)
        {
            _context.PropertyTypes.Add(tipo);
            await _context.SaveChangesAsync();

            return await _context.PropertyTypes//.Include(x => x.Modelo)
                .FirstOrDefaultAsync(x => x.Id == tipo.Id); ;
        }

        public async Task<PropertyType> EditAsync(PropertyType tipo)
        {
            _context.PropertyTypes.Update(tipo);
            await _context.SaveChangesAsync();
            return tipo;
        }
        public async Task<bool> RemoveAsync(PropertyType tipo)
        {
            _context.PropertyTypes.Remove(tipo);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<PropertyType> GetSingleAsync(string value)
        {
            bool isNumeric = int.TryParse(value, out int tipoId);
            if (isNumeric)
                return await _context.PropertyTypes//.Include(x => x.Modelo)
                                                         .FirstOrDefaultAsync(x=>x.Id==tipoId);
            else
                return await _context.PropertyTypes//.Where(u => u.Equipo.Contains(value))
                    .FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<PropertyType>> GetAllAsync()
        {
            return await _context.PropertyTypes//.Include(x => x.Modelo)
                .ToListAsync();
        }
    }
}
