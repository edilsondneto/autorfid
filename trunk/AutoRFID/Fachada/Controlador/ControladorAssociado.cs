using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Repositorio;
using Fachada.Interface;
using Fachada.Basicas;

namespace Fachada.Controlador
{
    public class ControladorAssociado : IAssociado
    {
        private RepositorioAssociado objRepAss;


        public ControladorAssociado()
        {
            this.objRepAss = new RepositorioAssociado();
        }



        #region Iassociado Members

        public void inserirAssociado(Associado objAssociado)
        {
            if (!objAssociado.Nome_razaosocial.Equals(null))
            {
                this.objRepAss.inserirAssociado(objAssociado);
            }
            else
                throw new System.Exception("Campo em branco não permitido");

        }

        public void alterarAssociado(Associado objAssociado)
        {
            throw new NotImplementedException();
        }

        public void excluirAssociado(int idAss)
        {
            throw new NotImplementedException();
        }

        public Associado consultarAssociado(Associado objAssociado)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
