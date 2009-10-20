using Fachada.Fachada;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fachada.Basicas;
using System.Data;
using System.Collections.Generic;

namespace Testes
{
    
    
    /// <summary>
    ///This is a test class for FachadaEtiquetaAssociadoTest and is intended
    ///to contain all FachadaEtiquetaAssociadoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FachadaEtiquetaAssociadoTest
    {

        private EtiquetaAssociado ea;
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
            this.ea = new EtiquetaAssociado();
            ea.Associado = new Associado() {Idassociado = 63};
            ea.CodigoEtiqueta = "123456789";
            ea.Saldo = 10.00m;
            ea.Situacao = "a";
            ea.Valor = 15.00m;
        }
        
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for ListarEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void ListarEtiquetaAssociadoTest3()
        {
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListarEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void ListarEtiquetaAssociadoTest2()
        {
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListarEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void ListarEtiquetaAssociadoTest1()
        {
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ListarEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void ListarEtiquetaAssociadoTest()
        {
            DataSet ds = Fachada_Accessor.ObterFachada().ListarAssociado();
            Assert.AreEqual(0, ds.Tables[0].Rows.Count);
        }

        /// <summary>
        ///A test for IncluirEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void IncluirEtiquetaAssociadoTest()
        {
            this.MyTestInitialize();
            Fachada_Accessor.ObterFachada().IncluirEtiquetaAssociado(this.ea);
            EtiquetaAssociado atual = Fachada_Accessor.ObterFachada().ConsultarEtiquetaAssociado(this.ea.CodigoEtiqueta);
            Assert.AreEqual(this.ea.CodigoEtiqueta, atual.CodigoEtiqueta);
        }

        /// <summary>
        ///A test for ExcluirEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void ExcluirEtiquetaAssociadoTest()
        {
            this.MyTestInitialize();
            try
            {
                Fachada_Accessor.ObterFachada().ExcluirEtiquetaAssociado(this.ea.CodigoEtiqueta);
                this.ea = Fachada_Accessor.ObterFachada().ConsultarEtiquetaAssociado(this.ea.CodigoEtiqueta);
            }
            catch { Assert.IsTrue(true); }
        }

        /// <summary>
        ///A test for ConsultarEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void ConsultarEtiquetaAssociadoTest()
        {
            this.MyTestInitialize();
            EtiquetaAssociado atual = Fachada_Accessor.ObterFachada().ConsultarEtiquetaAssociado(this.ea.CodigoEtiqueta);
            Assert.IsNotNull(atual.CodigoEtiqueta);
        }

        /// <summary>
        ///A test for AlterarEtiquetaAssociado
        ///</summary>
        [TestMethod()]
        public void AlterarEtiquetaAssociadoTest()
        {
            this.MyTestInitialize();
            this.ea = Fachada_Accessor.ObterFachada().ConsultarEtiquetaAssociado(this.ea.CodigoEtiqueta);
            this.ea.Situacao = "i";
            Fachada_Accessor.ObterFachada().AlterarEtiquetaAssociado(this.ea);
            EtiquetaAssociado atual = this.ea = Fachada_Accessor.ObterFachada().ConsultarEtiquetaAssociado(this.ea.CodigoEtiqueta);
            Assert.AreEqual(this.ea.Situacao, atual.Situacao);
            
        }
    }
}
