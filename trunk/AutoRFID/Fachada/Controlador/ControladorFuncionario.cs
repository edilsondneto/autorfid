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
            if (f.Nome.Equals(null) && f.Funcao.Equals(null) && f.Numero.Equals(null) &&
            f.Idestabelecimento.Equals(null) && f.Fone.Equals(null) && f.Email.Equals(null) && f.Estado.Equals(null) && f.Cpf.Equals(null) && f.Cidade.Equals(null) && f.Cep.Equals(null))
            {
                throw new Exception("Campos nulos");
            }
            else if (this.rf.ConsultarFuncionario(f.Cpf).Cpf != null)
            {

                throw new Exception("Funcionário Existente");

            }
            else
            {
                this.rf.InserirFuncionario(f);
            }
        }

        public void AlterarFuncionario(Funcionario f)
        {
            if (f.Nome.Equals(null) && f.Funcao.Equals(null) && f.Numero.Equals(null) &&
               f.Idestabelecimento.Equals(null) && f.Fone.Equals(null) && f.Email.Equals(null)
                && f.Estado.Equals(null) && f.Cpf.Equals(null) && f.Cidade.Equals(null) && f.Cep.Equals(null))
            {
                throw new Exception("Campos nulos");
            }
            else if (this.rf.ConsultarFuncionario(f.Idfuncionario).Idfuncionario.Equals(null))
            {
                throw new Exception("Funcionário Inexistente");
            }
            else
            {
                this.rf.AlterarFuncionario(f);
            }
        }

        public void ExcluirFuncionario(String cpf)
        {
            if (this.rf.ConsultarFuncionario(cpf).Cpf.Equals(null))
            {
                throw new Exception("Funcionário Inexistente");
            }
            else
            {
                this.rf.ExcluirFuncionario(cpf);
            }
        }

        public Funcionario ConsultarFuncionario(int? codigo)
        {
            Funcionario f = this.rf.ConsultarFuncionario(codigo);
            if (f.Equals(null))
            {
                throw new Exception("Funcionário Inexistente");
            }
            return f;
        }

        public Funcionario ConsultarFuncionario(String cpf)
        {
            Funcionario f = this.rf.ConsultarFuncionario(cpf);
            if (f.Equals(null))
            {
                throw new Exception("Funcionário Inexistente");
            }
            return f;
        }

        public List<Funcionario> ListarFuncionario()
        {
            return this.rf.ListarFuncionario();
        }

        #endregion

    }
}
