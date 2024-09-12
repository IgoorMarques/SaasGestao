using Domain.Interfaces;
using Domain.Interfaces.InterfaceServico;
using Entities.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Servicos
{
    public class AtividadeMetaServico : InterfaceAtividadeMetaServico
    {
        private readonly InterfaceAtividadeMeta _interfaceAtividadeMeta;
        public AtividadeMetaServico(InterfaceAtividadeMeta interfaceAtividadeMeta)
        {
            _interfaceAtividadeMeta = interfaceAtividadeMeta;
        }

        public async Task Add(AtividadeMeta Objeto)
        {
            await _interfaceAtividadeMeta.Add(Objeto);
        }

        public async Task Delete(AtividadeMeta Objeto)
        {
            await _interfaceAtividadeMeta.Delete(Objeto);
        }

        public async Task<AtividadeMeta> GetEntityByID(int ID)
        {
            return await _interfaceAtividadeMeta.GetEntityByID(ID);
        }

        public async Task<List<AtividadeMeta>> List()
        {
           return await _interfaceAtividadeMeta.List();
        }

        public async Task Update(AtividadeMeta Objeto)
        {
            await _interfaceAtividadeMeta.Update(Objeto);
        }
    }
}
