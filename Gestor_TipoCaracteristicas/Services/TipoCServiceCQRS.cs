using Gestor_TipoCaracteristicas.Comandos.TipoCaracteristicas;
using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Entities;
using Gestor_TipoCaracteristicas.Queries.TipoCaracteristicas;

namespace Gestor_TipoCaracteristicas.Services;

internal class TipoCServiceCQRS : ITipoCServicioCQRS
{
    private readonly ITipoRepository _tipoRepository;
    public TipoCServiceCQRS(ITipoRepository tipoRepository)
    {
        _tipoRepository = tipoRepository;
    }

    public async Task<TipoCaracteristica> HandleComando(CreateTipoCComando comando)
    {
         var tipoC = new TipoCaracteristica
            {
                Equipo = comando.Equipo,
                Abreviatura = comando.Abreviatura,
                ModeloId = comando.ModeloId,
            };
            return await _tipoRepository.createAsyc(tipoC);
    }
    public async Task<TipoCaracteristica> HandleComando(ModificarTipoCaracteristicaComando comando)
    {
        var tipoCUpdate = await _tipoRepository.GetSingleAsync(comando.Id.ToString());
        tipoCUpdate.Abreviatura = comando.Abreviatura;
        tipoCUpdate.Equipo = comando.Equipo;
        tipoCUpdate.ModeloId = comando.ModeloId;

        return await _tipoRepository.EditAsync(tipoCUpdate);
    }

    public async Task<bool> HandleComando(EliminarTipoCaracteristicaComando comando)
    {
        var tipoCDelete = _tipoRepository.GetSingleAsync(comando.Id.ToString());
        return await _tipoRepository.RemoveAsync(tipoCDelete.Result);
    }


    public async Task<TipoCaracteristica> HandleConsulta(GetSingleAsyncQueries consulta)
    {
        return await _tipoRepository.GetSingleAsync(consulta.value);
    }

    public async Task<IEnumerable<TipoCaracteristica>> HandleConsulta(GetAllAsyncQueries consulta)
    {
        return await _tipoRepository.GetAllAsync();
    }
}
