using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fachada.Basicas
{
    public class MovCredito
    {
        #region Atributos
        private int idMovCredito;
        private Funcionario funcionario;
        private Estabelecimento estabelecimento;
        private Associado associado;
        private EtiquetaAssociado etiquetaassociado;
        private DateTime dtCompra;
        private DateTime dtCredito;
        private float vlCredito;
        private String formaPag;
        #endregion

        public MovCredito()
        {
        }

        #region Properties
        public int IdMovCredito
        {
            get { return idMovCredito; }
            set { idMovCredito = value; }
        }

        public Funcionario Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }

        public Estabelecimento Estabelecimento
        {
            get { return estabelecimento; }
            set { estabelecimento = value; }
        }

        public Associado Associado
        {
            get { return associado; }
            set { associado = value; }
        }

        public EtiquetaAssociado Etiquetaassociado
        {
            get { return etiquetaassociado; }
            set { etiquetaassociado = value; }
        }

        public DateTime DtCompra
        {
            get { return dtCompra; }
            set { dtCompra = value; }
        }

        public DateTime DtCredito
        {
            get { return dtCredito; }
            set { dtCredito = value; }
        }

        public float VlCredito
        {
            get { return vlCredito; }
            set { vlCredito = value; }
        }

        public String FormaPag
        {
            get { return formaPag; }
            set { formaPag = value; }
        }
        #endregion
    }
}
