using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;
using Fachada.Basicas;

namespace Fachada.Controlador
{
    public class ControladorEstabelecimento : IEstabelecimento
    {
        private RepositorioEstabelecimento re;

        public ControladorEstabelecimento()
        {
            this.re =new RepositorioEstabelecimento();
        }

        #region IEstabelecimento Members

        public void IncluirEstabelecimento(Estabelecimento objEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public void AlterarEstabelecimento(Estabelecimento objEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public Estabelecimento ConsultarEstabelecimento(Estabelecimento objEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public void ExcluirEstabelecimento(int idEstabelecimento)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
