using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;

namespace Fachada.Interface
{
    interface IAssociado
    {
        void inserirAssociado(Associado objAssociado);

        void alterarAssociado(Associado objAssociado);

        void excluirAssociado(int idAss);

        Associado consultarAssociado(Associado objAssociado);

    }
}
