using Fachada.Fachada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fachada.Basicas;
using System.Collections.Generic;
using System.Data;

namespace Testes
{
    
    
    /// <summary>
    ///This is a test class for FachadaTest and is intended
    ///to contain all FachadaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FachadaAssociadoTest
    {
        private Associado associado;
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
            this.associado = new Associado();
            this.associado.Bairro = "teste";
            this.associado.Endereco = "tesete";
            this.associado.Estado = "te";
            this.associado.Fonecel = "8188042534";
            this.associado.Numero = 1;
            this.associado.Email = "asdfadsfsdf";
            this.associado.Cpf_cnpj = "10618846786";
            this.associado.Cidade = "xxxxx";
            this.associado.Cep = "adfas";
            this.associado.Fone = "8134683806";
            this.associado.Email = "maomzinha@hotmail.com";
            this.associado.Nome_razaosocial = "test";
            this.associado.Tipo_pf_pj = "0";
            this.associado.Idassociado = 11;
            

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
        public void ListarAssociadoTest()
        {
            DataSet actual = Fachada_Accessor.ObterFachada().ListarAssociado();
            Assert.IsNull(actual.Tables["lista"]);
        }

        /// <summary>
        ///A test for InserirAssociado
        ///</summary>
        [TestMethod()]
        public void InserirAssociadoTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().InserirAssociado(associado);
            Associado entAssociado = Fachada_Accessor.ObterFachada().ConsultarAssociado(associado);
            Assert.AreEqual(this.associado.Nome_razaosocial, associado.Nome_razaosocial);
        }

        /// <summary>
        ///A test for ConsultarAssociado
        ///</summary>
        [TestMethod()]
        public void ConsultarAssociadoTest1()
        {
            //this.MyTestInitialize();
            this.associado = new Associado();
            this.associado.Cpf_cnpj = "10618846786"; 
            Associado associado = Fachada_Accessor.ObterFachada().ConsultarAssociado(this.associado);
            Assert.AreEqual("10618846786", associado.Cpf_cnpj);
        }

        /// <summary>
        ///A test for ExcluirAssociado
        ///</summary>
        [TestMethod()]
        public void ExcluirAssociadoTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().ExcluirAssociado(this.associado.Idassociado);
            Associado associado = Fachada_Accessor.ObterFachada().ConsultarAssociado(this.associado);
            Assert.AreEqual(null, associado.Cpf_cnpj);

        }

        /// <summary>
        ///A test for AlterarAssociado
        ///</summary>
        [TestMethod()]
        public void AlterarAssociadoTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().InserirAssociado(this.associado);
            
            //objeto nulo na consulta carrega o último registro incluido
            this.associado = new Associado();
            Associado associado = Fachada_Accessor.ObterFachada().ConsultarAssociado(this.associado);

            associado.Nome_razaosocial = "Alterado";
            Fachada_Accessor.ObterFachada().AlterarAssociado(associado);
            
            Associado ex = Fachada_Accessor.ObterFachada().ConsultarAssociado(associado);
            
            Assert.AreEqual(associado.Nome_razaosocial, ex.Nome_razaosocial);
        }
    }
}
