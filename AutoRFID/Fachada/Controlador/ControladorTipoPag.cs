using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;

namespace Fachada.Controlador
{
    class ControladorTipoPag : ITipoPag
    {
        private RepositorioTipoPag rtp;
        public ControladorTipoPag()
        {
            rtp = new RepositorioTipoPag();
        }
    }
}
