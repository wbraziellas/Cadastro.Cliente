using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Cliente.Repository.DTO
{
    public class ClientesDTO
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cgc { get; set; }
        public string Rg { get; set; }
        public DateTime DataCadastro { get; set; }
        public LogradouroDTO Endereco { get; set; }
    }
}
