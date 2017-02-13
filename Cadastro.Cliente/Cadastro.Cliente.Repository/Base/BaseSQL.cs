using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Cadastro.Cliente.Repository.Base
{
    public class BaseSQL
    {
        string _strConn = @"Server=WILLIAM-PC\SQLEXPRESS;Database=Cli_Contro;Trusted_Connection=yes;";
        SqlConnection _sqlConn;

        public bool Conectar()
        {
            _sqlConn = new SqlConnection(_strConn);

            try
            {
                if (ConnectionState.Closed == _sqlConn.State)
                {
                    _sqlConn.Open();
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
            finally
            {
                _sqlConn.Close();
                _sqlConn.Dispose();
            }
        }

        public bool Desconectar()
        {
            try
            {
                if (_sqlConn.State != ConnectionState.Closed)
                {
                    _sqlConn.Close();
                    _sqlConn.Dispose();

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
