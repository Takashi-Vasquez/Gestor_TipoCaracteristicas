using Gestor_TipoCaracteristicas.Entities;


namespace Gestor_TipoCaracteristicas.Contracts
{
    public interface ITipoService
    {
        Task<PropertyType> createAsyc(PropertyType tipo);
        Task<PropertyType> EditAsync(PropertyType tipo);
        Task<bool> RemoveAsync(int id);
        Task<PropertyType> GetSingleAsync(string value);
        Task<IEnumerable<PropertyType>> GetAllAsync();

    }
}
