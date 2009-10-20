using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Interface
{
    interface IEtiquetaAssociado
    {
        void InserirEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado);
        void AlterarEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado);
        void ExcluirEtiquetaAssociado(String codigo);
        EtiquetaAssociado ConsultarEtiquetaAssociado(String codigoetiqueta);
        DataSet ListarEtiquetaAssociado();
        DataSet ListarEtiquetaAssociado(int idAssociado);
        DataSet ListarEtiquetaAssociado(String situacao);
        DataSet ListarEtiquetaAssociado(String sFiltro, List<CampoBD> lsCampos);
    }
}
