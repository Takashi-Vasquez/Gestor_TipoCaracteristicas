using Gestor_TipoCaracteristicas.Comandos.ModeloTipoC;
using Gestor_TipoCaracteristicas.Contracts;
using Gestor_TipoCaracteristicas.Entities;
using Gestor_TipoCaracteristicas.Helpers;
using Microsoft.EntityFrameworkCore;

namespace Gestor_TipoCaracteristicas.Repositories
{
    public class ModeloTipoCRepository : IModeloRepository
    {
        private readonly ApiDataContext _context;
        public ModeloTipoCRepository(ApiDataContext context)
        {
            _context = context;
        }/*
        public async Task<Modelo> createModeloAsyc(Modelo tipo)
        {
            _context.Modelos.Add(tipo);
            await _context.SaveChangesAsync();
            return tipo;
        }
        */
    }
}
