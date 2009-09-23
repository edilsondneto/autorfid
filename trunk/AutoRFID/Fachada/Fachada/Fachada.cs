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
        private IAssociado IntAssociado;

        private Fachada()
        {
           // this.funcionario = new ControladorFuncionario();
           // this.tipoPag = new ControladorTipoPag();
            this.IntAssociado = new ControladorAssociado();
        }

        public static Fachada ObterFachada()
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

        public Funcionario ConsultarFuncionario(int codigo)
        {
            return this.funcionario.ConsultarFuncionario(codigo);
        }

        public Funcionario ConsultarFuncionario(String cpf)
        {
            return this.funcionario.ConsultarFuncionario(cpf);

        }

        public List<Funcionario> ListarFuncionario()
        {
            return this.funcionario.ListarFuncionario();
        }
        #endregion

        #region Associado Metodos

        public void InserirAssociado(Associado f)
        {
            this.IntAssociado.inserirAssociado(f);
        }

        public void AlterarAssociado(Associado f)
        {
            this.IntAssociado.alterarAssociado(f);
        }

        public void ExcluirAssociado(int codigo)
        {
            this.IntAssociado.excluirAssociado(codigo);
        }

        public Associado ConsultarAssociado(Associado f)
        {
            return this.IntAssociado.consultarAssociado(f);
        }

        #endregion


<<<<<<< .mine
    }
=======

      
    }
>>>>>>> .r164
}
