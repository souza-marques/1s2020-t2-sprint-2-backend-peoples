using Senai.Peoples.WebApi.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Interfaces
{
    interface IFuncionarioRepository
    {

        List<FuncionarioDomain> Listar();

        FuncionarioDomain BuscarPorId(int id);

        void Deletar(int id);

        void Atualizar(FuncionarioDomain funcionario);

        void Inserir(int id);
    }
}
