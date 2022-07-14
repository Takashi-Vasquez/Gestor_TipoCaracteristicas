using Gestor_TipoCaracteristicas.Entities;


namespace Gestor_TipoCaracteristicas.Contracts
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
