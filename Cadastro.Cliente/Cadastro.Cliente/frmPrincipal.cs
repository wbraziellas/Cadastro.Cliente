using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cadastro.Cliente.Controller;
using Cadastro.Cliente.Repository.DTO;

namespace Cadastro.Cliente
{
    public partial class frmPrincipal : Form
    {
        #region Propriedades

        private ClienteController _clienteController;
        private ClienteController clienteController
        {
            get { return _clienteController ?? (_clienteController = new ClienteController()); }
        }

        private LogradouroController _logradouroController;
        private LogradouroController logradouroController
        {
            get { return _logradouroController ?? (_logradouroController = new LogradouroController()); }
        }

        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGridClientes(txtPesquisa.Text);
        }
        
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarGridClientes(txtPesquisa.Text);
        }

        private void gridClientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var idCliente = RetornarIdClienteSelecionado();
            if (idCliente > -1)
                CarregarGridLogradouro(Convert.ToInt32(idCliente));

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                var idCliente = RetornarIdClienteSelecionado();

                if (idCliente > -1)
                {
                    DialogResult deletar = MessageBox.Show("Deletar Cliente " + RetornarNomeClienteSelecionado(), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (deletar)
                    {
                        case DialogResult.Yes:
                            clienteController.DeletarCliente(idCliente);
                            logradouroController.DeletarLogradouro(idCliente);
                            CarregarGridClientes(txtPesquisa.Text);
                            CarregarGridLogradouro(idCliente);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception eErro)
            {
                MessageBox.Show("Erro ao deletar cliente: " + eErro.Message);
            }
        }

        #region Métodos privados criados

        private void CarregarGridClientes(string textoPesquisa)
        {
            gridClientes.Items.Clear();
            var clientes = clienteController.RetornarClientes(textoPesquisa);

            foreach (var cliente in clientes)
            {
                ListViewItem itemGridCliente = new ListViewItem(cliente.id.ToString());
                itemGridCliente.SubItems.Add(cliente.Nome.ToString());
                itemGridCliente.SubItems.Add(cliente.Telefone);
                itemGridCliente.SubItems.Add(cliente.Cgc);

                gridClientes.Items.Add(itemGridCliente);
            }

            if (gridClientes.Items.Count > 0)
                gridClientes.Items[0].Selected = true;
        }
        private void CarregarGridLogradouro(int idCliente)
        {
            grdEndereco.Items.Clear();

            var enderecoCliente = logradouroController.RetornarLogradouro(idCliente);

            foreach (var end in enderecoCliente)
            {
                ListViewItem itemGridEndereco = new ListViewItem(end.id.ToString());
                itemGridEndereco.SubItems.Add(end.Logradouro);
                itemGridEndereco.SubItems.Add(end.Numero.ToString());
                itemGridEndereco.SubItems.Add(Convert.ToString(end.Uf));

                grdEndereco.Items.Add(itemGridEndereco);
            }
        }
        private int RetornarIdClienteSelecionado()
        {
            if (gridClientes.SelectedItems.Count > 0)
            {
                return Convert.ToInt32(gridClientes.SelectedItems[0].SubItems[0].Text);
            }
            else
                return -1;
        }
        private string RetornarNomeClienteSelecionado()
        {
            {
                if (gridClientes.SelectedItems.Count > 0)
                {
                    return gridClientes.SelectedItems[0].SubItems[1].Text;
                }
                else
                    return null;
            }
        }

        #endregion

        
    }
}
