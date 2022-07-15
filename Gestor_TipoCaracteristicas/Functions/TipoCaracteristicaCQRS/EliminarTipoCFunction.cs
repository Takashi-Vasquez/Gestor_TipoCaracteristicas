using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Comandos.TipoCaracteristicas;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Gestor_TipoCaracteristicas.Functions.TipoCaracteristicaCQRS;

public class EliminarTipoCFunction
{
    private readonly ITipoCServicioCQRS _TipoCServiceCQRS;
    private readonly ILogger _logger;
    private const string Route = "TipoCaracteristicasCQRS";

    public EliminarTipoCFunction(ILoggerFactory loggerFactory, ITipoCServicioCQRS tipoCServiceCQRS)
    {
        _logger = loggerFactory.CreateLogger<ITipoService>();
        _TipoCServiceCQRS = tipoCServiceCQRS;

    }

    [Function("RemoveTipoCCQRS")]
    public async Task<HttpResponseData> Remove(
        [HttpTrigger(AuthorizationLevel.Function, "delete", Route = Route + "/{id}")] HttpRequestData req,
        int id)
    {
        try
        {
            //var command = await req.ReadFromJsonAsync<EliminarTipoCaracteristicaComando>();

            var data = await _TipoCServiceCQRS.HandleComando(new EliminarTipoCaracteristicaComando(id));
            var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
            await response.WriteAsJsonAsync(data);
            return response;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex.Message);
            return req.CreateResponse(System.Net.HttpStatusCode.BadRequest);
        }
    }
}
