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

        Associado consultarAssociado(Associado objAssociado);

        DataSet ListarAssociado();

    }
}
