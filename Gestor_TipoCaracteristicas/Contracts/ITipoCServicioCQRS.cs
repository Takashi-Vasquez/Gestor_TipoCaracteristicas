using Gestor_TipoCaracteristicas.Comandos.TipoCaracteristicas;
using Gestor_TipoCaracteristicas.Queries.TipoCaracteristicas;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Contracts
{
    public interface ITipoCServicioCQRS
    {
        Task<TipoCaracteristica> HandleComando(CreateTipoCaracteristicaComando comando);
        Task<bool> HandleComando(EliminarTipoCaracteristicaComando comando);
        Task<TipoCaracteristica> HandleComando(ModificarTipoCaracteristicaComando comando);
       
        Task<TipoCaracteristica> HandleConsulta(GetSingleAsyncQueries consulta);
        Task<IEnumerable<TipoCaracteristica>> HandleConsulta(GetAllAsyncQueries consulta);
    }
}
