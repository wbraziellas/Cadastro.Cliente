using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Cliente.Repository.Base;
using System.Data.SqlClient;
using System.Data;
using Cadastro.Cliente.Repository.DTO;

namespace Cadastro.Cliente.Repository
{
    public class LougradouroDTORepository : BaseSQL
    {
        public List<LogradouroDTO> SelecionarLogradouro(int idcliente)
        {
            #region SQL para selecionar o Logradouro

            string _strSql = "SELECT * FROM LOGRADOURO WHERE IDCLIENTE = @IDCLIENTE";

            #endregion

            try
            {
                if(Conectar())
                {
                    SqlCommand _cmdSql = new SqlCommand(_strSql, sqlConn);
                    _cmdSql.Parameters.AddWithValue("@IDCLIENTE", idcliente);

                    SqlDataAdapter adapter = new SqlDataAdapter() { SelectCommand = _cmdSql };
                    DataTable data = new DataTable();

                    adapter.Fill(data);

                    return ConverterDataEmLogradouro(data);
                }
            }
            catch(Exception eErro)
            {
                throw eErro;
            }

            return new List<LogradouroDTO>();
        }
        public void InserirLogradouro(LogradouroDTO logradouro)
        {
            #region SQL para inserir logradouro do cliente no banco

            string _strSql = "INSERT INTO " +
                                "LOGRADOURO(IDCLIENTE, LOGRADOURO, NUMERO, BAIRRO, CIDADE, CEP, UF) " +
                                "VALUES(@IDCLIENTE, @LOGRADOURO, @NUMERO, @BAIRRO, @CIDADE, @CEP, @UF)";

            #endregion

            try
            {
                if(Conectar())
                {
                    SqlCommand _sqlCmd = new SqlCommand(_strSql, sqlConn);
                    _sqlCmd.Parameters.AddWithValue("@IDCLIENTE", logradouro.idCliente);
                    _sqlCmd.Parameters.AddWithValue("@LOGRADOURO", logradouro.Logradouro);
                    _sqlCmd.Parameters.AddWithValue("@NUMERO", logradouro.Numero);
                    _sqlCmd.Parameters.AddWithValue("@BAIRRO", logradouro.Bairro);
                    _sqlCmd.Parameters.AddWithValue("@CIDADE", logradouro.Cidade);
                    _sqlCmd.Parameters.AddWithValue("@CEP", logradouro.cep);
                    _sqlCmd.Parameters.AddWithValue("@UF", logradouro.Uf);

                    _sqlCmd.ExecuteNonQuery();
                }
            }
            catch(Exception eErro)
            {
                throw eErro;
            }
        }
        public void AlterarLogradouro(LogradouroDTO logradouro)
        {
            #region SQL para alterar o logradouro

            string _strSql = "UPDATE LOGRADOURO SET " +
                                "LOGRADOURO = @LOGRADOURO " +
                                "NUMERO = @NUMERO " +
                                "BAIRRO = @BAIRRO " +
                                "CIDADE = @CIDADE " +
                                "CEP = @CEP " +
                                "UF = @UF " +
                             "WHERE ID = @ID";

            #endregion

            try
            {
                if(Conectar())
                {
                    SqlCommand _cmdSql = new SqlCommand(_strSql, sqlConn);
                    _cmdSql.Parameters.AddWithValue("@LOGRADOURO", logradouro.Logradouro);
                    _cmdSql.Parameters.AddWithValue("@NUMERO", logradouro.Numero);
                    _cmdSql.Parameters.AddWithValue("@BAIRRO", logradouro.Bairro);
                    _cmdSql.Parameters.AddWithValue("@CIADADE", logradouro.Cidade);
                    _cmdSql.Parameters.AddWithValue("@CEP", logradouro.cep);
                    _cmdSql.Parameters.AddWithValue("@UF", logradouro.Uf);

                    _cmdSql.ExecuteNonQuery();
                }
            }
            catch(Exception eErro)
            {
                throw eErro;
            }
        }
        public void DeletarLogradouro(int idCliente)
        {
            #region SQL para alterar o logradouro

            string _strSql = "DELETE FROM LOGRADOURO WHERE IDCLIENTE = @IDCLIENTE";

            #endregion

            try
            {
                if (Conectar())
                {
                    SqlCommand _cmdSql = new SqlCommand(_strSql, sqlConn);
                    _cmdSql.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                    _cmdSql.ExecuteNonQuery();
                }
            }
            catch (Exception eErro)
            {
                throw eErro;
            }
        }
    
        #region Métodos Privados

        private List<LogradouroDTO> ConverterDataEmLogradouro(DataTable data)
        {
            var listaLogradouro = new List<LogradouroDTO>();

            foreach(DataRow row in data.Rows)
            {
                var linha = row.ItemArray;
                var logradouro = new LogradouroDTO();

                logradouro.id = Convert.ToInt32(linha[0]);
                logradouro.idCliente = Convert.ToInt32(linha[1]);
                logradouro.Logradouro = linha[2].ToString();
                logradouro.Numero = Convert.ToInt32(linha[3]);
                logradouro.Bairro = linha[4].ToString();
                logradouro.Cidade = linha[5].ToString();
                logradouro.cep = Convert.ToInt32(linha[6]);

                listaLogradouro.Add(logradouro);
            }

            return listaLogradouro;
        }

        #endregion
    }
}
