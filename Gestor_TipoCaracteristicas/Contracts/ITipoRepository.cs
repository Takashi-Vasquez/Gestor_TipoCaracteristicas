using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Contracts
{
    public interface ITipoRepository
    {
        Task<TipoCaracteristica> createAsyc(TipoCaracteristica tipo);
        Task<TipoCaracteristica> EditAsync(TipoCaracteristica tipo);
        Task<bool> RemoveAsync(TipoCaracteristica tipo);
        Task<TipoCaracteristica> GetSingleAsync(string value);
        Task<IEnumerable<TipoCaracteristica>> GetAllAsync();

    }
}
