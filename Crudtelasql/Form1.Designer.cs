namespace Crudtelasql
{
    partial class frmCadastroCliente
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
            this.tsbNovo = new System.Windows.Forms.Button();
            this.tsbSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.TextBox();
            this.tsbBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tsbExcluir = new System.Windows.Forms.Button();
            this.tsbCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tsbNovo
            // 
            this.tsbNovo.Location = new System.Drawing.Point(-3, 3);
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(75, 23);
            this.tsbNovo.TabIndex = 0;
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.UseVisualStyleBackColor = true;
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // tsbSalvar
            // 
            this.tsbSalvar.Location = new System.Drawing.Point(78, 3);
            this.tsbSalvar.Name = "tsbSalvar";
            this.tsbSalvar.Size = new System.Drawing.Size(75, 23);
            this.tsbSalvar.TabIndex = 1;
            this.tsbSalvar.Text = "Salvar";
            this.tsbSalvar.UseVisualStyleBackColor = true;
            this.tsbSalvar.Click += new System.EventHandler(this.tsbSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar por ID";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(409, 5);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(103, 20);
            this.text.TabIndex = 5;
            // 
            // tsbBuscar
            // 
            this.tsbBuscar.Location = new System.Drawing.Point(518, 5);
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(75, 23);
            this.tsbBuscar.TabIndex = 6;
            this.tsbBuscar.Text = "Buscar";
            this.tsbBuscar.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(12, 54);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 54);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(619, 20);
            this.txtNome.TabIndex = 10;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 93);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(673, 20);
            this.txtEndereco.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Endereço";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tsbExcluir
            // 
            this.tsbExcluir.ForeColor = System.Drawing.Color.Black;
            this.tsbExcluir.Location = new System.Drawing.Point(240, 3);
            this.tsbExcluir.Name = "tsbExcluir";
            this.tsbExcluir.Size = new System.Drawing.Size(75, 23);
            this.tsbExcluir.TabIndex = 3;
            this.tsbExcluir.Text = "Excluir";
            this.tsbExcluir.UseVisualStyleBackColor = true;
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Location = new System.Drawing.Point(159, 3);
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(75, 23);
            this.tsbCancelar.TabIndex = 2;
            this.tsbCancelar.Text = "Cancelar";
            this.tsbCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "CEP";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(13, 133);
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(100, 20);
            this.mskCEP.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Bairro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(119, 133);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(269, 20);
            this.txtBairro.TabIndex = 16;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(394, 132);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(206, 20);
            this.txtCidade.TabIndex = 17;
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(606, 133);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(79, 20);
            this.txtUf.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(394, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "UF";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Telefone";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(10, 183);
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 22;
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUf);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskCEP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.tsbBuscar);
            this.Controls.Add(this.text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsbExcluir);
            this.Controls.Add(this.tsbCancelar);
            this.Controls.Add(this.tsbSalvar);
            this.Controls.Add(this.tsbNovo);
            this.Name = "frmCadastroCliente";
            this.Text = "Tela de adastro de Funcionario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tsbNovo;
        private System.Windows.Forms.Button tsbSalvar;
        private System.Windows.Forms.Button tsbCancelar;
        private System.Windows.Forms.Button tsbExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button tsbBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mskCEP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mskTelefone;
    }
}

