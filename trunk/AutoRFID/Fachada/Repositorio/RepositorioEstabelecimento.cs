using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using Fachada.Interface;
using Fachada.BDcon;
using MySql.Data.MySqlClient;

namespace Fachada.Repositorio
{
    public class RepositorioEstabelecimento : IEstabelecimento
    {
        private Conectar c;

        public RepositorioEstabelecimento()
        {
            this.c = new Conectar();
        }

        #region IEstabelecimento Members
        
        public void IncluirEstabelecimento(Estabelecimento objEstabelecimento)
        {
            try
            {
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "insert into estabelecimento (razaosocial, endereco, numero " +
                    "bairro, cidade, estado, cep, email, fone, qtdvagas, qtdvagasdisponiveis)" +
                    "values (@razaosocial, @endereco, @numero, @bairro, @cidade, @estado, @cep, @email, @fone"+
                        "@qtdvagas, @qtdvagasdisponiveis)";
                this.c.Command().Parameteres.Add("@razaosocial", MySqlDbType.VarChar, 11).Value = objEstabelecimento.Razaosocial;
                this.c.Command().Parameteres.Add("@endereco", MySqlDbType.VarChar,60).Value = objEstabelecimento.Endereco;
                this.c.Command().Parameteres.Add("@numero", MySqlDbType.Int32).Value = objEstabelecimento.Numero;
                this.c.Command().Parameteres.Add("@bairro", MySqlDbType.VarChar,40).Value = objEstabelecimento.Bairro;
                this.c.Command().Parameteres.Add("@cidade", MySqlDbType.VarChar,40).Value = objEstabelecimento.Cidade;
                this.c.Command().Parameteres.Add("@estado", MySqlDbType.VarChar,2).Value = objEstabelecimento.Estado;
                this.c.Command().Parameteres.Add("@cep", MySqlDbType.VarChar,8).Value = objEstabelecimento.Cep;
                this.c.Command().Parameteres.Add("@email", MySqlDbType.VarChar,40).Value = objEstabelecimento.Email;
                this.c.Command().Parameteres.Add("@fone", MySqlDbType.VarChar,10).Value = objEstabelecimento.Fone;
                this.c.Command().Parameteres.Add("@qtdvagas", MySqlDbType.Int32).Value = objEstabelecimento.Qtdvagas;
                this.c.Command().Parameteres.Add("@qtdvagasdisponiveis", MySqlDbType.Int32).Value = objEstabelecimento.Qtdvagasdisponiveis;
                this.c.Comitar();
            }
            catch (Exception e)
            {
                this.c.Rolback();
                throw new Exception("Erro no Repositório Estabelecimento");
            }
        }

        public void AlterarEstabelecimento(Estabelecimento objEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public Estabelecimento ConsultarEstabelecimento(Estabelecimento objEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public void ExcluirEstabelecimento(int idEstabelecimento)
        {
            throw new NotImplementedException();
        }

        public List<Estabelecimento> ListarEstabelecimento()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
