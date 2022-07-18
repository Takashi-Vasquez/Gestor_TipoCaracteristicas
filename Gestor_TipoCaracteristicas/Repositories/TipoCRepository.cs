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

        public async Task<TipoCaracteristica> createAsyc(TipoCaracteristica tipo)
        {
            _context.TipoCaracteristicas.Add(tipo);
            await _context.SaveChangesAsync();

            return await _context.TipoCaracteristicas//.Include(x => x.Modelo)
                .FirstOrDefaultAsync(x => x.Id == tipo.Id); ;
        }

        public async Task<TipoCaracteristica> EditAsync(TipoCaracteristica tipo)
        {
            _context.TipoCaracteristicas.Update(tipo);
            await _context.SaveChangesAsync();
            return tipo;
        }
        public async Task<bool> RemoveAsync(TipoCaracteristica tipo)
        {
            _context.TipoCaracteristicas.Remove(tipo);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<TipoCaracteristica> GetSingleAsync(string value)
        {
            bool isNumeric = int.TryParse(value, out int tipoId);
            if (isNumeric)
                return await _context.TipoCaracteristicas//.Include(x => x.Modelo)
                                                         .FirstOrDefaultAsync(x=>x.Id==tipoId);
            else
                return await _context.TipoCaracteristicas//.Where(u => u.Equipo.Contains(value))
                    .FirstOrDefaultAsync();

        }

        public async Task<IEnumerable<TipoCaracteristica>> GetAllAsync()
        {
            return await _context.TipoCaracteristicas//.Include(x => x.Modelo)
                .ToListAsync();
        }
    }
}
