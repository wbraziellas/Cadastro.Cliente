using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Cadastro.Cliente.Repository.Base.Escopo
{
    public abstract class BaseEscopo
    {
        private string _strConn = @"Server=WILLIAM-PC\SQLEXPRESS;Database=Cli_Contro;Trusted_Connection=yes;";
        private SqlConnection _sqlConn;

        public string strConn
        {
            get { return _strConn; }
        }

        public SqlConnection sqlConn
        {
            get { return _sqlConn; }
            set { _sqlConn = value; }
        }

        public abstract bool Conectar();

        public abstract bool Desconectar();
    }
}
