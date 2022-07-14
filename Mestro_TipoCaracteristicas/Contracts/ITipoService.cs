using Maestro_TipoCaracteristicas.Entities;


namespace Maestro_TipoCaracteristicas.Contracts
{
    public interface ITipoService
    {
        Task<TipoCaracteristica> createAsyc(TipoCaracteristica tipo);
        Task<TipoCaracteristica> EditAsync(TipoCaracteristica tipo);
        Task<bool> RemoveAsync(int id);
        Task<TipoCaracteristica> GetSingleAsync(string value);
        Task<IEnumerable<TipoCaracteristica>> GetaAllAsync();

    }
}
