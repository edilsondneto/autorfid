using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Repositorio;
using Fachada.Basicas;

namespace Fachada.Controlador
{
    public class ControladorEstabelecimento : IEstabelecimento
    {
        private RepositorioEstabelecimento re;

        public ControladorEstabelecimento()
        {
            this.re =new RepositorioEstabelecimento();
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
            /*Estabelecimento objEst = new Estabelecimento();
            objEst.IdEstabelecimento = idEst;
            Estabelecimento objExiste;
            objExiste = this.re.ConsultarEstabelecimento(objEst);
            if (objExiste.Equals(null))
            {
                throw new Exception("Estabelecimento Inexistente");
            }
            else 
            {
                this.re.ExcluirEstabelecimento(idEst);
            }*/
            this.re.ExcluirEstabelecimento(objEst);
        }

        //#endregion

        //#region IEstabelecimento Members


        public List<Estabelecimento> ListarEstabelecimento()
        {
            return this.re.ListarEstabelecimento();
        }

        #endregion
    }
}
