using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fachada.Basicas
{
    public class EtiquetaAssociado
    {
        #region Atrbutos
        private string codigoEtiqueta;
        private Associado associado;
        private decimal saldo;
        private string situacao;
        private decimal valor;
        #endregion

        public EtiquetaAssociado()
        {

        }

        #region Properties
        public Associado Associado
        {
            get { return associado; }
            set { associado = value; }
        }

        public string CodigoEtiqueta
        {
            get { return codigoEtiqueta; }
            set { codigoEtiqueta = value; }
        }

        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        #endregion
    }
}
