using Gestor_TipoCaracteristicas.Comandos.TipoCaracteristicas;
using Gestor_TipoCaracteristicas.Queries.TipoCaracteristicas;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Contracts
{
    public interface ITipoCServicioCQRS
    {
        Task<PropertyType> HandleComando(CreateTipoCComando comando);
        Task<bool> HandleComando(EliminarTipoCaracteristicaComando comando);
        Task<PropertyType> HandleComando(ModificarTipoCaracteristicaComando comando);
       
        Task<PropertyType> HandleConsulta(GetSingleAsyncQueries consulta);
        Task<IEnumerable<PropertyType>> HandleConsulta(GetAllAsyncQueries consulta);
    }
}
