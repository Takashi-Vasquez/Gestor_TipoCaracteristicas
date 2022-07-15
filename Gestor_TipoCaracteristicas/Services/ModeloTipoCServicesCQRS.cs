using Gestor_TipoCaracteristicas.Comandos.ModeloTipoC;
using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Services
{
    public class ModeloTipoCServicesCQRS : IModeloServiceCQRS
    {
        private readonly IModeloRepository _tipoRepository;
        public ModeloTipoCServicesCQRS(IModeloRepository tipoRepository)
        {
            _tipoRepository = tipoRepository;
        }

        public async Task<Modelo> HandleComando(CreateModeloTipoCComando comando)
        {
            var tipoM = new Modelo
            {
                Nombre = comando.nombre,
            };
            return await _tipoRepository.createModeloAsyc(tipoM);
        }
    }
}
