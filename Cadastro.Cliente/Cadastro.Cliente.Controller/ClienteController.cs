using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Cliente.Repository;
using Cadastro.Cliente.Repository.DTO;

namespace Cadastro.Cliente.Controller
{
    public class ClienteController
    {
        #region Propriedades

        private ClientesDTORepository _clienteRepository;
        private ClientesDTORepository clienteRepository
        {
            get { return _clienteRepository ?? (_clienteRepository = new ClientesDTORepository()); }
        }

        #endregion

        public List<ClientesDTO> RetornarClientes(string pesquisar)
        {
            return clienteRepository.SelecionarClientes(pesquisar);
        }
        public void DeletarCliente(int idCliente)
        {
            clienteRepository.DeletarCliente(idCliente);
        }

    }
}
