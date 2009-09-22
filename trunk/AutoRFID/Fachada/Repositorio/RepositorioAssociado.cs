using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Basicas;
using Fachada.BDcon;
using MySql.Data.MySqlClient;
using System.Data;


namespace Fachada.Repositorio
{
    public class RepositorioAssociado  : IAssociado
    {
        private Conectar c;

        public RepositorioAssociado()
        {
            this.c = new Conectar();
        }

        # region Iassociado Members

        public void inserirAssociado(Associado objAssociado)
        {
            try
            {
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "insert into associado values(@cpf_cnpj, @nome_razaosocial, @tipo, @endereco, @numero,"
                                        + "@bairro, @cidade, @estado, @cep, @email, @fone, @fonecel)";

                this.c.Command().Parameters.Add("@cpf_cnpj", MySqlDbType.VarChar, 14).Value = objAssociado.Cpf_cnpj;
                this.c.Command().Parameters.Add("@nome_razaosocial", MySqlDbType.VarChar, 90).Value = objAssociado.Nome_razaosocial;
                this.c.Command().Parameters.Add("@tipo", MySqlDbType.VarChar, 2).Value = objAssociado.Tipo_pf_pj;
                this.c.Command().Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = objAssociado.Endereco;
                this.c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = objAssociado.Numero;
                this.c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = objAssociado.Bairro;
                this.c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = objAssociado.Cidade;
                this.c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = objAssociado.Estado;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = objAssociado.Cep;
                this.c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = objAssociado.Email;
                this.c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = objAssociado.Fone;
                this.c.Command().Parameters.Add("@fonecel", MySqlDbType.VarChar, 10).Value = objAssociado.Fonecel;
                this.c.Command().ExecuteNonQuery();
                this.c.Comitar();

            }
            catch (Exception e)
            {
                this.c.Rolback();
                throw new Exception("Erro no Repositorio");
            }
            finally
            {
                this.c.Connection().Close();
            }
        }

        public void alterarAssociado(Associado objAssociado)
        {
            try
            {
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "update associado set cpf_cnpj = @cpf_cnpj, nome_razaosocial = @nome_razaosocial,tipo_pf_pj = @tipopfpj"+
                 " numero = @numero, bairro = @bairro, cidade = @cidade, estado = @estado, " +
                 "cep = @cep , email = @email, fone = @fone, fonecel = @fonecel" +
                 "where idAssociado = @idAssociado";

                this.c.Command().Parameters.Add("@idAssociado", MySqlDbType.Int32).Value = objAssociado.Idassociado;
                this.c.Command().Parameters.Add("@cpf_cnpj", MySqlDbType.VarChar, 11).Value = objAssociado.Cpf_cnpj;
                this.c.Command().Parameters.Add("@nome_razaosocial", MySqlDbType.VarChar, 60).Value = objAssociado.Nome_razaosocial;
                this.c.Command().Parameters.Add("@tipopfpj", MySqlDbType.VarChar, 1).Value = objAssociado.Tipo_pf_pj;
                this.c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = objAssociado.Numero;
                this.c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = objAssociado.Bairro;
                this.c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = objAssociado.Cidade;
                this.c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = objAssociado.Estado;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = objAssociado.Cep;
                this.c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = objAssociado.Email;
                this.c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = objAssociado.Fone;
                this.c.Command().Parameters.Add("@fonecel", MySqlDbType.VarChar, 10).Value = objAssociado.Fonecel;
                this.c.Command().ExecuteNonQuery();
                this.c.Comitar();
            }
            catch (Exception e)
            {
                this.c.Rolback();
                throw new Exception("Erro no Repositorio");
            }
            finally
            {
                this.c.Connection().Close();
            }

            
        }

        public void excluirAssociado(int idAss)
        {
            try
            {
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "delete from associado where idassociado = @idassociado";
                this.c.Command().Parameters.Add("@idassociado", MySqlDbType.Int32).Value = idAss;
                this.c.Command().ExecuteNonQuery();
                this.c.Comitar();
            }
            catch (Exception e)
            {
                this.c.Rolback();
                throw new Exception("Erro no Repositorio");
            }
            finally
            {
                this.c.Connection().Close();
            }

            
        }

        public Associado consultarAssociado(Associado objAssociado)
        {
            return objAssociado;//temporário
        }

        #endregion
    }
}
