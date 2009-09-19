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


        #region IEstabelecimento Members

        public void IncluirEstabelecimento(Fachada.Basicas.Estabelecimento objEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public void AlterarEstabelecimento(Fachada.Basicas.Estabelecimento objEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public void ConsultarEstabelecimento(Fachada.Basicas.Estabelecimento objEstabelecimento)
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
