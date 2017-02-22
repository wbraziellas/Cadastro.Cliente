using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cadastro.Cliente.Repository;
using Cadastro.Cliente.Repository.DTO;
using System.Collections.Generic;

namespace Cadastro.Cliente.Tests
{
    [TestClass]
    public class Tests
    {
        #region Propriedades

        private ClientesDTORepository _clienteRopository;
        private ClientesDTORepository clienteRepository
        {
            get { return _clienteRopository ?? (_clienteRopository = new ClientesDTORepository()); }
        }

        #endregion

        [TestMethod]
        public void Testar_Retorno_Cadastro_Cliente()
        {
            var cliente = new ClientesDTO()
            {
                Nome = "trÊs",
                Cgc = "12312312387",
                DataCadastro = Convert.ToDateTime(DateTime.Now),
                Telefone = "1231231890",
                Rg = "12413241234"
            };
            clienteRepository.InserirCliente(cliente);
        }

        [TestMethod]
        public void Testar_Retornar_Clientes()
        {
            var listaClientes = new List<ClientesDTO>();
            listaClientes = clienteRepository.SelecionarClientes();

            Assert.IsNotNull(listaClientes, "Retornou Lista Nula");
        }
    }
}
