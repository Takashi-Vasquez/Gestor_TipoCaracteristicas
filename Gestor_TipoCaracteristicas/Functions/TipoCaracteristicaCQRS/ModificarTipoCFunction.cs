using Gestor_TipoCaracteristicas.Contracts;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Gestor_TipoCaracteristicas.Comandos.TipoCaracteristicas;

namespace Gestor_TipoCaracteristicas.Functions.TipoCaracteristicaCQRS;

public class ModificarTipoCFunction
{
    private readonly ITipoCServicioCQRS _TipoCServiceCQRS;
    private readonly ILogger _logger;
    private const string Route = "TipoCaracteristicasCQRS";

    public ModificarTipoCFunction(ILoggerFactory loggerFactory, ITipoCServicioCQRS tipoCServiceCQRS)
    {
        _logger = loggerFactory.CreateLogger<ITipoService>();
        _TipoCServiceCQRS = tipoCServiceCQRS;

    }



    [Function("EditTipoCCQRS")]
    public async Task<HttpResponseData> Edit(
       [HttpTrigger(AuthorizationLevel.Function, "put", Route = Route)] HttpRequestData req)
    {
        try
        {
            var body = await req.ReadFromJsonAsync<ModificarTipoCaracteristicaComando>();
            var data = await _TipoCServiceCQRS.HandleComando(body);
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
