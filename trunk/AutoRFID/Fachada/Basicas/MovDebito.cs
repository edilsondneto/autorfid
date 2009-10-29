using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Basicas
{
    
    public class MovDebito
    {
        #region Atributos
        private int idMovDebito;
        private String idCodigoEtiqueta;
        private Associado associado;
        private Estabelecimento estabelecimento;
        private DateTime dataEntrada;
        private String horaEntrada;
        private DateTime dataSaida;      
        private String horaSaida;      
        private Double valorDebitado;    
        #endregion

        #region Propiedades
        public int IdMovDebito
        {
            get { return idMovDebito;  }
            set { idMovDebito = value; }
        }
        public string IdCodigoEtiqueta
        {
            get { return idCodigoEtiqueta; }
            set { idCodigoEtiqueta = value; }
        }
        public Associado Associado
        {
            get { return associado; }
            set { associado = value; }
        }
        public Estabelecimento Estabelecimento
        {
            get { return estabelecimento; }
            set { estabelecimento = value; }
        }
        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }
        public String HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }
        public Double ValorDebitado
        {
            get { return valorDebitado; }
            set { valorDebitado = value; }
        }
        public DateTime DataSaida
        {
            get { return dataSaida; }
            set { dataSaida = value; }
        }
        public String HoraSaida
        {
            get { return horaSaida; }
            set { horaSaida = value; }
        }
        #endregion

    }
}
 