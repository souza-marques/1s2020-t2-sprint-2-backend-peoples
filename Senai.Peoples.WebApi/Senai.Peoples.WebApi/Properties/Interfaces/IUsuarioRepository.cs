using Senai.Peoples.WebApi.Properties.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Interfaces
{
    interface IUsuarioRepository
    {
        void Cadastrar(UsuarioDomain usuario);

        List<UsuarioDomain> Listar();

        UsuarioDomain BuscarPorId(int id);

        void AtualizarIdCorpo(UsuarioDomain usuario);

        void Deletar(int id);






    }
}
