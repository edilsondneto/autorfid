using Fachada.Fachada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fachada.Basicas;
using System.Collections.Generic;

namespace Testes
{
    
    
    /// <summary>
    ///This is a test class for FachadaTest and is intended
    ///to contain all FachadaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FachadaTest
    {


        private TestContext testContextInstance;
        private Funcionario x;
        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
             this.x = new Funcionario();
            x.Nome = "teste";
            x.Fone = "teste";
            x.Estado = "te";
            x.Foto = "teste";
            x.Idestabelecimento = 1;
            x.Idtipofuncionario = 1;
            x.Numero = 1234;
            x.Email = "asdfadsfsdf";
            x.Cpf = "12345678910";
            x.Cidade = "xxxxx";
            x.Cep = "adfasdfasd";
            x.Bairro = "asdf";
        }
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion

        /// <summary>
        ///A test for InserirFuncionario
        ///</summary>
        [TestMethod()]
        public void InserirFuncionarioTest()
        {
            Fachada_Accessor target = new Fachada_Accessor(); // TODO: Initialize to an appropriate value
            target.InserirFuncionario(this.x);
            Funcionario f = target.ConsultarFuncionario(1);
            Assert.Equals(this.x,f);
        }

        /// <summary>
        ///A test for ListarFuncionario
        ///</summary>
        [TestMethod()]
        public void ListarFuncionarioTest()
        {
            Fachada_Accessor target = new Fachada_Accessor(); // TODO: Initialize to an appropriate value
            List<Funcionario> expected = null; // TODO: Initialize to an appropriate value
            List<Funcionario> actual;
            actual = target.ListarFuncionario();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ExcluirFuncionario
        ///</summary>
        [TestMethod()]
        public void ExcluirFuncionarioTest()
        {
            Fachada_Accessor target = new Fachada_Accessor(); // TODO: Initialize to an appropriate value
            int codigo = 0; // TODO: Initialize to an appropriate value
            target.ExcluirFuncionario(codigo);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ConsultarFuncionario
        ///</summary>
        [TestMethod()]
        public void ConsultarFuncionarioTest1()
        {
            Fachada_Accessor target = new Fachada_Accessor(); // TODO: Initialize to an appropriate value
            int codigo = 0; // TODO: Initialize to an appropriate value
            Funcionario expected = null; // TODO: Initialize to an appropriate value
            Funcionario actual;
            actual = target.ConsultarFuncionario(codigo);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ConsultarFuncionario
        ///</summary>
        [TestMethod()]
        public void ConsultarFuncionarioTest()
        {
            Fachada_Accessor target = new Fachada_Accessor(); // TODO: Initialize to an appropriate value
            string cpf = string.Empty; // TODO: Initialize to an appropriate value
            Funcionario expected = null; // TODO: Initialize to an appropriate value
            Funcionario actual;
            actual = target.ConsultarFuncionario(cpf);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for AlterarFuncionario
        ///</summary>
        [TestMethod()]
        public void AlterarFuncionarioTest()
        {
            Fachada_Accessor target = new Fachada_Accessor(); // TODO: Initialize to an appropriate value
            Funcionario f = null; // TODO: Initialize to an appropriate value
            target.AlterarFuncionario(f);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
