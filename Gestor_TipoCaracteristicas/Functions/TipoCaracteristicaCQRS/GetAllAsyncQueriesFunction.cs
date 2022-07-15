using System.Collections.Generic;
using System.Net;
using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Queries.TipoCaracteristicas;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Gestor_TipoCaracteristicas.Functions.TipoCaracteristicaCQRS;

public class GetAllAsyncQueriesFunction
{
    private readonly ITipoCServicioCQRS _TipoCServiceCQRS;
    private readonly ILogger _logger;
    private const string Route = "TipoCaracteristicasCQRS";

    public GetAllAsyncQueriesFunction(ILoggerFactory loggerFactory, ITipoCServicioCQRS tipoCServiceCQRS)
    {
        _logger = loggerFactory.CreateLogger<ITipoService>();
        _TipoCServiceCQRS = tipoCServiceCQRS;
    }

    

    [Function("GetAllTipoCCQRS")]
    public async Task<HttpResponseData> GetAll(
       [HttpTrigger(AuthorizationLevel.Function, "get", Route = Route)] HttpRequestData req)
    {
        try
        {
            //var queries = await req.ReadFromJsonAsync<GetAllAsyncQueries>();
            var data = await _TipoCServiceCQRS.HandleConsulta(new GetAllAsyncQueries());

            if (data == null)
            {
                var badresponse = req.CreateResponse(System.Net.HttpStatusCode.NotFound);

                await badresponse.WriteAsJsonAsync(badresponse);
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
