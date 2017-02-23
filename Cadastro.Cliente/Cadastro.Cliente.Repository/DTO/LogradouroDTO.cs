using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Cliente.Repository.DTO
{
    public class LogradouroDTO
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int cep { get; set; }
        public string Uf { get; set; }
    }
}
