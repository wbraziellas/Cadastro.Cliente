using System;
using Cadastro.Cliente.Repository.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cadastro.Cliente.Teste
{
    [TestClass]
    public class Testes
    {
        #region Propriedades

        private BaseSQL _baseSQL;
        private BaseSQL baseSQL
        {
            get { return _baseSQL ?? (_baseSQL = new BaseSQL()); }
            set { }
        }

        #endregion
        [TestMethod]
        public void Testar_Conexao_Com_O_BD()
        {
            var conectar = baseSQL.Conectar();
            Assert.IsTrue(conectar, "Falou a conexão!");
        }
    }
}
