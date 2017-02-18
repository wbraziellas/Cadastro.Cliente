using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Cadastro.Cliente.Repository.Base.Escopo;

namespace Cadastro.Cliente.Repository.Base
{
    public abstract class BaseSQL : BaseEscopo
    {
        public override bool Conectar()
        {
            sqlConn = new SqlConnection(strConn);

            try
            {
                if (ConnectionState.Closed == sqlConn.State)
                {
                    sqlConn.Open();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception eErro)
            {
                Desconectar();
                throw eErro;
            }
        }

        public override bool Desconectar()
        {
            try
            {
                if (sqlConn.State != ConnectionState.Closed)
                {
                    sqlConn.Close();
                    sqlConn.Dispose();

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception eErro)
            {
                throw eErro;
            }
        }
    }
}
