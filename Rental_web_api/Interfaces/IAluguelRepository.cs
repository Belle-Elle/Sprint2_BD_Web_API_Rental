using Rental_web_api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_web_api.Interfaces
{
    public class IAluguelRepository
    {
        void Cadastrar(AluguelDomain novoAluguel);
        List<AluguelDomain> ListarTodos();
        void Atualizar(AluguelDomain aluguelAtualizado);
        AluguelDomain BuscarPorId(int idAluguel);
        void Deletar(int idAluguel); 
    }
}
