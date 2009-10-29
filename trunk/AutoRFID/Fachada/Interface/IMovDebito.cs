using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Interface
{
    public interface IMovDebito
    {
        void InserirMovDedito(MovDebito mov);
        void ExcluirMovDedito(int idMov);
        MovDebito ConsultarMovDebito(int idDebito);
        List<MovDebito> ListarMovDebito();
        DataSet ListarMovDebitoDataset();
    }
}
