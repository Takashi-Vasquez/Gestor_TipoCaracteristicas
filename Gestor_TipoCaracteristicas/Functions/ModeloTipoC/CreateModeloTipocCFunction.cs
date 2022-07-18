using System.Net;
using Gestor_TipoCaracteristicas.Contracts;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Gestor_TipoCaracteristicas.Comandos.ModeloTipoC;


namespace Gestor_TipoCaracteristicas.Functions.ModeloTipoC
{
    public class CreateModeloTipocCFunction
    {
        private readonly IModeloServiceCQRS _ModeloServiceCQRS;
        private readonly ILogger _logger;
        private const string Route = "ModeloCQRS";

        public CreateModeloTipocCFunction(ILoggerFactory loggerFactory, IModeloServiceCQRS ModeloServiceCQRS)
        {
            _logger = loggerFactory.CreateLogger<ITipoService>();
            _ModeloServiceCQRS = ModeloServiceCQRS;

        }
        /*
        [Function("AddModeloCQRS")]
        public async Task<HttpResponseData> Add(
        [HttpTrigger(AuthorizationLevel.Function, "post", Route = Route)] HttpRequestData req)
        {
            try
            {
                var command = await req.ReadFromJsonAsync<CreateModeloTipoCComando>();
                var data = await _ModeloServiceCQRS.HandleComando(command!);
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
        */
    }
}
