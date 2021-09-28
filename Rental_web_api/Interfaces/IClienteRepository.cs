using Rental_web_api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_web_api
{
    interface IClienteRepository
    {
        void Cadastrar(ClienteDomain novoCliente);
        List<ClienteDomain> ListarTodos();
        void AutualizarCliente(ClienteDomain ClienteAtualizado);
        ClienteDomain BuscarPorId(int idCliente);
        void Dedletar(int idCliente);
    }
}
