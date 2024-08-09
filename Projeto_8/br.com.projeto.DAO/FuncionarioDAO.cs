using MySql.Data.MySqlClient;
using Projeto_8.br.com.projeto.CONEXAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.DAO
{
    internal class FuncionarioDAO
    {
        #region Conexão
        private MySqlConnection conexao;

        public FuncionarioDAO()
        {
            conexao = new Conexao().GetConnection();
        }
        #endregion

        #region Cadastrar
        public void cadastrarFuncionario(Funcionarios obj)
        {
            try
            {
                //1º passo - Definir comando SQL
                string sql = @"INSERT INTO tb_funcionarios (nome, rg, cpf, email, senha, cargo, nivel_acesso, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
                 VALUES(@nome, @rg, @cpf, @email, @senha, @cargo, @nivel_acesso, @telefone, @celular, @cep, @endereco, @numero, @complemento, @bairro, @cidade, @estado)";

                //2º passo - Organizar o comando SQL
                MySqlCommand executarcmd = new MySqlCommand(sql, conexao);
                executarcmd.Parameters.AddWithValue("@nome", obj.nome);
                executarcmd.Parameters.AddWithValue("@rg", obj.rg);
                executarcmd.Parameters.AddWithValue("@cpf", obj.cpf);
                executarcmd.Parameters.AddWithValue("@email", obj.email);

                executarcmd.Parameters.AddWithValue("@senha", obj.senha);
                executarcmd.Parameters.AddWithValue("@cargo", obj.cargo);
                executarcmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);

                executarcmd.Parameters.AddWithValue("@telefone", obj.telefone);
                executarcmd.Parameters.AddWithValue("@celular", obj.celular);
                executarcmd.Parameters.AddWithValue("@cep", obj.cep);
                executarcmd.Parameters.AddWithValue("@endereco", obj.endereco);
                executarcmd.Parameters.AddWithValue("@numero", obj.numero);
                executarcmd.Parameters.AddWithValue("@complemento", obj.complemento);
                executarcmd.Parameters.AddWithValue("@bairro", obj.bairro);
                executarcmd.Parameters.AddWithValue("@cidade", obj.cidade);
                executarcmd.Parameters.AddWithValue("@estado", obj.estado);

                //3º passo - Abrir Conexão e executar o comando sql
                conexao.Open();
                executarcmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário Cadastrado com Sucesso!");

                //4º passo - Fechar Conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro " + erro);
            }
        }
        #endregion
    }
}
