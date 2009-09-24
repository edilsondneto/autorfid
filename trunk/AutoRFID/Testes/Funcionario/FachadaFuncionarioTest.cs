using Fachada.Fachada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fachada.Basicas;
using System.Collections.Generic;

namespace Testes
{
    
    
    /// <summary>
    ///This is a test class for FachadaFuncionarioTest and is intended
    ///to contain all FachadaFuncionarioTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FachadaFuncionarioTest
    {

        private Funcionario x;
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
        //    
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        public void MyTestInitialize()
        {
            this.x = new Funcionario();
            this.x.Nome = "teste";
            this.x.Fone = "teste";
            this.x.Endereco = "tesete";
            this.x.Estado = "te";
            this.x.Idestabelecimento = 1;
            this.x.Funcao = "z";
            this.x.Numero = 1234;
            this.x.Email = "asdfadsfsdf";
            this.x.Cpf = "12345678910";
            this.x.Cidade = "xxxxx";
            this.x.Cep = "adfas";
            this.x.Bairro = "asdf";
            this.x.Fonecelular = "1234";

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
        public void ListarFuncionarioTest()
        {
            int expected = 2;
            int actual = Fachada_Accessor.ObterFachada().ListarFuncionario().Count;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for InserirFuncionario
        ///</summary>
        [TestMethod()]
        public void InserirFuncionarioTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().InserirFuncionario(x);
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(x.Cpf);
            Assert.AreEqual(this.x.Nome, f.Nome);
        }

        /// <summary>
        ///A test for ConsultarFuncionario
        ///</summary>
        [TestMethod()]
        public void ConsultarFuncionarioTest1()
        {
            this.MyTestInitialize();
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.x.Cpf);
            Assert.AreEqual(null, f.Cpf);
        }

        /// <summary>
        ///A test for ExcluirFuncionario
        ///</summary>
        [TestMethod()]
        public void ExcluirFuncionarioTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().ExcluirFuncionario(this.x.Cpf);
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.x.Cpf);
            Assert.AreEqual(null,f.Cpf);
            
        }

        /// <summary>
        ///A test for AlterarFuncionario
        ///</summary>
        [TestMethod()]
        public void AlterarFuncionarioTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().InserirFuncionario(this.x);
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.x.Cpf);
            f.Cpf = "0000";
            Fachada_Accessor.ObterFachada().AlterarFuncionario(f);
            Funcionario ex = Fachada_Accessor.ObterFachada().ConsultarFuncionario(f.Cpf);
            Assert.AreEqual(f.Cpf,ex.Cpf);
        }
    }
}
