using Fachada.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fachada.Basicas;
using System.Collections.Generic;
using System.Data;
using Fachada.Fachada;

namespace Testes
{
    
    
    /// <summary>
    ///This is a test class for RepositorioEstabelecimentoTest and is intended
    ///to contain all RepositorioEstabelecimentoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RepositorioEstabelecimentoTest
    {
        private Estabelecimento estabelecimento;
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
            this.estabelecimento = new Estabelecimento();
            this.estabelecimento.Bairro = "teste";
            this.estabelecimento.Endereco = "tesete";
            this.estabelecimento.Estado = "te";
            //this.estabelecimento.cn = "8188042534";
            this.estabelecimento.Numero = 1;
            this.estabelecimento.Email = "asdfadsfsdf";
            this.estabelecimento.Cidade = "xxxxx";
            this.estabelecimento.Cep = "adfas";
            this.estabelecimento.Fone = "8134683806";
            this.estabelecimento.Email = "maomzinha@hotmail.com";
            this.estabelecimento.IdEstabelecimento = 1;
            this.estabelecimento.Cnpj = "234232232";
            this.estabelecimento.IdEstabelecimento = 1;
            
            this.estabelecimento.Razaosocial = "nada";
    
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
        ///A test for ListarAssociado
        ///</summary>
        [TestMethod()]
        public void ListarEstabelecimento()
        {
            int expected = 1;
            //DataSet actual = Fachada_Accessor.ObterFachada().ListarEstabelecimento();
            //Assert.AreEqual(expected, actual.Tables["lista"].Rows.Count);
        }

        /// <summary>
        ///A test for InserirAssociado
        ///</summary>
        [TestMethod()]
        public void InserirEstabelecimentoTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().IncluirEstabelecimento(estabelecimento);
            Estabelecimento entEstabelecimento = Fachada_Accessor.ObterFachada().ConsultarEstabelecimento(estabelecimento);
            Assert.AreEqual(this.estabelecimento.Razaosocial, estabelecimento.Razaosocial);
        }

        /// <summary>
        ///A test for ConsultarAssociado
        ///</summary>
        [TestMethod()]
        public void ConsultarEstabelecimentoTest1()
        {
            this.MyTestInitialize();
            Estabelecimento estabelecimento = Fachada_Accessor.ObterFachada().ConsultarEstabelecimento(this.estabelecimento);
            Assert.AreEqual("234232232", estabelecimento.Cnpj);
        }

        /// <summary>
        ///A test for ExcluirAssociado
        ///</summary>
        [TestMethod()]
        public void ExcluirEstabelecimentoTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().ExcluirEstabelecimento(this.estabelecimento);
            Estabelecimento estabelecimento = Fachada_Accessor.ObterFachada().ConsultarEstabelecimento(this.estabelecimento);
            Assert.AreEqual(null, estabelecimento.Cnpj);

        }

        /// <summary>
        ///A test for AlterarAssociado
        ///</summary>
        [TestMethod()]
        public void AlterarAssociadoTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().IncluirEstabelecimento(this.estabelecimento);
            Estabelecimento estabelecimento = Fachada_Accessor.ObterFachada().ConsultarEstabelecimento(this.estabelecimento);
            estabelecimento.Cnpj = "0000";
            Fachada_Accessor.ObterFachada().AlterarEstabelecimento(estabelecimento);
            Estabelecimento ex = Fachada_Accessor.ObterFachada().ConsultarEstabelecimento(estabelecimento);
            Assert.AreEqual(estabelecimento.Cnpj, ex.Cnpj);
        }
    }
}
