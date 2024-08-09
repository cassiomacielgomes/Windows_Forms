using Projeto_8.br.com.projeto.DAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.VIEW
{
    public partial class frmFuncionarios : Form
    {
        public frmFuncionarios()
        {
            InitializeComponent();
        }

        private void page_dadosPessoais_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();

            //1º passo - Receber os dados
            obj.nome = txt_nome.Text;
            obj.rg = txt_rg.Text.Replace(",", ".");
            obj.cpf = txt_cpf.Text.Replace(",", ".");
            obj.email = txt_email.Text;

            obj.senha = txt_senha.Text;
            obj.cargo = cb_cargo.Text;
            obj.nivel_acesso = cb_nivel.Text;

            obj.telefone = txt_telefone.Text;
            obj.celular = txt_celular.Text;
            obj.cep = txt_cep.Text;
            obj.endereco = txt_endereco.Text;
            obj.numero = int.Parse(txt_n.Text);
            obj.complemento = txt_compl.Text;
            obj.bairro = txt_bairro.Text;
            obj.cidade = txt_cidade.Text;
            obj.estado = cb_uf.Text;

            //2º passo - Criar o Objeto e chamar o metodo
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.cadastrarFuncionario(obj);

            //Recarregar o dataGrid
            dg_consulta_funcionario.DataSource = dao.listarFuncionario();
        }

        private void frmFuncionarios_Load(object sender, EventArgs e)
        {
            FuncionarioDAO dao = new FuncionarioDAO();

            dg_consulta_funcionario.DataSource = dao.listarFuncionario();
        }

        private void dg_consulta_funcionario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados
            txt_codigo.Text = dg_consulta_funcionario.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_consulta_funcionario.CurrentRow.Cells[1].Value.ToString();
            txt_rg.Text = dg_consulta_funcionario.CurrentRow.Cells[2].Value.ToString();
            txt_cpf.Text = dg_consulta_funcionario.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dg_consulta_funcionario.CurrentRow.Cells[4].Value.ToString();

            txt_senha.Text = dg_consulta_funcionario.CurrentRow.Cells[5].Value.ToString();
            cb_cargo.Text = dg_consulta_funcionario.CurrentRow.Cells[6].Value.ToString();
            cb_nivel.Text = dg_consulta_funcionario.CurrentRow.Cells[7].Value.ToString();

            txt_telefone.Text = dg_consulta_funcionario.CurrentRow.Cells[8].Value.ToString();
            txt_celular.Text = dg_consulta_funcionario.CurrentRow.Cells[9].Value.ToString();
            txt_cep.Text = dg_consulta_funcionario.CurrentRow.Cells[10].Value.ToString();
            txt_endereco.Text = dg_consulta_funcionario.CurrentRow.Cells[11].Value.ToString();
            txt_n.Text = dg_consulta_funcionario.CurrentRow.Cells[12].Value.ToString();
            txt_compl.Text = dg_consulta_funcionario.CurrentRow.Cells[13].Value.ToString();
            txt_bairro.Text = dg_consulta_funcionario.CurrentRow.Cells[14].Value.ToString();
            txt_cidade.Text = dg_consulta_funcionario.CurrentRow.Cells[15].Value.ToString();
            cb_uf.Text = dg_consulta_funcionario.CurrentRow.Cells[16].Value.ToString();

            //Alterar para guia Dados Pessoais
            tab_funcionarios.SelectedTab = page_dadosPessoais;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();

            //1º passo - Receber os dados
            obj.nome = txt_nome.Text;
            obj.rg = txt_rg.Text.Replace(",", ".");
            obj.cpf = txt_cpf.Text.Replace(",", ".");
            obj.email = txt_email.Text;

            obj.senha = txt_senha.Text;
            obj.cargo = cb_cargo.Text;
            obj.nivel_acesso = cb_nivel.Text;

            obj.telefone = txt_telefone.Text;
            obj.celular = txt_celular.Text;
            obj.cep = txt_cep.Text;
            obj.endereco = txt_endereco.Text;
            obj.numero = int.Parse(txt_n.Text);
            obj.complemento = txt_compl.Text;
            obj.bairro = txt_bairro.Text;
            obj.cidade = txt_cidade.Text;
            obj.estado = cb_uf.Text;

            obj.codigo = int.Parse(txt_codigo.Text);

            //2º passo - Criar o Objeto e chamar o metodo
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.alterarFuncionario(obj);

            //Recarregar o dataGrid
            dg_consulta_funcionario.DataSource = dao.listarFuncionario();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Funcionarios obj = new Funcionarios();

            //1º passo - Receber os dados        
            obj.codigo = int.Parse(txt_codigo.Text);

            //2º passo - Criar o Objeto e chamar o metodo
            FuncionarioDAO dao = new FuncionarioDAO();
            dao.excluirFuncionario(obj);

            //Recarregar o dataGrid
            dg_consulta_funcionario.DataSource = dao.listarFuncionario();

            //Retorna para pesquisar
            tab_funcionarios.SelectedTab = tabPage2;
        }
    }
}
