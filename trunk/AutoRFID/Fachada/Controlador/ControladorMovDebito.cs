using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Controlador
{
    public class ControladorMovDebito:IMovDebito
    {
        private RepositorioMovDebito rmd;
        public ControladorMovDebito()
        {         
            this.rmd = new RepositorioMovDebito();
        }

        #region IMovDebito Members

        public void InserirMovDedito(MovDebito mov)
        {
            this.rmd.InserirMovDedito(mov);
        }

        public void ExcluirMovDedito(int idMov)
        {
            if (this.rmd.ConsultarMovDebito(idMov).IdMovDebito.Equals(null))
            {
                throw new Exception("Movimento não encontrado!");
            }
            else
            {
                this.rmd.ExcluirMovDedito(idMov);
            }
        }

        public MovDebito ConsultarMovDebito(int idDebito)
        {
            MovDebito md = this.rmd.ConsultarMovDebito(idDebito);
            if (md.Equals(null))
            {
                throw new Exception("Movimento não encontrado!");
            }
            return md;

        }

        public List<MovDebito> ListarMovDebito()
        {
            return this.rmd.ListarMovDebito();
        }

        public DataSet ListarMovDebitoDataset()
        {
            return this.rmd.ListarMovDebitoDataset();
        }

        #endregion
    }
}
