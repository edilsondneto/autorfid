using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Controlador;
using Fachada.Basicas;
using System.Data;
using PCampoBD;

namespace Fachada.Fachada
{
    public class Fachada
    {
        private static Fachada f;
        private Ifuncionario funcionario;
        private IAssociado IntAssociado;
        private IEstabelecimento IntEstabelecimento;

        private Fachada()
        {
            this.funcionario = new ControladorFuncionario();
            this.IntAssociado = new ControladorAssociado();
            this.IntEstabelecimento = new ControladorEstabelecimento();
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

        public void ExcluirFuncionario(String cpf)
        {
            this.funcionario.ExcluirFuncionario(cpf);
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

        public DataSet ListarFuncionarioDataset(String sFiltro, List<CampoBD> lsCampos)
        {
            return this.funcionario.ListarFuncionarioDataset(sFiltro, lsCampos);
        }
        #endregion

        #region Associado Metodos

        public void InserirAssociado(Associado Asso)
        {
            this.IntAssociado.inserirAssociado(Asso);
        }

        public void AlterarAssociado(Associado Asso)
        {
            this.IntAssociado.alterarAssociado(Asso);
        }

        public void ExcluirAssociado(int codigo)
        {
            this.IntAssociado.excluirAssociado(codigo);
        }

        public Associado ConsultarAssociado(Associado Asso)
        {
            return this.IntAssociado.consultarAssociado(Asso);
        }

        public DataSet ListarAssociado()
        {
            return this.IntAssociado.ListarAssociado();
        }

        #endregion

        #region Estabelecimento Metodos
        public void IncluirEstabelecimento(Estabelecimento f)
        {
            this.IntEstabelecimento.IncluirEstabelecimento(f);
        }
        public void AlterarEstabelecimento(Estabelecimento f)
        {
            this.IntEstabelecimento.AlterarEstabelecimento(f);
        }
        public void ExcluirEstabelecimento(Estabelecimento objEst)
        {
            this.IntEstabelecimento.ExcluirEstabelecimento(objEst);
        }
        public Estabelecimento ConsultarEstabelecimento(Estabelecimento objEst)
        {
            return this.IntEstabelecimento.ConsultarEstabelecimento(objEst);
        }
        public List<Estabelecimento> ListarEstabelecimento()
        {
            return this.IntEstabelecimento.ListarEstabelecimento();
        }
        #endregion


    }
    }
