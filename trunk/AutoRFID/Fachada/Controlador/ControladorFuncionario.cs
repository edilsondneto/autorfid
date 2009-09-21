using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;
using Fachada.Basicas;

namespace Fachada.Controlador
{
    public class ControladorFuncionario : Ifuncionario
    {
        private RepositorioFuncionario rf;

        public ControladorFuncionario()
        {
            this.rf = new RepositorioFuncionario();
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
        
        public void ExcluirFuncionario(int codigo)
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
