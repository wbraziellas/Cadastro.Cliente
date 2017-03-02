using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Cliente.Repository;
using Cadastro.Cliente.Repository.DTO;

namespace Cadastro.Cliente.Controller
{
    public class LogradouroController
    {
        #region Propriedades

        private LougradouroDTORepository _logradouroRepository;
        private LougradouroDTORepository logradouroRepository
        {
            get { return _logradouroRepository ?? (_logradouroRepository = new LougradouroDTORepository()); }
        }

        #endregion

        public List<LogradouroDTO> RetornarLogradouro(int idcliente)
        {
            return logradouroRepository.SelecionarLogradouro(idcliente);
        }
        public void DeletarLogradouro(int idCliente)
        {
            logradouroRepository.DeletarLogradouro(idCliente);
        }
    }
}
