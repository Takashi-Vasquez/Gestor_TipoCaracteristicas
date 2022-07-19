using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Contracts
{
    public interface ITipoRepository
    {
        Task<PropertyType> createAsyc(PropertyType tipo);
        Task<PropertyType> EditAsync(PropertyType tipo);
        Task<bool> RemoveAsync(PropertyType tipo);
        Task<PropertyType> GetSingleAsync(string value);
        Task<IEnumerable<PropertyType>> GetAllAsync();

    }
}
