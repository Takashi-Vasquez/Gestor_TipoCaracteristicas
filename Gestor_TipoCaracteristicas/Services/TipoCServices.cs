using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Entities;

namespace Gestor_TipoCaracteristicas.Services
{
    public class TipoCServices : ITipoService
    {
        private readonly ITipoRepository _tipoRepository;

        public TipoCServices(ITipoRepository tipoRepository)
        {
            _tipoRepository = tipoRepository;
        }

        public async Task<TipoCaracteristica> createAsyc(TipoCaracteristica tipo)
        {
            var tipoC = new TipoCaracteristica
            {
                //Equipo = tipo.Equipo,
                //Abreviatura = tipo.Abreviatura
            };
            return await _tipoRepository.createAsyc(tipoC);
        }

        public async Task<TipoCaracteristica> EditAsync(TipoCaracteristica tipo)
        {
            var tipoCUpdate = await _tipoRepository.GetSingleAsync(tipo.Id.ToString());
            //tipoCUpdate.Abreviatura = tipo.Abreviatura;
            //tipoCUpdate.Equipo = tipo.Equipo;
            return await _tipoRepository.EditAsync(tipoCUpdate);
        }

        public async Task<bool> RemoveAsync(int id)
        {
            var tipoCDelete =  _tipoRepository.GetSingleAsync(id.ToString());
            return await _tipoRepository.RemoveAsync(tipoCDelete.Result);

        }

        public async Task<TipoCaracteristica> GetSingleAsync(string value)
        {
            return await _tipoRepository.GetSingleAsync(value);
        }

        public async Task<IEnumerable<TipoCaracteristica>> GetAllAsync()
        {
            return await _tipoRepository.GetAllAsync(); ;
        }
    }
}
