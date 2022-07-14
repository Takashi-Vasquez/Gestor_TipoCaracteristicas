using Maestro_TipoCaracteristicas.Entities;

namespace Maestro_TipoCaracteristicas.Contracts
{
    public interface ITipoRepository
    {
        Task<TipoCaracteristica> createAsyc(TipoCaracteristica tipo);
        Task<TipoCaracteristica> EditAsync(TipoCaracteristica tipo);
        Task<bool> RemoveAsync(TipoCaracteristica tipo);
        Task<TipoCaracteristica> GetSingleAsync(string value);
        Task<IEnumerable<TipoCaracteristica>> GetaAllAsync();

    }
}
