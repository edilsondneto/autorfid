using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Controlador;
using Fachada.Basicas;

namespace Fachada.Fachada
{
    public class Fachada
    {
        private static Fachada f;
        private Ifuncionario funcionario;
        private ITipoPag tipoPag;

        private Fachada()
        {
            this.funcionario = new ControladorFuncionario();
            this.tipoPag = new ControladorTipoPag();
        }

        public Fachada ObterFachada()
        {
            if (f == null)
            {
                f = new Fachada();
            }
            return f;
        }

        #region Funcionario Metodos
        public void InserirFuncionario(Funcionario f)
        {
            this.funcionario.InserirFuncionario(f);
        }

        public void AlterarFuncionario(Funcionario f)
        {
            this.funcionario.AlterarFuncionario(f);
        }

        public void ExcluirFuncionario(int codigo)
        {
            this.funcionario.ExcluirFuncionario(codigo);
        }

        public Funcionario ConsultarFuncionario(Funcionario f)
        {
            return this.funcionario.ConsultarFuncionario(f);
        }

        public List<Funcionario> ListarFuncionario()
        {
            return this.funcionario.ListarFuncionario();
        }
        #endregion

    }
}
