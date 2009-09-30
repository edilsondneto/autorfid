using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Interface
{
    public interface IEstabelecimento
    {
        void IncluirEstabelecimento(Estabelecimento objEstabelecimento);
        void AlterarEstabelecimento(Estabelecimento objEstabelecimento);
        Estabelecimento ConsultarEstabelecimento(Estabelecimento objEst);
        void ExcluirEstabelecimento(Estabelecimento objEst);     
        DataSet ListarEstabelecimento();
    }
}
