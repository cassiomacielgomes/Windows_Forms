namespace Projeto_8.br.com.projeto.VIEW
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes_consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunc_cadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunc_consulta = new System.Windows.Forms.ToolStripMenuItem();
            this.menuForn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig_trocar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig_sair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_usuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuFunc,
            this.menuForn,
            this.menuProd,
            this.menuConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuClientes
            // 
            this.menuClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes_cadastro,
            this.menuClientes_consulta});
            this.menuClientes.Image = global::Projeto_8.Properties.Resources.clientes;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(77, 20);
            this.menuClientes.Text = "Clientes";
            // 
            // menuFunc
            // 
            this.menuFunc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFunc_cadastro,
            this.menuFunc_consulta});
            this.menuFunc.Image = global::Projeto_8.Properties.Resources.funcionarios;
            this.menuFunc.Name = "menuFunc";
            this.menuFunc.Size = new System.Drawing.Size(103, 20);
            this.menuFunc.Text = "Funcionários";
            // 
            // menuClientes_cadastro
            // 
            this.menuClientes_cadastro.Name = "menuClientes_cadastro";
            this.menuClientes_cadastro.Size = new System.Drawing.Size(182, 22);
            this.menuClientes_cadastro.Text = "Cadastro de Clientes";
            // 
            // menuClientes_consulta
            // 
            this.menuClientes_consulta.Name = "menuClientes_consulta";
            this.menuClientes_consulta.Size = new System.Drawing.Size(182, 22);
            this.menuClientes_consulta.Text = "Consulta de Clientes";
            // 
            // menuFunc_cadastro
            // 
            this.menuFunc_cadastro.Name = "menuFunc_cadastro";
            this.menuFunc_cadastro.Size = new System.Drawing.Size(208, 22);
            this.menuFunc_cadastro.Text = "Cadastro de Funcionários";
            // 
            // menuFunc_consulta
            // 
            this.menuFunc_consulta.Name = "menuFunc_consulta";
            this.menuFunc_consulta.Size = new System.Drawing.Size(208, 22);
            this.menuFunc_consulta.Text = "Consulta de Funcionários";
            // 
            // menuForn
            // 
            this.menuForn.Image = global::Projeto_8.Properties.Resources.fornecedores;
            this.menuForn.Name = "menuForn";
            this.menuForn.Size = new System.Drawing.Size(106, 20);
            this.menuForn.Text = "Fornecedores";
            // 
            // menuProd
            // 
            this.menuProd.Image = global::Projeto_8.Properties.Resources.produtos;
            this.menuProd.Name = "menuProd";
            this.menuProd.Size = new System.Drawing.Size(83, 20);
            this.menuProd.Text = "Produtos";
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig_trocar,
            this.menuConfig_sair});
            this.menuConfig.Image = global::Projeto_8.Properties.Resources.configurações;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(112, 20);
            this.menuConfig.Text = "Configurações";
            // 
            // menuConfig_trocar
            // 
            this.menuConfig_trocar.Name = "menuConfig_trocar";
            this.menuConfig_trocar.Size = new System.Drawing.Size(180, 22);
            this.menuConfig_trocar.Text = "Trocar Usuário";
            // 
            // menuConfig_sair
            // 
            this.menuConfig_sair.Name = "menuConfig_sair";
            this.menuConfig_sair.Size = new System.Drawing.Size(180, 22);
            this.menuConfig_sair.Text = "Sair";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txt_data,
            this.toolStripStatusLabel3,
            this.txt_hora,
            this.toolStripStatusLabel5,
            this.txt_usuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 170);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "Data atual:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txt_data
            // 
            this.txt_data.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(73, 17);
            this.txt_data.Text = "12/08/2024";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel3.Text = "Hora atual:";
            // 
            // txt_hora
            // 
            this.txt_hora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(38, 17);
            this.txt_hora.Text = "14:30";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabel5.Text = "Usuário logado:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(40, 17);
            this.txt_usuario.Text = "Cassio";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 192);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuClientes_cadastro;
        private System.Windows.Forms.ToolStripMenuItem menuClientes_consulta;
        private System.Windows.Forms.ToolStripMenuItem menuFunc;
        private System.Windows.Forms.ToolStripMenuItem menuFunc_cadastro;
        private System.Windows.Forms.ToolStripMenuItem menuFunc_consulta;
        private System.Windows.Forms.ToolStripMenuItem menuForn;
        private System.Windows.Forms.ToolStripMenuItem menuProd;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuConfig_trocar;
        private System.Windows.Forms.ToolStripMenuItem menuConfig_sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txt_data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txt_hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel txt_usuario;
    }
}