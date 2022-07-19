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

        public async Task<PropertyType> createAsyc(PropertyType tipo)
        {
            var tipoC = new PropertyType
            {
                //Equipo = tipo.Equipo,
                //Abreviatura = tipo.Abreviatura
            };
            return await _tipoRepository.createAsyc(tipoC);
        }

        public async Task<PropertyType> EditAsync(PropertyType tipo)
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

        public async Task<PropertyType> GetSingleAsync(string value)
        {
            return await _tipoRepository.GetSingleAsync(value);
        }

        public async Task<IEnumerable<PropertyType>> GetAllAsync()
        {
            return await _tipoRepository.GetAllAsync(); ;
        }
    }
}
