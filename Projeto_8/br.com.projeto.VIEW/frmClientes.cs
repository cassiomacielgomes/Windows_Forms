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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1º passo - Receber os dados
            obj.nome = txt_nome.Text;
            obj.rg = txt_rg.Text.Replace(",",".");
            obj.cpf = txt_cpf.Text.Replace(",",".");
            obj.email = txt_email.Text;
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
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);

            //Recarregar o dataGrid
            dg_consulta.DataSource = dao.listarCliente();

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dg_consulta.DataSource = dao.listarCliente();
        }

        private void dg_consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados
            txt_codigo.Text = dg_consulta.CurrentRow.Cells[0].Value.ToString();
            txt_nome.Text = dg_consulta.CurrentRow.Cells[1].Value.ToString();
            txt_rg.Text = dg_consulta.CurrentRow.Cells[2].Value.ToString();
            txt_cpf.Text = dg_consulta.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dg_consulta.CurrentRow.Cells[4].Value.ToString();
            txt_telefone.Text = dg_consulta.CurrentRow.Cells[5].Value.ToString();
            txt_celular.Text = dg_consulta.CurrentRow.Cells[6].Value.ToString();
            txt_cep.Text = dg_consulta.CurrentRow.Cells[7].Value.ToString();
            txt_endereco.Text = dg_consulta.CurrentRow.Cells[8].Value.ToString();
            txt_n.Text = dg_consulta.CurrentRow.Cells[9].Value.ToString();
            txt_compl.Text = dg_consulta.CurrentRow.Cells[10].Value.ToString();
            txt_bairro.Text = dg_consulta.CurrentRow.Cells[11].Value.ToString();
            txt_cidade.Text = dg_consulta.CurrentRow.Cells[12].Value.ToString();
            cb_uf.Text = dg_consulta.CurrentRow.Cells[13].Value.ToString();

            //Alterar para guia Dados Pessoais
            tab_clientes.SelectedTab = page_dadosPessoais;
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1º passo - Receber os dados
            obj.nome = txt_nome.Text;
            obj.rg = txt_rg.Text.Replace(",", ".");
            obj.cpf = txt_cpf.Text.Replace(",", ".");
            obj.email = txt_email.Text;
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
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            //Recarregar o dataGrid
            dg_consulta.DataSource = dao.listarCliente();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1º passo - Receber os dados        
            obj.codigo = int.Parse(txt_codigo.Text);
           
            //2º passo - Criar o Objeto e chamar o metodo
            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            //Recarregar o dataGrid
            dg_consulta.DataSource = dao.listarCliente();

            //Retorna para pesquisar
            tab_clientes.SelectedTab = tabPage2;

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }

        private void btn_pesquisar_consulta_Click(object sender, EventArgs e)
        {
            string nome = txt_nome_consulta.Text;

            ClienteDAO dao = new ClienteDAO();

            dg_consulta.DataSource = dao.BuscarClientePorNome(nome);

            if (dg_consulta.Rows.Count == 0) {
                //Recarregar o dataGrid
                dg_consulta.DataSource = dao.listarCliente();
            }
        }

        private void txt_nome_consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nome = "%" + txt_nome_consulta.Text + "%";

            ClienteDAO dao = new ClienteDAO();

            dg_consulta.DataSource = dao.BuscarClienteListando(nome);
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                string cep = txt_cep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet();

                dados.ReadXml(xml);

                txt_endereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txt_bairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txt_cidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txt_compl.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cb_uf.Text = dados.Tables[0].Rows[0]["uf"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado, por favor verifique.");
            }

        }
    }
}
