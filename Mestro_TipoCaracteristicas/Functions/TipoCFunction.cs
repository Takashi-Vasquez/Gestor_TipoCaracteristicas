using Maestro_TipoCaracteristicas.Contracts;
using Maestro_TipoCaracteristicas.Entities;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace Maaestro_TipoCaracteristicas.Functions;

public class TipoCFunction
{
    private readonly ITipoService _TipoCService;
    private readonly ILogger _logger;
    private const string Route = "TipoCaracteristicas";

    public TipoCFunction(ILoggerFactory loggerFactory, ITipoService tipoCService)
    {
        _logger = loggerFactory.CreateLogger<ITipoService>();
        _TipoCService = tipoCService;

    }
    


    [Function("AddTipoC")]
    public async Task<HttpResponseData> Add(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = Route)] HttpRequestData req)
    {
        try
        {
            var body = await req.ReadFromJsonAsync<TipoCaracteristica>();
            var data = await _TipoCService.createAsyc(body);
            var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
            await response.WriteAsJsonAsync(data);
            return response;
        }
        catch (Exception ex)
        {
            return ExceptionMessage(ex, req);
        }
    }

    [Function("EditTipoC")]
    public async Task<HttpResponseData> Edit(
           [HttpTrigger(AuthorizationLevel.Function, "put", Route = Route)] HttpRequestData req)
    {
        try
        {
            var body = await req.ReadFromJsonAsync<TipoCaracteristica>();
            var data = await _TipoCService.EditAsync(body);
            var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
            await response.WriteAsJsonAsync(data);
            return response;
        }
        catch (Exception ex)
        {
            return ExceptionMessage(ex, req);
        }
    }

    [Function("RemoveTipoC")]
    public async Task<HttpResponseData> Remove(
           [HttpTrigger(AuthorizationLevel.Function, "delete", Route = Route + "/{id}")] HttpRequestData req,
           int id)
    {
        try
        {
            var data = await _TipoCService.RemoveAsync(id);
            var response = req.CreateResponse(System.Net.HttpStatusCode.OK);
            await response.WriteAsJsonAsync(data);
            return response;
        }
        catch (Exception ex)
        {
            return ExceptionMessage(ex, req);
        }
    }

    [Function("GetSingleTipoC")]
    public async Task<HttpResponseData> GetSingle(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = Route + "/{value}")] HttpRequestData req,
        string value)
    {
        try
        {
            var data = await _TipoCService.GetSingleAsync(value);

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
            return ExceptionMessage(ex, req);
        }
    }

    [Function("GetAllTipoC")]
    public async Task<HttpResponseData> GetAll(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = Route)] HttpRequestData req)
    {
        try
        {
            var data = await _TipoCService.GetaAllAsync();

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
            return ExceptionMessage(ex, req);
        }
    }

    #region Class Method Exception
    public HttpResponseData ExceptionMessage(Exception ex, HttpRequestData req)
    {
        _logger.LogError(ex.Message);
        return req.CreateResponse(System.Net.HttpStatusCode.BadRequest);
    }
    #endregion


}

