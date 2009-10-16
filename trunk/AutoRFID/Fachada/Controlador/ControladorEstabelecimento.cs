using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;
using Fachada.Basicas;
using System.Data;
using PCampoBD;

namespace Fachada.Controlador
{
    public class ControladorEstabelecimento : IEstabelecimento
    {
        private RepositorioEstabelecimento re;

        public ControladorEstabelecimento()
        {
            this.re = new RepositorioEstabelecimento();
        }

        #region IEstabelecimento Members

        public void IncluirEstabelecimento(Estabelecimento objEstabelecimento)
        {

            if (!Validacao.ValidarNulo(objEstabelecimento.Razaosocial))
            {
                throw new Exception("Razão Social é obrigatório!");
            }
            if (!Validacao.ValidaCNPJ(objEstabelecimento.Cnpj))
            {
                throw new Exception("CNPJ Inválido!");
            }
            if (!Validacao.ValidarNulo(objEstabelecimento.Endereco))
            {
                throw new Exception("Endereço é obrigatório!");
            }
            if (!Validacao.ValidarNulo(objEstabelecimento.Cidade))
            {
                throw new Exception("Cidade é obrigatório!");
            }
            if (!Validacao.ValidarNulo(objEstabelecimento.Estado))
            {
                throw new Exception("Estado é obrigatório!");
            }
            if (!Validacao.ValidarNulo(objEstabelecimento.Cep))
            {
                throw new Exception("Cep é obrigatório!");
            }
            if (!(objEstabelecimento.Email == ""))
            {
                if (!Validacao.validaEmail(objEstabelecimento.Email))
                {
                    throw new Exception("E-mail inválido");
                }
            }
            this.re.IncluirEstabelecimento(objEstabelecimento);
            
        }

        public void AlterarEstabelecimento(Estabelecimento objEstabelecimento)
        {
    
            this.re.AlterarEstabelecimento(objEstabelecimento);
            
        }

        public Estabelecimento ConsultarEstabelecimento(Estabelecimento objEst)
        {
            return this.re.ConsultarEstabelecimento(objEst);
        }

        public void ExcluirEstabelecimento(Estabelecimento objEst)
        {         
            this.re.ExcluirEstabelecimento(objEst);
        }

        public DataSet ListarEstabelecimento(String sFiltro, List<CampoBD> lsCampos)
        {
            return this.re.ListarEstabelecimento(sFiltro, lsCampos);        
        }
        #endregion
    }
}
