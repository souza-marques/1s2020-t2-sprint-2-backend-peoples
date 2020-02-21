using Senai.Peoples.WebApi.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Interfaces
{
    interface IFuncionarioRepository
    {
        //retorna uma lista
        List<FuncionarioDomain> Listar();
        //insere um funcionario
        void Inserir(FuncionarioDomain funcionario);

        void Deletar(int id);
        
        // Busca um funcionario através do id
        FuncionarioDomain BuscarPorId(int id);
      
        void Atualizar( FuncionarioDomain funcionario);
    }
}
