using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaCadastro
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;
        public Cadastro(String nome, String telefone)
        {
            //Comando Sgl
            //Para poder escrever um comando precisa  de uma classe SqlCommand
            cmd.CommandText = "insert into Cadastro (nome,telefone) values (@nome, @telefone)";
            //---------------
            //Parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            try
            {
                //Conectar com o banco
                cmd.Connection = conexao.conectar();
                //---------------

                //executar comando
                cmd.ExecuteNonQuery();
                //---------------

                //desconectar
                conexao.desconectar();
                //---------------

                //Mostrar mensagem de erro ou sucesso
                this.mensagem = "Cadastrado com sucesso";
                //---------------
            }
            catch (SqlException e)
            {
                //Mostrar mensagem de erro ou sucesso
                this.mensagem = "Erro ao cadastrar";
                //---------------
                
            }

            

        }
    }
}
