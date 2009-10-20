using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Basicas;
using Fachada.BDcon;
using Fachada.Controlador;
using MySql.Data.MySqlClient;
using System.Data;


namespace Fachada.Repositorio
{
    public class RepositorioAssociado  : IAssociado
    {
        private Conectar c;

        public RepositorioAssociado()
        {
            //this.c = new Conectar();
        }

        # region Iassociado Members

        public void inserirAssociado(Associado objAssociado)
        {
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "insert into associado (cpf_cnpj,nome_razaosocial,tipo_fisica_juridica,endereco,"+
                "numero,bairro,cidade,estado,cep,email,fone,fonecelular) values(@cpf_cnpj,@nome_razaosocial,@tipo,@endereco,@numero,"+
                "@bairro, @cidade, @estado, @cep, @email, @fone, @fonecel)";

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
                this.c = new Conectar();
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "update associado set cpf_cnpj = @cpf_cnpj, nome_razaosocial = @nome_razaosocial,tipo_fisica_juridica = @tipo,"+
                "endereco = @endereco, numero = @numero, bairro = @bairro, cidade = @cidade, estado = @estado, " +
                "cep = @cep , email = @email, fone = @fone, fonecelular = @fonecel " +
                "where idAssociado = @idAssociado";

                this.c.Command().Parameters.Add("@idAssociado", MySqlDbType.Int32).Value = objAssociado.Idassociado;
                this.c.Command().Parameters.Add("@cpf_cnpj", MySqlDbType.VarChar, 14).Value = objAssociado.Cpf_cnpj;
                this.c.Command().Parameters.Add("@nome_razaosocial", MySqlDbType.VarChar, 60).Value = objAssociado.Nome_razaosocial;
                this.c.Command().Parameters.Add("@tipo", MySqlDbType.VarChar, 1).Value = objAssociado.Tipo_pf_pj;
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

        public void excluirAssociado(int idAss)
        {
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "delete from associado where idAssociado = @idassociado";
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

        public Associado consultarAssociado(int idAssociadoPass)
        {
            Associado objAssoc = new Associado();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();

                //verificar se o campo não é nulo para efetuar consulta
                if (Validacao.ValidarNulo(idAssociadoPass))
                {
                    this.c.Command().CommandText = "select * from associado where idAssociado = @idAssociado";
                    this.c.Command().Parameters.Add("@idAssociado", MySqlDbType.Int32).Value = idAssociadoPass;
                }
                else //se todos os campos for nulo carregar o último registro
                {
                    this.c.Command().CommandText = "select * from associado where idAssociado = (SELECT MAX(idAssociado) FROM associado)";
                }

                da.SelectCommand = this.c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    objAssoc.Idassociado = (int)item[0];
                    objAssoc.Cpf_cnpj = (String)item[1];
                    objAssoc.Nome_razaosocial = (String)item[2];
                    objAssoc.Tipo_pf_pj = (String)item[3];
                    objAssoc.Endereco = (String)item[4];
                    objAssoc.Numero = (int)item[5];
                    objAssoc.Bairro = (String)item[6];
                    objAssoc.Cidade = (String)item[7];
                    objAssoc.Estado = (String)item[8];
                    objAssoc.Cep    = (String)item[9];
                    objAssoc.Email  = (String)item[10];
                    objAssoc.Fone   = (String)item[11];
                    objAssoc.Fonecel= (String)item[12];

                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio");
            }
            finally
            {
                this.c.Connection().Close();
            }
            return objAssoc;
        }

        public Associado consultarAssociado(String cpfcnpjPass)
        {
            Associado objAssoc = new Associado();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();

                //verificar se o campo não é nulo para efetuar consulta
                if (Validacao.ValidarNulo(cpfcnpjPass))
                {
                    this.c.Command().CommandText = "select * from associado where cpf_cnpj = @cpf_cnpj";
                    this.c.Command().Parameters.Add("@cpf_cnpj", MySqlDbType.VarChar,11).Value = cpfcnpjPass;
                }

                da.SelectCommand = this.c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    objAssoc.Idassociado = (int)item[0];
                    objAssoc.Cpf_cnpj = (String)item[1];
                    objAssoc.Nome_razaosocial = (String)item[2];
                    objAssoc.Tipo_pf_pj = (String)item[3];
                    objAssoc.Endereco = (String)item[4];
                    objAssoc.Numero = (int)item[5];
                    objAssoc.Bairro = (String)item[6];
                    objAssoc.Cidade = (String)item[7];
                    objAssoc.Estado = (String)item[8];
                    objAssoc.Cep = (String)item[9];
                    objAssoc.Email = (String)item[10];
                    objAssoc.Fone = (String)item[11];
                    objAssoc.Fonecel = (String)item[12];

                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio");
            }
            finally
            {
                this.c.Connection().Close();
            }
            return objAssoc;
        }

        //Carregar o último registro de associado
        public Associado consultarAssociado()
        {
            Associado objAssoc = new Associado();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();

                //carregar o último registro
                this.c.Command().CommandText = "select * from associado where idAssociado = (SELECT MAX(idAssociado) FROM associado)";
  
                da.SelectCommand = this.c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    objAssoc.Idassociado = (int)item[0];
                    objAssoc.Cpf_cnpj = (String)item[1];
                    objAssoc.Nome_razaosocial = (String)item[2];
                    objAssoc.Tipo_pf_pj = (String)item[3];
                    objAssoc.Endereco = (String)item[4];
                    objAssoc.Numero = (int)item[5];
                    objAssoc.Bairro = (String)item[6];
                    objAssoc.Cidade = (String)item[7];
                    objAssoc.Estado = (String)item[8];
                    objAssoc.Cep = (String)item[9];
                    objAssoc.Email = (String)item[10];
                    objAssoc.Fone = (String)item[11];
                    objAssoc.Fonecel = (String)item[12];

                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio");
            }
            finally
            {
                this.c.Connection().Close();
            }
            return objAssoc;
        }


        public DataSet ListarAssociado()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Conectar c = new Conectar();
            DataSet ds = new DataSet();
            DataTable dtAssociados = new DataTable();

            try
            {
                String sql = "select * from Associado";
                c.Connection().Open();
                c.Command().CommandText = sql;
                da.SelectCommand = c.Command();

                da.Fill(dtAssociados);
                ds.Tables.Add(dtAssociados);	
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio" + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
            return ds;
        }


        #endregion
    }
}
