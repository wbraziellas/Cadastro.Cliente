﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro.Cliente.Repository.Base;
using Cadastro.Cliente.Repository.DTO;
using System.Data.SqlClient;
using System.Data;

namespace Cadastro.Cliente.Repository
{
    public class ClientesDTORepository : BaseSQL
    {       
        public void InserirCliente(ClientesDTO cliente)
        {
            #region Comando SQL Isert
            string _strCmd = "INSERT INTO CLIENTES " + 
                                "(CODIGO, NOME, TELEFONE, CGC, RG, DATACADASTRO) " + 
                             "VALUES(@CODIGO, @NOME, @TELEFONE, @CGC, @RG, @DATACADASTRO)";
            #endregion

            if (Conectar() == true)
            {
                SqlCommand _sqlCmd = new SqlCommand(_strCmd, sqlConn);

                _sqlCmd.Parameters.AddWithValue("@CODIGO", cliente.Codigo);
                _sqlCmd.Parameters.AddWithValue("@NOME", cliente.Nome);
                _sqlCmd.Parameters.AddWithValue("@TELEFONE", cliente.Telefone);
                _sqlCmd.Parameters.AddWithValue("@CGC", cliente.Cgc);
                _sqlCmd.Parameters.AddWithValue("@RG", cliente.Rg);
                _sqlCmd.Parameters.AddWithValue("@DATACADASTRO", cliente.DataCadastro);

                _sqlCmd.ExecuteNonQuery();

            }
        }
        public void AlterarCliente(ClientesDTO cliente)
        {
            #region Comando SQL Update
            string _strCmd = "UPDATE CLIENTES SET " +
                                    "CODIGO = @CODIGO " +
                                    "NOME = @NOME " +
                                    "TELEFONE = @TELEFONE " +
                                    "CGC = @CGC " +
                                    "RG = @RG " +
                                    "DATACADASTRO = @DATACADASTRO";
            #endregion
            try
            {
                if(Conectar())
                {

                }
            }
            catch(Exception eError)
            {
                throw eError;
            }
        }
        public List<ClientesDTO> SelecionarClientes()
        {
            string _strCmd = "SELECT * FROM CLIENTES";
            try
            {
                if(Conectar())
                {
                    var _sqlCmd = new SqlCommand(_strCmd, sqlConn);
                    SqlDataAdapter adapter = new SqlDataAdapter() { SelectCommand = _sqlCmd };
                    DataTable data = new DataTable();

                    adapter.Fill(data);

                    return ConverterDataEmCliente(data);
                }
            }
            catch(Exception eError)
            {
                Desconectar();
                return new List<ClientesDTO>();
            }

            return new List<ClientesDTO>();
        }

        #region Métodos Privados

        private List<ClientesDTO> ConverterDataEmCliente(DataTable data)
        {
            var listaClientes = new List<ClientesDTO>();

            foreach(DataRow row in data.Rows)
            {
                var cliente = new ClientesDTO();
                var linha = row.ItemArray;

                cliente.id = Convert.ToInt32(linha[0]);
                cliente.Codigo = Convert.ToInt32(linha[1]);
                cliente.Nome = linha[2].ToString();
                cliente.Telefone = linha[3].ToString();
                cliente.Cgc = linha[4].ToString();
                cliente.Rg = linha[5].ToString();
                cliente.DataCadastro = Convert.ToDateTime(linha[6]);

                listaClientes.Add(cliente);
            }

            return listaClientes;
        }

        #endregion

    }
}
