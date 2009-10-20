using Fachada.Fachada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fachada.Basicas;
using System.Collections.Generic;
using System.Data;

namespace Testes
{


    /// <summary>
    ///This is a test class for FachadaFuncionarioTest and is intended
    ///to contain all FachadaFuncionarioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FachadaFuncionarioTest
    {

        private Funcionario funcionario;
        private TestContext testContextInstance;

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
            this.funcionario = new Funcionario();
            this.funcionario.Nome = "teste";
            this.funcionario.Fone = "8134351319";
            this.funcionario.Endereco = "teste";
            this.funcionario.Estado = "te";
            this.funcionario.Funcao = "1";
            this.funcionario.Numero = 1234;
            this.funcionario.Idestabelecimento = 2;
            this.funcionario.Email = "teste@teste.com";
            this.funcionario.Cpf = "76210483607";
            this.funcionario.Cidade = "teste";
            this.funcionario.Cep = "teste";
            this.funcionario.Bairro = "teste";
            this.funcionario.Fonecelular = "8134351391";
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
        ///A test for ListarFuncionario
        ///</summary>
        [TestMethod()]
        public void ListarFuncionarioTest1()
        {
            this.MyTestInitialize();
            DataSet actual = Fachada_Accessor.ObterFachada().ListarFuncionario();
            Assert.AreEqual(0,actual.Tables[0].Rows.Count);
        }

        /// <summary>
        ///A test for ListarFuncionario
        ///</summary>
        [TestMethod()]
        public void ListarFuncionarioTest()
        {
            Assert.Fail("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for InserirFuncionario
        ///</summary>
        [TestMethod()]
        public void InserirFuncionarioTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().InserirFuncionario(this.funcionario);
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            Assert.AreEqual(this.funcionario.Cpf, f.Cpf);
        }

        /// <summary>
        ///A test for ExcluirFuncionario
        ///</summary>
        [TestMethod()]
        public void ExcluirFuncionarioTest1()
        {
            this.MyTestInitialize();
            try
            {
                Fachada_Accessor.ObterFachada().ExcluirFuncionario(this.funcionario.Cpf);
                Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            }
            catch{ Assert.IsTrue(true);}
        }

        /// <summary>
        ///A test for ExcluirFuncionario
        ///</summary>
        [TestMethod()]
        public void ExcluirFuncionarioTest()
        {
            Assert.Fail("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ConsultarFuncionario
        ///</summary>
        [TestMethod()]
        public void ConsultarFuncionarioTest1()
        {
            this.MyTestInitialize();
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            Assert.AreEqual(this.funcionario.Cpf, f.Cpf);
        }

        /// <summary>
        ///A test for ConsultarFuncionario
        ///</summary>
        [TestMethod()]
        public void ConsultarFuncionarioTest()
        {
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(0);
            Assert.IsNotNull(f.Cpf);
        }

        /// <summary>
        ///A test for AlterarFuncionario
        ///</summary>
        [TestMethod()]
        public void AlterarFuncionarioTest()
        {
            this.MyTestInitialize();
            this.funcionario = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            this.funcionario.Nome = "ALTERADO";
            Fachada_Accessor.ObterFachada().AlterarFuncionario(this.funcionario);
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            Assert.AreEqual(this.funcionario.Nome, f.Nome);
        }
    }
}
