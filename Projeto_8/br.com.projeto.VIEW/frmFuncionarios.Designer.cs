namespace Projeto_8.br.com.projeto.VIEW
{
    partial class frmFuncionarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.tab_funcionarios = new System.Windows.Forms.TabControl();
            this.page_dadosPessoais = new System.Windows.Forms.TabPage();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.cb_nivel = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_celular = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
            this.txt_rg = new System.Windows.Forms.MaskedTextBox();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.txt_compl = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dg_consulta_funcionario = new System.Windows.Forms.DataGridView();
            this.btn_pesquisar_consulta = new System.Windows.Forms.Button();
            this.txt_nome_consulta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tab_funcionarios.SuspendLayout();
            this.page_dadosPessoais.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 35);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Funcionários";
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(370, 391);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 42);
            this.btn_editar.TabIndex = 11;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Location = new System.Drawing.Point(252, 391);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(100, 42);
            this.btn_excluir.TabIndex = 10;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(134, 391);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(100, 42);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Location = new System.Drawing.Point(16, 391);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(100, 42);
            this.btn_novo.TabIndex = 8;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            // 
            // tab_funcionarios
            // 
            this.tab_funcionarios.Controls.Add(this.page_dadosPessoais);
            this.tab_funcionarios.Controls.Add(this.tabPage2);
            this.tab_funcionarios.Location = new System.Drawing.Point(12, 41);
            this.tab_funcionarios.Name = "tab_funcionarios";
            this.tab_funcionarios.SelectedIndex = 0;
            this.tab_funcionarios.Size = new System.Drawing.Size(458, 332);
            this.tab_funcionarios.TabIndex = 7;
            // 
            // page_dadosPessoais
            // 
            this.page_dadosPessoais.Controls.Add(this.cb_cargo);
            this.page_dadosPessoais.Controls.Add(this.cb_nivel);
            this.page_dadosPessoais.Controls.Add(this.label19);
            this.page_dadosPessoais.Controls.Add(this.label18);
            this.page_dadosPessoais.Controls.Add(this.txt_senha);
            this.page_dadosPessoais.Controls.Add(this.label17);
            this.page_dadosPessoais.Controls.Add(this.cb_uf);
            this.page_dadosPessoais.Controls.Add(this.label15);
            this.page_dadosPessoais.Controls.Add(this.txt_celular);
            this.page_dadosPessoais.Controls.Add(this.txt_cep);
            this.page_dadosPessoais.Controls.Add(this.txt_telefone);
            this.page_dadosPessoais.Controls.Add(this.txt_cpf);
            this.page_dadosPessoais.Controls.Add(this.txt_rg);
            this.page_dadosPessoais.Controls.Add(this.btn_pesquisar);
            this.page_dadosPessoais.Controls.Add(this.txt_compl);
            this.page_dadosPessoais.Controls.Add(this.label13);
            this.page_dadosPessoais.Controls.Add(this.label14);
            this.page_dadosPessoais.Controls.Add(this.txt_n);
            this.page_dadosPessoais.Controls.Add(this.label12);
            this.page_dadosPessoais.Controls.Add(this.txt_bairro);
            this.page_dadosPessoais.Controls.Add(this.label11);
            this.page_dadosPessoais.Controls.Add(this.txt_cidade);
            this.page_dadosPessoais.Controls.Add(this.label10);
            this.page_dadosPessoais.Controls.Add(this.txt_endereco);
            this.page_dadosPessoais.Controls.Add(this.label9);
            this.page_dadosPessoais.Controls.Add(this.label7);
            this.page_dadosPessoais.Controls.Add(this.label8);
            this.page_dadosPessoais.Controls.Add(this.label6);
            this.page_dadosPessoais.Controls.Add(this.label5);
            this.page_dadosPessoais.Controls.Add(this.txt_email);
            this.page_dadosPessoais.Controls.Add(this.label4);
            this.page_dadosPessoais.Controls.Add(this.txt_nome);
            this.page_dadosPessoais.Controls.Add(this.label3);
            this.page_dadosPessoais.Controls.Add(this.txt_codigo);
            this.page_dadosPessoais.Controls.Add(this.label2);
            this.page_dadosPessoais.Location = new System.Drawing.Point(4, 22);
            this.page_dadosPessoais.Name = "page_dadosPessoais";
            this.page_dadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.page_dadosPessoais.Size = new System.Drawing.Size(450, 306);
            this.page_dadosPessoais.TabIndex = 0;
            this.page_dadosPessoais.Text = "Dados Pessoais";
            this.page_dadosPessoais.UseVisualStyleBackColor = true;
            this.page_dadosPessoais.Click += new System.EventHandler(this.page_dadosPessoais_Click);
            // 
            // cb_cargo
            // 
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Items.AddRange(new object[] {
            "Gerente",
            "Vendedor",
            "Estagiário"});
            this.cb_cargo.Location = new System.Drawing.Point(316, 273);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(119, 21);
            this.cb_cargo.TabIndex = 43;
            // 
            // cb_nivel
            // 
            this.cb_nivel.FormattingEnabled = true;
            this.cb_nivel.Items.AddRange(new object[] {
            "Administrador",
            "Usuário"});
            this.cb_nivel.Location = new System.Drawing.Point(89, 274);
            this.cb_nivel.Name = "cb_nivel";
            this.cb_nivel.Size = new System.Drawing.Size(119, 21);
            this.cb_nivel.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(250, 273);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 20);
            this.label19.TabIndex = 41;
            this.label19.Text = "Cargo: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label18.Location = new System.Drawing.Point(8, 275);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(57, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "Nível: ";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(89, 248);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(119, 20);
            this.txt_senha.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label17.Location = new System.Drawing.Point(8, 248);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Senha: ";
            // 
            // cb_uf
            // 
            this.cb_uf.FormattingEnabled = true;
            this.cb_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cb_uf.Location = new System.Drawing.Point(89, 221);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(119, 21);
            this.cb_uf.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(7, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 20);
            this.label15.TabIndex = 34;
            this.label15.Text = "UF:";
            // 
            // txt_celular
            // 
            this.txt_celular.Location = new System.Drawing.Point(316, 118);
            this.txt_celular.Mask = "(99) 9 9999-9999";
            this.txt_celular.Name = "txt_celular";
            this.txt_celular.Size = new System.Drawing.Size(119, 20);
            this.txt_celular.TabIndex = 33;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(316, 219);
            this.txt_cep.Mask = "99999-999";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(119, 20);
            this.txt_cep.TabIndex = 32;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(89, 116);
            this.txt_telefone.Mask = "(99) 9 9999-9999";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(119, 20);
            this.txt_telefone.TabIndex = 30;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(316, 90);
            this.txt_cpf.Mask = "999,999,999-99";
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(119, 20);
            this.txt_cpf.TabIndex = 29;
            // 
            // txt_rg
            // 
            this.txt_rg.Location = new System.Drawing.Point(89, 90);
            this.txt_rg.Mask = "99,999,999-9";
            this.txt_rg.Name = "txt_rg";
            this.txt_rg.Size = new System.Drawing.Size(119, 20);
            this.txt_rg.TabIndex = 28;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar.Location = new System.Drawing.Point(254, 245);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(185, 24);
            this.btn_pesquisar.TabIndex = 6;
            this.btn_pesquisar.Text = "Pesquisar";
            this.btn_pesquisar.UseVisualStyleBackColor = false;
            // 
            // txt_compl
            // 
            this.txt_compl.Location = new System.Drawing.Point(89, 194);
            this.txt_compl.Name = "txt_compl";
            this.txt_compl.Size = new System.Drawing.Size(119, 20);
            this.txt_compl.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(7, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Compl.:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(250, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "CEP:";
            // 
            // txt_n
            // 
            this.txt_n.Location = new System.Drawing.Point(89, 168);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(119, 20);
            this.txt_n.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(250, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Bairro:";
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(316, 168);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(119, 20);
            this.txt_bairro.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(250, 194);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Cidade:";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(316, 194);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(119, 20);
            this.txt_cidade.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(7, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Nº:";
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(89, 142);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(346, 20);
            this.txt_endereco.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(7, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(250, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Celular:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(7, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Telefone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(250, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(7, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(89, 64);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(346, 20);
            this.txt_email.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(89, 38);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(346, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(7, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(89, 12);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(84, 20);
            this.txt_codigo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dg_consulta_funcionario);
            this.tabPage2.Controls.Add(this.btn_pesquisar_consulta);
            this.tabPage2.Controls.Add(this.txt_nome_consulta);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dg_consulta_funcionario
            // 
            this.dg_consulta_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_consulta_funcionario.Location = new System.Drawing.Point(6, 36);
            this.dg_consulta_funcionario.Name = "dg_consulta_funcionario";
            this.dg_consulta_funcionario.Size = new System.Drawing.Size(443, 230);
            this.dg_consulta_funcionario.TabIndex = 8;
            // 
            // btn_pesquisar_consulta
            // 
            this.btn_pesquisar_consulta.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_pesquisar_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar_consulta.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesquisar_consulta.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar_consulta.Location = new System.Drawing.Point(333, 6);
            this.btn_pesquisar_consulta.Name = "btn_pesquisar_consulta";
            this.btn_pesquisar_consulta.Size = new System.Drawing.Size(119, 24);
            this.btn_pesquisar_consulta.TabIndex = 7;
            this.btn_pesquisar_consulta.Text = "Pesquisar";
            this.btn_pesquisar_consulta.UseVisualStyleBackColor = false;
            // 
            // txt_nome_consulta
            // 
            this.txt_nome_consulta.Location = new System.Drawing.Point(67, 9);
            this.txt_nome_consulta.Name = "txt_nome_consulta";
            this.txt_nome_consulta.Size = new System.Drawing.Size(260, 20);
            this.txt_nome_consulta.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(5, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 4;
            this.label16.Text = "Nome:";
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.tab_funcionarios);
            this.Name = "frmFuncionarios";
            this.Text = "frmFuncionarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_funcionarios.ResumeLayout(false);
            this.page_dadosPessoais.ResumeLayout(false);
            this.page_dadosPessoais.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_consulta_funcionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TabControl tab_funcionarios;
        private System.Windows.Forms.TabPage page_dadosPessoais;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txt_celular;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.MaskedTextBox txt_cpf;
        private System.Windows.Forms.MaskedTextBox txt_rg;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.TextBox txt_compl;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dg_consulta_funcionario;
        private System.Windows.Forms.Button btn_pesquisar_consulta;
        private System.Windows.Forms.TextBox txt_nome_consulta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cb_nivel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_cargo;
    }
}