﻿namespace Cadastro.Cliente
{
    partial class frmPrincipal
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.gridClientes = new System.Windows.Forms.ListView();
            this.grdCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grdNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grdTelefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grdCgc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.grdEndereco = new System.Windows.Forms.ListView();
            this.grdLogradouroId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grdLogradouroNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grdLogradouroNumero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grdLogradouroUf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(12, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(117, 95);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(146, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(117, 95);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Location = new System.Drawing.Point(278, 12);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(117, 95);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // gridClientes
            // 
            this.gridClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.grdCodigo,
            this.grdNome,
            this.grdTelefone,
            this.grdCgc});
            this.gridClientes.FullRowSelect = true;
            this.gridClientes.Location = new System.Drawing.Point(12, 128);
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(921, 128);
            this.gridClientes.TabIndex = 3;
            this.gridClientes.UseCompatibleStateImageBehavior = false;
            this.gridClientes.View = System.Windows.Forms.View.Details;
            this.gridClientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.gridClientes_ItemSelectionChanged);
            // 
            // grdCodigo
            // 
            this.grdCodigo.Text = "Código";
            this.grdCodigo.Width = 100;
            // 
            // grdNome
            // 
            this.grdNome.Text = "Nome";
            this.grdNome.Width = 500;
            // 
            // grdTelefone
            // 
            this.grdTelefone.Text = "Telefone";
            this.grdTelefone.Width = 80;
            // 
            // grdCgc
            // 
            this.grdCgc.Text = "CGC";
            this.grdCgc.Width = 100;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(410, 35);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(476, 38);
            this.txtPesquisa.TabIndex = 4;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // grdEndereco
            // 
            this.grdEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEndereco.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.grdLogradouroId,
            this.grdLogradouroNome,
            this.grdLogradouroNumero,
            this.grdLogradouroUf});
            this.grdEndereco.FullRowSelect = true;
            this.grdEndereco.Location = new System.Drawing.Point(12, 287);
            this.grdEndereco.Name = "grdEndereco";
            this.grdEndereco.Size = new System.Drawing.Size(921, 110);
            this.grdEndereco.TabIndex = 5;
            this.grdEndereco.UseCompatibleStateImageBehavior = false;
            this.grdEndereco.View = System.Windows.Forms.View.Details;
            // 
            // grdLogradouroId
            // 
            this.grdLogradouroId.Text = "Id";
            this.grdLogradouroId.Width = 100;
            // 
            // grdLogradouroNome
            // 
            this.grdLogradouroNome.Text = "Logradouro";
            this.grdLogradouroNome.Width = 400;
            // 
            // grdLogradouroNumero
            // 
            this.grdLogradouroNumero.Text = "Número";
            // 
            // grdLogradouroUf
            // 
            this.grdLogradouroUf.Text = "UF";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 409);
            this.Controls.Add(this.grdEndereco);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.gridClientes);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditar);
            this.Name = "frmPrincipal";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ListView gridClientes;
        private System.Windows.Forms.ColumnHeader grdCodigo;
        private System.Windows.Forms.ColumnHeader grdNome;
        private System.Windows.Forms.ColumnHeader grdTelefone;
        private System.Windows.Forms.ColumnHeader grdCgc;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ListView grdEndereco;
        private System.Windows.Forms.ColumnHeader grdLogradouroId;
        private System.Windows.Forms.ColumnHeader grdLogradouroNome;
        private System.Windows.Forms.ColumnHeader grdLogradouroNumero;
        private System.Windows.Forms.ColumnHeader grdLogradouroUf;
    }
}

