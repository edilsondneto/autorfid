using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using Fachada.Interface;
using Fachada.BDcon;

namespace Fachada.Repositorio
{
    public class RepositorioFuncionario : Ifuncionario
    {

        private Conectar c;

        public RepositorioFuncionario()
        {
            this.c = new Conectar();
        }

        #region Ifuncionario Members

        public void InserirFuncionario(Funcionario f)
        {
            throw new NotImplementedException();
        }

        public void AlterarFuncionario(Funcionario f)
        {
            throw new NotImplementedException();
        }

        public Funcionario ConsultarFuncionario(Funcionario f)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ListarFuncionario()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
