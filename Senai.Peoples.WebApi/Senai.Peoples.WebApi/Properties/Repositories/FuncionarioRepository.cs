using Senai.Peoples.WebApi.Properties.Domains;
using Senai.Peoples.WebApi.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private string stringconexao = "Data Source=DEV20\\SQLEXPRESS; initial catalog= M_Peoples; user Id=sa;pwd = sa@132";

        public List<FuncionarioDomain> Listar()
        {
            List<FuncionarioDomain> funcionarios = new List<FuncionarioDomain>();

            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string querySelectAll = "SELECT IdFuncionario,Nome,Sobrenome from Funcionarios";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    rdr = cmd.ExecuteReader();

                    while(rdr.Read())
                    {
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            IdFuncionario = Convert.ToInt32(rdr[0]),

                            Nome = rdr["Nome"].ToString(),

                            Sobrenome = rdr["Sobrenome"].ToString()
                        };

                        funcionarios.Add(funcionario);
                    }
                }

            }

            return funcionarios;
        }
    }
}
