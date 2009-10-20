using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;
using Fachada.Basicas;
using System.Data;

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
            if (f.Nome == "" || f.Funcao == "-1" || f.Cpf == "")
            {
                throw new Exception("Campos obrigatorios em branco!");
            }
            else if (this.rf.ConsultarFuncionario(f.Cpf).Cpf != null)
            {
                throw new Exception("Funcionário Existente");
            }
            else if (!Validacao.ValidaCPF(f.Cpf))
            {
                throw new Exception("CPF Inválido!");
            }
            else if (!Validacao.validaEmail(f.Email))
            {
                throw new Exception("E-mail Inválido!");
            }
            else if (!Validacao.validaFone(f.Fone))
            {
                throw new Exception("Telefone Inválido!");
            }
            else if (!Validacao.validaFone(f.Fonecelular))
            {
                throw new Exception("Celular Inválido!");
            }
            else
            {
                this.rf.InserirFuncionario(f);
            }
        }

        public void AlterarFuncionario(Funcionario f)
        {
            if (f.Nome == "" || f.Funcao == "-1" || f.Cpf == "")
            {
                throw new Exception("Campos obrigatorios em branco!");
            }
            else if (this.rf.ConsultarFuncionario(f.Idfuncionario).Idfuncionario == 0)
            {
                throw new Exception("Funcionário Inexistente");
            }
            else if (!Validacao.ValidaCPF(f.Cpf))
            {
                throw new Exception("CPF Inválido!");
            }
            else if (!Validacao.validaEmail(f.Email))
            {
                throw new Exception("E-mail Inválido!");
            }
            else if (!Validacao.validaFone(f.Fone))
            {
                throw new Exception("Telefone Inválido!");
            }
            else if (!Validacao.validaFone(f.Fonecelular))
            {
                throw new Exception("Celular Inválido!");
            }
            else
            {
                this.rf.AlterarFuncionario(f);
            }
        }

        public void ExcluirFuncionario(String cpf)
        {
            if (this.rf.ConsultarFuncionario(cpf).Cpf == null)
            {
                throw new Exception("Funcionário Inexistente");
            }
            else
            {
                this.rf.ExcluirFuncionario(cpf);
            }
        }

        public void ExcluirFuncionario(int idfuncionario)
        {
            if (idfuncionario != 0 && this.rf.ConsultarFuncionario(idfuncionario).Cpf == null)
            {
                throw new Exception("Funcionário Inexistente");
            }
            else
            {
                this.rf.ExcluirFuncionario(idfuncionario);
            }
        }

        public Funcionario ConsultarFuncionario(int codigo)
        {
            Funcionario f = this.rf.ConsultarFuncionario(codigo);
            if (f.Cpf == null)
            {
                throw new Exception("Funcionário Inexistente");
            }
            return f;
        }

        public Funcionario ConsultarFuncionario(String cpf)
        {
            Funcionario f = this.rf.ConsultarFuncionario(cpf);
            if (f.Cpf == null)
            {
                throw new Exception("Funcionário Inexistente");
            }
            return f;
        }

        public DataSet ListarFuncionario()
        {
            return this.rf.ListarFuncionario();
        }

        public DataSet ListarFuncionario(string sFiltro, List<CampoBD> lsCampos)
        {
            return rf.ListarFuncionario(sFiltro, lsCampos);
        }
        #endregion
    }
}
