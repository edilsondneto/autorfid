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
            if (!(objEstabelecimento.Email == ""))
            {
                if (!Validacao.validaEmail(objEstabelecimento.Email))
                {
                    throw new Exception("E-mail inválido");
                }
            }

            if (this.re.ConsultarEstabelecimento(objEstabelecimento.Cnpj).Cnpj != null)
            {
                throw new Exception("Estabelecimento já cadastrado!");
            }
            
            this.re.IncluirEstabelecimento(objEstabelecimento);
            
        }

        public void AlterarEstabelecimento(Estabelecimento objEstabelecimento)
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

            if (this.re.ConsultarEstabelecimento(objEstabelecimento.Cnpj).IdEstabelecimento == null)
            {
                throw new Exception("Estabelecimento não cadastrado!");
            }
    
            this.re.AlterarEstabelecimento(objEstabelecimento);
            
        }

        public Estabelecimento ConsultarEstabelecimento(int idEstab)
        {
            return this.re.ConsultarEstabelecimento(idEstab);
        }

        public Estabelecimento ConsultarEstabelecimento(String cnpj)
        {
            return this.re.ConsultarEstabelecimento(cnpj);
        }

        public Estabelecimento ConsultarEstabelecimento()
        {
            return this.re.ConsultarEstabelecimento();
        }

        public void ExcluirEstabelecimento(int idEstab)
        {
            if (idEstab == 0) 
            {
                throw new Exception("Estabelecimento não existe");
            }
            else if (this.re.ConsultarEstabelecimento(idEstab).IdEstabelecimento != 0)
            {
                this.re.ExcluirEstabelecimento(idEstab);
            }
        }

        public DataSet ListarEstabelecimento()
        {
            return this.re.ListarEstabelecimento();        
        }

        public DataSet ListarEstabelecimento(String sFiltro, List<CampoBD> lsCampos)
        {
            return this.re.ListarEstabelecimento(sFiltro,lsCampos);
        }
        #endregion
    }
}
