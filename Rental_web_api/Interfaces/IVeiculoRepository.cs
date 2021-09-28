using Rental_web_api.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_web_api.Interfaces
{
    public class IVeiculoRepository
    {
        void Cadastrar(VeiculoDomain novoVeiculo);
        List<VeiculoDomain> ListarTodos();
        void Atualizar(VeiculoDomain veiculoAtualizado);
        VeiculoDomain BuscarPorId(int IdVeicuo);
        void Deletar(int Idveiculo);

    }
}
