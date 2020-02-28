using Senai.Peoples.WebApi.Properties.Domains;
using Senai.Peoples.WebApi.Properties.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Peoples.WebApi.Properties.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string stringconexao = "Data Source=DEV20\\SQLEXPRESS; initial catalog= M_Peoples; user Id=sa;pwd = sa@132";

        public void Inserir(UsuarioDomain usuario)
        {

            using (SqlConnection con = new SqlConnection(stringconexao))
            {
                string queryInsert = "INSERT INTO Usuarios(Email,Senha) VALUES (@Email,@Sobrenome)";

                SqlCommand cmd = new SqlCommand(queryInsert, con);

                cmd.Parameters.AddWithValue("@Email", usuario.Email);

                cmd.Parameters.AddWithValue("@Sobrenome", usuario.Senha);


                con.Open();

                cmd.ExecuteNonQuery();
            }
        }

    }
}
