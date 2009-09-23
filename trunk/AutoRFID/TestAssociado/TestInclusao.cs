using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fachada.Fachada;
using Fachada.Basicas;

namespace TestAssociado
{
    /// <summary>
    /// Teste de inclusão de dados do associado
    /// </summary>
    [TestClass]
    public class TestInclusao
    {
        private Associado objAss;
        private Fachada.Fachada.Fachada objFachada = null;

         
        public TestInclusao()
        {
            this.objFachada = Fachada.Fachada.Fachada.ObterFachada();
        }

        private TestContext testContextInstance;

     

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
         
            objAss = new Associado();
            //objAss.Cpf_cnpj = "1112";
            objAss.Nome_razaosocial = "Leandro";
            objFachada.InserirAssociado(objAss); 
 
            //
            // TODO: Add test logic	here
            //
        }
    }
}
