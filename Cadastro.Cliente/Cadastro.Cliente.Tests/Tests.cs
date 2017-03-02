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

        private LougradouroDTORepository _logradouroRepository;
        private LougradouroDTORepository logradouroRepository
        {
            get { return _logradouroRepository ?? (_logradouroRepository = new LougradouroDTORepository()); }
        }
        #endregion

        [TestMethod]
        public void Testar_Retorno_Cadastro_Cliente()
        {
            var cliente = new ClientesDTO()
            {
                Nome = "Três",
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
            listaClientes = clienteRepository.SelecionarClientes("");

            Assert.IsNotNull(listaClientes, "Retornou Lista Nula");
        }

        #region Testar Logradouro

        [TestMethod]
        public void Testar_Gravacao_Logradouro()
        {
            var logradouro = new LogradouroDTO()
            {
                idCliente = 1004,
                Logradouro = "rua teste 5",
                Numero = 23,
                Bairro = "bairro teste 5",
                Cidade = "Teresópolis",
                cep = 25955000,
                Uf = "RJ"
            };

            logradouroRepository.InserirLogradouro(logradouro);
        }

        #endregion

    }
}
