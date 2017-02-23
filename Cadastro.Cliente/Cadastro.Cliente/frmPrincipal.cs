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

        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGridClientes(txtPesquisa.Text);
        }

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
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarGridClientes(txtPesquisa.Text);
        }

        private void gridClientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var item = gridClientes.Items[0].Focused = true;
            var item1 = gridClientes.Items[0].Selected = true;


        }
    }
}
