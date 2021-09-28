using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rental_web_api.Controllers
{
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _clienteRepository { get; set; }
        public ClienteController()
        {
            _clienteRepository = new ClienteRepository();
        }

        [HttpPost]

        public IActionResult Cadastrar(ClienteDomain NovoCliente)
        {
            _clienteRepository.Cadastrar(novoCliente);


            return StatusCode(201);
        }

        [HttpGet]
        public IActionResult Listar()
        {
            List<ClienteDomain> listaClientes = _clienteRepository.ListarTodos();


            return Ok(listaCliente);
        }

        [HttpGet ("{id}")]
        public IActionResult Buscar(int id)
        {
            ClienteDomain clienteBuscado = _clienteREpository.BuscarPorId(id);

            if(clienteBuscado == null)
            {
                return NotFound("Nenhum Genero encontrado ");
            }

            return Ok(clienteBuscado);
        }

        [HttpPatch]
        public IActionresult Atualizar(ClienteDomain clienteAtualizado)
        {
            if(clienteAtualizado.nomeCliente == null || clienteAtualizado. idCliente <= 0 || clienteAtualizado.sobrenomeCliente == null || clienteAtualizado.CNH == null)
            {
                return BadRequest(
                    new
                    {
                        mensagem = "Dados Não Informados",
                    }
                    );
            }

            ClienteDomain clienteBuscado = _clienteRepository.BuscadoPorId(clienteAtualizado.IdCliente);

            if(clienteBuscado != null)
            {
                try
                {
                    _clienteRepository.AtualizarCliente(clienteAtualizado);

                    return NoContent();
                }

                catch(Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            return NotFound(
                new
                {
                    mensagem = "Cliente Não Encontrado",
                    erroStatus = true
                }
                );
        }

        [HttpDelete("Deletar/{Id}")]
        public IActionResult Deletar(int Id)
        {
            _clienteRepository.Deletar(Id);

            return NoContent();
        }
    }
}
