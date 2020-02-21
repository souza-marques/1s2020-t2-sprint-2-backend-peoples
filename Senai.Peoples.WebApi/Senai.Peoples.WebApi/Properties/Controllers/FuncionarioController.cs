using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Peoples.WebApi.Properties.Domains;
using Senai.Peoples.WebApi.Properties.Interfaces;
using Senai.Peoples.WebApi.Properties.Repositories;

namespace Senai.Peoples.WebApi.Properties.Controllers
{
    [Route("application/json")]

    [Route("api/[controller]")]


    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private IFuncionarioRepository _funcionarioRepository { get; set; }


        public FuncionarioController()
        {
            _funcionarioRepository = new FuncionarioRepository();
        }


        //Lista todos os funcionarios
        [HttpGet]
        public IEnumerable<FuncionarioDomain> Get()
        {
            //chamada para o método .Listar();
            return _funcionarioRepository.Listar();
        }
        //Cadastrar um novo funcionario
        [HttpPost]
        public IActionResult Post(FuncionarioDomain novoFuncionario)
        {
            _funcionarioRepository.Inserir(novoFuncionario);

            return StatusCode(201);
        }
        /// <summary>
        /// Deleta um funcionario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionarioRepository.Deletar(id);

             return Ok("Funcionário deletado");
        }

        /// <summary>
        /// Busca através do id, método (BUSCARPORID)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            FuncionarioDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(id);

            if (funcionarioBuscado == null)
            {
                return NotFound("Nenhum funcionário foi encontrado");
            }

            // Caso seja encontrado, retorna o gênero buscado
            return Ok(funcionarioBuscado);
        }

        [HttpPut]
        public IActionResult PutIdCorpo(FuncionarioDomain funcionarioRecebido)
        {
            // Cria um objeto generoBuscado que irá receber o gênero buscado no banco de dados
            FuncionarioDomain funcionarioBuscado = _funcionarioRepository.BuscarPorId(funcionarioRecebido.IdFuncionario);

            // Verifica se algum gênero foi encontrado
            if (funcionarioBuscado != null)
            {
                // Tenta atualizar o registro
                try
                {
                    // Faz a chamada para o método .AtualizarIdCorpo();
                    _funcionarioRepository.Atualizar(funcionarioRecebido);

                    // Retorna um status code 204 - No Content
                    return NoContent();
                }
                // Caso haja algum erro
                catch (Exception erro)
                {
                    // Retorna BadRequest e o erro
                    return BadRequest(erro);
                }

            }

            // Caso não seja encontrado, retorna NotFound com uma mensagem personalizada
            // e um bool para representar que houve erro
            return NotFound
                (
                    new
                    {
                        mensagem = "Gênero não encontrado",
                        erro = true
                    }
                );
        }
    }
}