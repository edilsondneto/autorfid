using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Interface
{
    interface IAssociado
    {
        void inserirAssociado(Associado objAssociado);

        void alterarAssociado(Associado objAssociado);

        void excluirAssociado(int idAss);

        Associado consultarAssociado(int idAssociado);

        Associado consultarAssociado(String cpfcnpj);

        //Carregar o último registro de associado
        Associado consultarAssociado();

        //DataSet ListarAssociado();
        DataSet ListarAssociado(String sFiltro, List<CampoBD> lsCampos);

        DataSet ListarAssociado();
    }
}
