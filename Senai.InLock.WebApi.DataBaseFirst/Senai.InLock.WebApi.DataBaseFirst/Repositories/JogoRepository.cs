using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        InLockContext ctx = new InLockContext();

        public Jogos BuscarPorId(int id)
        {
            return ctx.Jogos.FirstOrDefault(e => e.IdJogo == id);
        }

        public void  Cadastrar(Jogos novoJogo)
        {
            ctx.Jogos.Add(novoJogo);
            //salva as alterações
            ctx.SaveChanges();
        }

        public List<Jogos> Listar()
        {
            return ctx.Jogos.ToList();
        }

        public void Deletar(int id)
        {

            Jogos jogoBuscado = ctx.Jogos.FirstOrDefault(e => e.IdJogo == id);

            ctx.Jogos.Remove(jogoBuscado);

            ctx.SaveChanges();
        }
    }
}
