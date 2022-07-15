
using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Queries.TipoCaracteristicas;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Gestor_TipoCaracteristicas.Functions.TipoCaracteristicaCQRS;

public class GetSingleAsyncQueriesFunction
{
    private readonly ITipoCServicioCQRS _TipoCServiceCQRS;
    private readonly ILogger _logger;
    private const string Route = "TipoCaracteristicasCQRS";

    public GetSingleAsyncQueriesFunction(ILoggerFactory loggerFactory, ITipoCServicioCQRS tipoCServiceCQRS)
    {
        _logger = loggerFactory.CreateLogger<ITipoService>();
        _TipoCServiceCQRS = tipoCServiceCQRS;
    }

    [Function("GetSingleTipoCCQRS")]
    public async Task<HttpResponseData> GetSingle(
    [HttpTrigger(AuthorizationLevel.Function, "get", Route = Route + "/{value}")] HttpRequestData req,
    string value)
    {
        try
        {
            var queries = new GetSingleAsyncQueries(value);
            var data = await _TipoCServiceCQRS.HandleConsulta(queries);

            if (data == null)
            {
                var badresponse = req.CreateResponse(System.Net.HttpStatusCode.NotFound);
                await badresponse.WriteAsJsonAsync(data);
                return badresponse;
            }

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
