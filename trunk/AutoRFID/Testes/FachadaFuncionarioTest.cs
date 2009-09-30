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
            this.funcionario = new Funcionario();
            this.funcionario.Nome = "teste";
            this.funcionario.Fone = "teste";
            this.funcionario.Endereco = "tesete";
            this.funcionario.Estado = "te";
            this.funcionario.Idestabelecimento = 2;
            this.funcionario.Funcao = "z";
            this.funcionario.Numero = 1234;
            this.funcionario.Email = "asdfadsfsdf";
            this.funcionario.Cpf = "12345678910";
            this.funcionario.Cidade = "xxxxx";
            this.funcionario.Cep = "adfas";
            this.funcionario.Bairro = "asdf";
            this.funcionario.Fonecelular = "1234";

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
            //int expected = 5;
            //int actual = Fachada_Accessor.ObterFachada().ListarFuncionario().Count;
            //Assert.AreEqual(expected, actual);
            List<Funcionario> actual = Fachada_Accessor.ObterFachada().ListarFuncionario();
            Assert.IsTrue(actual.Count > 0);

        }

        /// <summary>
        ///A test for InserirFuncionario
        ///</summary>
        [TestMethod()]
        public void InserirFuncionarioTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().InserirFuncionario(funcionario);
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(funcionario.Cpf);
            Assert.AreEqual(this.funcionario.Nome, f.Nome);
        }

        /// <summary>
        ///A test for ConsultarFuncionario
        ///</summary>
        [Priority(1), TestMethod()]
        public void ConsultarFuncionarioTest1()
        {
            this.MyTestInitialize();
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            Assert.AreEqual(this.funcionario.Cpf, f.Cpf);
        }

        /// <summary>
        ///A test for ExcluirFuncionario
        ///</summary>
        [TestMethod()]
        public void ExcluirFuncionarioTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().ExcluirFuncionario("0000");
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            Assert.AreEqual(null, f.Cpf);

        }

        /// <summary>
        ///A test for AlterarFuncionario
        ///</summary>
        [Priority(2), TestMethod()]
        public void AlterarFuncionarioTest()
        {
            this.MyTestInitialize();
            Funcionario f = Fachada_Accessor.ObterFachada().ConsultarFuncionario(this.funcionario.Cpf);
            f.Cpf = "0000";
            Fachada_Accessor.ObterFachada().AlterarFuncionario(f);
            Funcionario ex = Fachada_Accessor.ObterFachada().ConsultarFuncionario(f.Cpf);
            Assert.AreEqual(f.Cpf,ex.Cpf);
        }
    }
}
