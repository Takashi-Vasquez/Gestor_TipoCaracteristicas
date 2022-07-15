using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Contracts;

public interface IModeloRepository
{
    Task<Modelo> createModeloAsyc(Modelo tipo);
  

}
