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
    public partial class Form1 : Form
    {
        #region Propriedades

        private ClienteController _clienteController;
        private ClienteController clienteController
        {
            get { return _clienteController ?? (_clienteController = new ClienteController()); }
        }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarGridClientes();
        }

        private void CarregarGridClientes()
        {
            var clientes = clienteController.RetornarClientes();

            foreach (var cliente in clientes)
            {
                ListViewItem itemGridCliente = new ListViewItem(cliente.Codigo.ToString());
                itemGridCliente.SubItems.Add(cliente.Nome.ToString());
                itemGridCliente.SubItems.Add(cliente.Telefone);
                itemGridCliente.SubItems.Add(cliente.Cgc);

                gridClientes.Items.Add(itemGridCliente);
            }
        }
    }
}
