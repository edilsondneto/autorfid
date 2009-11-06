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
        Estabelecimento ConsultarEstabelecimento(int idEstab);
        Estabelecimento ConsultarEstabelecimento(String cnpj);
        //carregar o último registro
        Estabelecimento ConsultarEstabelecimento();
        void ExcluirEstabelecimento(int idEstab);
        DataSet ListarEstabelecimento();
        DataSet ListarEstabelecimento(String sFiltro, List<CampoBD> lsCampos);
    }
}
