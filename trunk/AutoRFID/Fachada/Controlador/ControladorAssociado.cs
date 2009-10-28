using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Repositorio;
using Fachada.Interface;
using Fachada.Basicas;
using Fachada.Controlador;
using System.Data;

namespace Fachada.Controlador
{
    public class ControladorAssociado : IAssociado
    {
        private RepositorioAssociado objRepAss;
       
        public ControladorAssociado()
        {
            this.objRepAss = new RepositorioAssociado();
        }

        #region Iassociado Members
        public DataSet ListarAssociado(string sFiltro, List<CampoBD> lsCampos)
        {
            return objRepAss.ListarAssociado(sFiltro, lsCampos);
        }

        public DataSet ListarAssociado()
        {
            return objRepAss.ListarAssociado();
        }
        

        public void inserirAssociado(Associado objAssociado)
        {
            if (!Validacao.ValidarNulo(objAssociado.Nome_razaosocial))
            {
                throw new Exception("Nome ou Razão Social, obrigatório!");
            }

            if (objAssociado.Tipo_pf_pj.Equals("0"))
            {
                if (!Validacao.ValidaCPF(objAssociado.Cpf_cnpj))
                {
                    throw new Exception("CPF inválido!");
                }
            }

            if (objAssociado.Tipo_pf_pj.Equals("1"))
            {
                if (!Validacao.ValidaCNPJ(objAssociado.Cpf_cnpj))
                {
                    throw new Exception("CNPJ inválido!");
                }
            }

            if (!Validacao.validaFone(objAssociado.Fone))
            {
                throw new Exception("Número do telefone inválido");
            }

            if (!Validacao.validaFone(objAssociado.Fonecel))
            {
                throw new Exception("Número do celular inválido");
            }

            if (!Validacao.validaEmail(objAssociado.Email))
            {
                throw new Exception("E-mail inválido");
            }

            if (this.objRepAss.consultarAssociado(objAssociado.Cpf_cnpj).Cpf_cnpj != null)
            {
                throw new Exception("Associado já cadastrado!");
            }

            this.objRepAss.inserirAssociado(objAssociado);
        }

        public void alterarAssociado(Associado objAssociado)
        {
            if (!Validacao.ValidarNulo(objAssociado.Nome_razaosocial))
            {
                throw new Exception("Nome ou Razão Social, obrigatório!");
            }

            if (objAssociado.Tipo_pf_pj.Equals("0"))
            {
                if (!Validacao.ValidaCPF(objAssociado.Cpf_cnpj))
                {
                    throw new Exception("CPF inválido!");
                }
            }

            if (objAssociado.Tipo_pf_pj.Equals("1"))
            {
                if (!Validacao.ValidaCNPJ(objAssociado.Cpf_cnpj))
                {
                    throw new Exception("CNPJ inválido!");
                }
            }

            if (!Validacao.validaFone(objAssociado.Fone))
            {
                throw new Exception("Número do telefone inválido");
            }

            if (!Validacao.validaFone(objAssociado.Fonecel))
            {
                throw new Exception("Número do celular inválido");
            }

            if (!Validacao.validaEmail(objAssociado.Email))
            {
                throw new Exception("E-mail inválido");
            }

            if (this.objRepAss.consultarAssociado(objAssociado.Idassociado).Idassociado == 0)
            {
                throw new Exception("Associado não cadastrado!");
            }

            this.objRepAss.alterarAssociado(objAssociado);
        }

        public void excluirAssociado(int idAss)
        {
            if (idAss == 0)
            {
                throw new Exception("Código do usuário não existe");
            }
            else if (this.objRepAss.consultarAssociado(idAss).Idassociado != 0)
            {
                this.objRepAss.excluirAssociado(idAss);
            }
        }

        public Associado consultarAssociado(int idAssociado)
        {
         
                return this.objRepAss.consultarAssociado(idAssociado);
        }

        public Associado consultarAssociado(String cpfcnpj)
        {

            return this.objRepAss.consultarAssociado(cpfcnpj);
        }

        public Associado consultarAssociado()
        {

            return this.objRepAss.consultarAssociado();
        }

        #endregion
    }
}
