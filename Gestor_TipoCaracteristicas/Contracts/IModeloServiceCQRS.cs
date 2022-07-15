using Gestor_TipoCaracteristicas.Comandos.ModeloTipoC;

using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Contracts
{
    public interface IModeloServiceCQRS
    {
        Task<Modelo> HandleComando(CreateModeloTipoCComando comando);
    }
}
