using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Interface
{
    interface IMovCredito
    {
        void InserirMovCredito(MovCredito mov);
        void ExcluirMovCredito(int idMov);
        MovCredito ConsultarMovCredito(int idCredito);
        List<MovCredito> ListarMovCredito();
        DataSet ListarMovCreditoDataset();
    }
}
