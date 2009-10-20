using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Controlador;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Fachada
{
    public class Fachada
    {
        private static Fachada f;
        private Ifuncionario funcionario;
        private IAssociado IntAssociado;
        private IEstabelecimento IntEstabelecimento;
        private IMovCredito IntMovCredito;
        private IEtiquetaAssociado ietiquetaAssociado;

        private Fachada()
        {
            this.funcionario = new ControladorFuncionario();
            this.IntAssociado = new ControladorAssociado();
            this.IntEstabelecimento = new ControladorEstabelecimento();
            this.IntMovCredito = new ControladorMovCredito();
            this.ietiquetaAssociado = new ControladorEtiquetaAssociado();
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

        public void ExcluirFuncionario(int idfuncionario)
        {
            this.funcionario.ExcluirFuncionario(idfuncionario);
        }

        public Funcionario ConsultarFuncionario(int codigo)
        {
            return this.funcionario.ConsultarFuncionario(codigo);
        }

        public Funcionario ConsultarFuncionario(String cpf)
        {
            return this.funcionario.ConsultarFuncionario(cpf);

        }

        public DataSet ListarFuncionario()
        {
            return this.funcionario.ListarFuncionario();
        }

        public DataSet ListarFuncionario(string sFiltro, List<CampoBD> lsCampos)
        {
            return this.funcionario.ListarFuncionario(sFiltro, lsCampos);
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

        public Associado ConsultarAssociado(int idAsso)
        {
            return this.IntAssociado.consultarAssociado(idAsso);
        }

        public Associado ConsultarAssociado(String cpfcnpj)
        {
            return this.IntAssociado.consultarAssociado(cpfcnpj);
        }

        public Associado ConsultarAssociado()
        {
            return this.IntAssociado.consultarAssociado();
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
        public void ExcluirEstabelecimento(int idEstab)
        {
            this.IntEstabelecimento.ExcluirEstabelecimento(idEstab);
        }

        public Estabelecimento ConsultarEstabelecimento(int idEstab)
        {
            return this.IntEstabelecimento.ConsultarEstabelecimento(idEstab);
        }

        public Estabelecimento ConsultarEstabelecimento(String cnpj)
        {
            return this.IntEstabelecimento.ConsultarEstabelecimento(cnpj);
        }

        public Estabelecimento ConsultarEstabelecimento()
        {
            return this.IntEstabelecimento.ConsultarEstabelecimento();
        }

        public DataSet ListarEstabelecimento()
        {
            return this.IntEstabelecimento.ListarEstabelecimento();
        }
        #endregion

        #region MovCreditos Metodos
        public void InserirMovCredito(MovCredito mc)
        {
            this.IntMovCredito.InserirMovCredito(mc);
        }


        public void ExcluirMovCredito(int idmov)
        {
            this.IntMovCredito.ExcluirMovCredito(idmov);
        }

        public MovCredito ConsultarMovCredito(int codigo)
        {
            return this.IntMovCredito.ConsultarMovCredito(codigo);
        }



        public List<MovCredito> ListarMovCredito()
        {
            return this.IntMovCredito.ListarMovCredito();
        }

        public DataSet ListarMovCreditoDataset()
        {
            return this.IntMovCredito.ListarMovCreditoDataset();
        }


        #endregion

    
        #region Etiqueta Associado

        public void IncluirEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado)
        {
            ietiquetaAssociado.InserirEtiquetaAssociado(etiquetaAssociado);
        }

        public void ExcluirEtiquetaAssociado(string codigo)
        {
            ietiquetaAssociado.ExcluirEtiquetaAssociado(codigo);
        }

        public void AlterarEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado)
        {
            ietiquetaAssociado.AlterarEtiquetaAssociado(etiquetaAssociado);
        }

        public EtiquetaAssociado ConsultarEtiquetaAssociado(String codigo)
        {
            return ietiquetaAssociado.ConsultarEtiquetaAssociado(codigo);
        }

        public DataSet ListarEtiquetaAssociado()
        {
            return ietiquetaAssociado.ListarEtiquetaAssociado();
        }

        public DataSet ListarEtiquetaAssociado(int idAssociado)
        {
            return ietiquetaAssociado.ListarEtiquetaAssociado(idAssociado);
        }

        public DataSet ListarEtiquetaAssociado(String situacao)
        {
            return ietiquetaAssociado.ListarEtiquetaAssociado(situacao);
        }

        public DataSet ListarEtiquetaAssociado(string sFiltro, List<CampoBD> lsCampos)
        {
            return ietiquetaAssociado.ListarEtiquetaAssociado(sFiltro, lsCampos);
        }

        #endregion 
    }
    }
