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
                string querySelectAll = "SELECT IdFuncionario,Nome,Sobrenome,DataNascimento from Funcionarios";

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

                            Sobrenome = rdr["Sobrenome"].ToString(),

                            DataNascimento = Convert.ToDateTime(rdr["DataNascimento"])

                        };

                        funcionarios.Add(funcionario);
                    }
                }

            }

            return funcionarios;
        }

        public void Inserir(FuncionarioDomain funcionario)
        {

            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string queryInsert = "INSERT INTO Funcionarios(Nome,Sobrenome,DataNascimento) VALUES (@Nome,@Sobrenome,@DataNascimento)";

                SqlCommand cmd = new SqlCommand(queryInsert, con);

                cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);

                cmd.Parameters.AddWithValue("@Sobrenome", funcionario.Sobrenome);

                cmd.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);


                con.Open();

                cmd.ExecuteNonQuery();
            }
        }


        public void Deletar(int id)
        {
            
            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string queryDelete = "DELETE FROM Funcionarios WHERE IdFuncionario = @ID";

                
                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    
                    cmd.Parameters.AddWithValue("@ID", id);

                   
                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public FuncionarioDomain BuscarPorId(int id)
        {
            
            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                
                string querySelectById = "SELECT IdFuncionario, Nome , Sobrenome , DataNascimento FROM Funcionarios WHERE IdFuncionario = @ID";

                con.Open();

                SqlDataReader rdr;

                using (SqlCommand cmd = new SqlCommand(querySelectById, con))
                {
                    
                    cmd.Parameters.AddWithValue("@ID", id);

                    
                    rdr = cmd.ExecuteReader();

                    
                    if (rdr.Read())
                    {
                        // Cria um objeto funcionario
                        FuncionarioDomain funcionario = new FuncionarioDomain
                        {
                            IdFuncionario = Convert.ToInt32(rdr["IdFuncionario"])

                            // Atribui à propriedade Nome o valor da coluna "Nome" e "Sobrenome" da tabela do banco
                            ,
                            Nome = rdr["Nome"].ToString(),
                            Sobrenome = rdr["Sobrenome"].ToString(),
                            DataNascimento = Convert.ToDateTime(rdr["DataNascimento"])
                        };

                        return funcionario;
                    }

                    return null;
                }
            }
        }

        public void Atualizar(FuncionarioDomain funcionario)
        {
            // Declara a conexão passando a string de conexão
            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                // Diz a requisição  oque deve ser executado
                //requisição para atualizar as informações(Update)
                string queryUpdate = "UPDATE Funcionarios SET Nome = @Nome , Sobrenome = @Sobrenome, DataNascimento = @DataNascimento WHERE IdFuncionario = @ID";

                // Declara o SqlCommand passando o comando a ser executado e a conexão
                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    // Passa os valores dos parâmetros
                    cmd.Parameters.AddWithValue("@ID", funcionario.IdFuncionario);
                    cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
                    cmd.Parameters.AddWithValue("@Sobrenome", funcionario.Sobrenome);
                    cmd.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);





                    // Abre a conexão com o banco de dados
                    con.Open();

                    // Executa o comando
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }

   
}
