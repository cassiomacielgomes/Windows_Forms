namespace Projeto_6
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_estCivil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_casaPropria = new System.Windows.Forms.CheckBox();
            this.checkBox_veiculo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_outros = new System.Windows.Forms.RadioButton();
            this.radioButton_fem = new System.Windows.Forms.RadioButton();
            this.radioButton_masc = new System.Windows.Forms.RadioButton();
            this.button_cadastrar_alterar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_limpar = new System.Windows.Forms.Button();
            this.dateTimePicker_dn = new System.Windows.Forms.DateTimePicker();
            this.listBox_lista = new System.Windows.Forms.ListBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView_pessoa = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(123, 28);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(284, 20);
            this.textBox_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estado Civil:";
            // 
            // comboBox_estCivil
            // 
            this.comboBox_estCivil.FormattingEnabled = true;
            this.comboBox_estCivil.Location = new System.Drawing.Point(166, 79);
            this.comboBox_estCivil.Name = "comboBox_estCivil";
            this.comboBox_estCivil.Size = new System.Drawing.Size(241, 21);
            this.comboBox_estCivil.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone:";
            // 
            // checkBox_casaPropria
            // 
            this.checkBox_casaPropria.AutoSize = true;
            this.checkBox_casaPropria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_casaPropria.Location = new System.Drawing.Point(56, 132);
            this.checkBox_casaPropria.Name = "checkBox_casaPropria";
            this.checkBox_casaPropria.Size = new System.Drawing.Size(189, 24);
            this.checkBox_casaPropria.TabIndex = 8;
            this.checkBox_casaPropria.Text = "Possui Casa Própria";
            this.checkBox_casaPropria.UseVisualStyleBackColor = true;
            // 
            // checkBox_veiculo
            // 
            this.checkBox_veiculo.AutoSize = true;
            this.checkBox_veiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_veiculo.Location = new System.Drawing.Point(262, 132);
            this.checkBox_veiculo.Name = "checkBox_veiculo";
            this.checkBox_veiculo.Size = new System.Drawing.Size(145, 24);
            this.checkBox_veiculo.TabIndex = 9;
            this.checkBox_veiculo.Text = "Possui Veículo";
            this.checkBox_veiculo.UseVisualStyleBackColor = true;
            this.checkBox_veiculo.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_outros);
            this.groupBox1.Controls.Add(this.radioButton_fem);
            this.groupBox1.Controls.Add(this.radioButton_masc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(56, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 82);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // radioButton_outros
            // 
            this.radioButton_outros.AutoSize = true;
            this.radioButton_outros.Location = new System.Drawing.Point(263, 35);
            this.radioButton_outros.Name = "radioButton_outros";
            this.radioButton_outros.Size = new System.Drawing.Size(81, 24);
            this.radioButton_outros.TabIndex = 2;
            this.radioButton_outros.TabStop = true;
            this.radioButton_outros.Text = "Outros";
            this.radioButton_outros.UseVisualStyleBackColor = true;
            // 
            // radioButton_fem
            // 
            this.radioButton_fem.AutoSize = true;
            this.radioButton_fem.Location = new System.Drawing.Point(138, 35);
            this.radioButton_fem.Name = "radioButton_fem";
            this.radioButton_fem.Size = new System.Drawing.Size(100, 24);
            this.radioButton_fem.TabIndex = 1;
            this.radioButton_fem.TabStop = true;
            this.radioButton_fem.Text = "Feminino";
            this.radioButton_fem.UseVisualStyleBackColor = true;
            // 
            // radioButton_masc
            // 
            this.radioButton_masc.AutoSize = true;
            this.radioButton_masc.Location = new System.Drawing.Point(6, 35);
            this.radioButton_masc.Name = "radioButton_masc";
            this.radioButton_masc.Size = new System.Drawing.Size(107, 24);
            this.radioButton_masc.TabIndex = 0;
            this.radioButton_masc.TabStop = true;
            this.radioButton_masc.Text = "Masculino";
            this.radioButton_masc.UseVisualStyleBackColor = true;
            // 
            // button_cadastrar_alterar
            // 
            this.button_cadastrar_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cadastrar_alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar_alterar.Location = new System.Drawing.Point(56, 250);
            this.button_cadastrar_alterar.Name = "button_cadastrar_alterar";
            this.button_cadastrar_alterar.Size = new System.Drawing.Size(173, 32);
            this.button_cadastrar_alterar.TabIndex = 11;
            this.button_cadastrar_alterar.Text = "Cadastrar | Alterar";
            this.button_cadastrar_alterar.UseVisualStyleBackColor = true;
            this.button_cadastrar_alterar.Click += new System.EventHandler(this.button_cadastrar_alterar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.Location = new System.Drawing.Point(235, 250);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(89, 32);
            this.button_excluir.TabIndex = 12;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_limpar
            // 
            this.button_limpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_limpar.Location = new System.Drawing.Point(330, 250);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(77, 32);
            this.button_limpar.TabIndex = 13;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // dateTimePicker_dn
            // 
            this.dateTimePicker_dn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dn.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker_dn.Location = new System.Drawing.Point(235, 53);
            this.dateTimePicker_dn.Name = "dateTimePicker_dn";
            this.dateTimePicker_dn.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker_dn.TabIndex = 14;
            // 
            // listBox_lista
            // 
            this.listBox_lista.FormattingEnabled = true;
            this.listBox_lista.Location = new System.Drawing.Point(56, 288);
            this.listBox_lista.Name = "listBox_lista";
            this.listBox_lista.Size = new System.Drawing.Size(351, 69);
            this.listBox_lista.TabIndex = 15;
            this.listBox_lista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_lista_MouseDoubleClick);
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(142, 109);
            this.maskedTextBox_telefone.Mask = "(99) 9 9999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(265, 20);
            this.maskedTextBox_telefone.TabIndex = 16;
            // 
            // dataGridView_pessoa
            // 
            this.dataGridView_pessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pessoa.Location = new System.Drawing.Point(54, 363);
            this.dataGridView_pessoa.Name = "dataGridView_pessoa";
            this.dataGridView_pessoa.Size = new System.Drawing.Size(353, 94);
            this.dataGridView_pessoa.TabIndex = 17;
            this.dataGridView_pessoa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_pessoa_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 461);
            this.Controls.Add(this.dataGridView_pessoa);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.listBox_lista);
            this.Controls.Add(this.dateTimePicker_dn);
            this.Controls.Add(this.button_limpar);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.button_cadastrar_alterar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_veiculo);
            this.Controls.Add(this.checkBox_casaPropria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_estCivil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_estCivil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_casaPropria;
        private System.Windows.Forms.CheckBox checkBox_veiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_outros;
        private System.Windows.Forms.RadioButton radioButton_fem;
        private System.Windows.Forms.RadioButton radioButton_masc;
        private System.Windows.Forms.Button button_cadastrar_alterar;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_limpar;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dn;
        private System.Windows.Forms.ListBox listBox_lista;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.DataGridView dataGridView_pessoa;
    }
}

