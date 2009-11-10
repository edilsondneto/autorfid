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
    class ControladorMovCredito: IMovCredito
    {
        private RepositorioMovCredito rmc;

        public ControladorMovCredito()
        {
            this.rmc = new RepositorioMovCredito();
        }

        

        public void InserirMovCredito(MovCredito mc)
        {
            this.rmc.InserirMovCredito(mc);
        }

        public void ExcluirMovCredito(int idMovCredito)
        {
            if (this.rmc.ConsultarMovCredito(idMovCredito).IdMovCredito.Equals(null))
            {
                throw new Exception("Movimento não encontrado!");
            }
            else
            {
                this.rmc.ExcluirMovCredito(idMovCredito);
            }
        }

        public MovCredito ConsultarMovCredito(int codigo)
        {
            MovCredito mc = this.rmc.ConsultarMovCredito(codigo);
            if (mc.Equals(null))
            {
                throw new Exception("Movomento não encontrado!");
            }
            return mc;
        }


        public List<MovCredito> ListarMovCredito()
        {
            return this.rmc.ListarMovCredito();
        }

        public DataSet ListarMovCreditoDataset(String sFiltro, List<CampoBD> lsCampos)
        {
            return this.rmc.ListarMovCreditoDataset( sFiltro,  lsCampos);
        }

    }
}
