﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using Fachada.Interface;
using Fachada.BDcon;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using Fachada.Controlador;

namespace Fachada.Repositorio
{
    public class RepositorioEstabelecimento : IEstabelecimento
    {
        private Conectar c;

        public RepositorioEstabelecimento()
        {
           // this.c = new Conectar();
        }

        #region IEstabelecimento Members
        
        public void IncluirEstabelecimento(Estabelecimento objEstabelecimento)
        {
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "insert into estabelecimento (cnpj, razaosocial, endereco, numero, " +
                    "bairro, cidade, estado, cep, email, fone, fonecelular, qtdVagas, qtdVagasOcupadas)" +
                    "values (@cnpj, @razaosocial, @endereco, @numero, @bairro, @cidade, @estado, @cep, @email, @fone, @fonecelular," +
                        "@qtdVagas, @qtdVagasOcupadas)";
                this.c.Command().Parameters.Add("@cnpj", MySqlDbType.VarChar, 14).Value = objEstabelecimento.Cnpj;
                this.c.Command().Parameters.Add("@razaosocial", MySqlDbType.VarChar, 90).Value = objEstabelecimento.Razaosocial;
                this.c.Command().Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = objEstabelecimento.Endereco;
                this.c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = objEstabelecimento.Numero;
                this.c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = objEstabelecimento.Bairro;
                this.c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = objEstabelecimento.Cidade;
                this.c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = objEstabelecimento.Estado;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = objEstabelecimento.Cep;
                this.c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = objEstabelecimento.Email;
                this.c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = objEstabelecimento.Fone;
                this.c.Command().Parameters.Add("@fonecelular", MySqlDbType.VarChar, 10).Value = objEstabelecimento.Fonecelular;
                this.c.Command().Parameters.Add("@qtdVagas", MySqlDbType.Int32).Value = objEstabelecimento.QtdVagas;
                this.c.Command().Parameters.Add("@qtdVagasOcupadas", MySqlDbType.Int32).Value = objEstabelecimento.QtdVagasOcupadas;
                this.c.Command().ExecuteNonQuery();
                this.c.Comitar();
            }
            catch (MySqlException e)
            {
                this.c.Rolback();
                throw new Exception("Erro no Repositório Estabelecimento" + e);
            }
            finally 
            {
                this.c.Connection().Close();
            }
        
    }

        public void AlterarEstabelecimento(Estabelecimento objEstabelecimento)
        {
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "update estabelecimento set cnpj = @cnpj, razaosocial = @razaosocial," +
                    "endereco = @endereco, numero = @numero, bairro = @bairro, cidade = @cidade, estado = @estado," +
                    "cep = @cep, email = @email, fone= @fone, fonecelular= @fonecelular, qtdVagas = @qtdVagas, qtdVagasOcupadas = @qtdVagasOcupadas "+
                    "where idestabelecimento = @idestabelecimento";
                this.c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = objEstabelecimento.IdEstabelecimento;
                this.c.Command().Parameters.Add("@cnpj", MySqlDbType.VarChar, 14).Value = objEstabelecimento.Cnpj;
                this.c.Command().Parameters.Add("@razaosocial", MySqlDbType.VarChar, 90).Value = objEstabelecimento.Razaosocial;
                this.c.Command().Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = objEstabelecimento.Endereco;
                this.c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = objEstabelecimento.Numero;
                this.c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = objEstabelecimento.Bairro;
                this.c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = objEstabelecimento.Cidade;
                this.c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = objEstabelecimento.Estado;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = objEstabelecimento.Cep;
                this.c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = objEstabelecimento.Email;
                this.c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = objEstabelecimento.Fone;
                this.c.Command().Parameters.Add("@fonecelular", MySqlDbType.VarChar, 10).Value = objEstabelecimento.Fonecelular;
                this.c.Command().Parameters.Add("@qtdVagas", MySqlDbType.Int32).Value = objEstabelecimento.QtdVagas;
                this.c.Command().Parameters.Add("@qtdVagasOcupadas", MySqlDbType.Int32).Value = objEstabelecimento.QtdVagasOcupadas;
                this.c.Command().ExecuteNonQuery();
                this.c.Comitar();
            }
            catch (Exception e)
            {
                this.c.Rolback();
                throw new Exception("Erro no Repositório Estabelecimento");
            }
            finally 
            {
                this.c.Connection().Close();
            }
        }


        public Estabelecimento ConsultarEstabelecimento(int idEst)
        {
            Estabelecimento est = new Estabelecimento();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();

                //verificar se o campo não é nulo para efetuar consulta
                if (Validacao.ValidarNulo(idEst))
                {
                    this.c.Command().CommandText = "select * from estabelecimento where idestabelecimento = @idestabelecimento";
                    this.c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = idEst;
                }
                
                da.SelectCommand = this.c.Command();
                //this.c.Comitar();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");
                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    est.IdEstabelecimento = (Convert.IsDBNull(item[0]))? 0 : (int)item[0];
                    est.Cnpj = Convert.ToString(item[1]);
                    est.Razaosocial = Convert.ToString(item[2]);
                    est.Endereco = Convert.ToString(item[3]);
                    est.Numero = (Convert.IsDBNull(item[4])) ? 0 : (int)item[4];
                    est.Bairro = Convert.ToString(item[5]);
                    est.Cidade = Convert.ToString(item[6]);
                    est.Estado = Convert.ToString(item[7]);
                    est.Cep = Convert.ToString(item[8]);
                    est.Email = Convert.ToString(item[9]);
                    est.Fone = Convert.ToString(item[10]);
                    est.Fonecelular = Convert.ToString(item[11]);
                    est.QtdVagas = (Convert.IsDBNull(item[12])) ? 0 : (int)item[12];
                    est.QtdVagasOcupadas = (Convert.IsDBNull(item[13]))? 0 : (int)item[13];
                }
            }
            catch (Exception e)
            {
                //this.c.Rolback();
                throw new Exception("Erro no Repositório Estabelecimento");
            }
            finally 
            {
                this.c.Connection().Close();
            }
            return est;
            
        }

        public Estabelecimento ConsultarEstabelecimento(String cnpj)
        {
            Estabelecimento est = new Estabelecimento();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();

                //verificar se o campo não é nulo 
                if (Validacao.ValidarNulo(cnpj))
                {
                    this.c.Command().CommandText = "select * from estabelecimento where cnpj = @cnpj";
                    this.c.Command().Parameters.Add("@cnpj", MySqlDbType.String).Value = cnpj;
                }

                da.SelectCommand = this.c.Command();
                //this.c.Comitar();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");
                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    est.IdEstabelecimento = (Convert.IsDBNull(item[0])) ? 0 : (int)item[0];
                    est.Cnpj = Convert.ToString(item[1]);
                    est.Razaosocial = Convert.ToString(item[2]);
                    est.Endereco = Convert.ToString(item[3]);
                    est.Numero = (Convert.IsDBNull(item[4])) ? 0 : (int)item[4];
                    est.Bairro = Convert.ToString(item[5]);
                    est.Cidade = Convert.ToString(item[6]);
                    est.Estado = Convert.ToString(item[7]);
                    est.Cep = Convert.ToString(item[8]);
                    est.Email = Convert.ToString(item[9]);
                    est.Fone = Convert.ToString(item[10]);
                    est.Fonecelular = Convert.ToString(item[11]);
                    est.QtdVagas = (Convert.IsDBNull(item[12])) ? 0 : (int)item[12];
                    est.QtdVagasOcupadas = (Convert.IsDBNull(item[13])) ? 0 : (int)item[13];
                }
            }
            catch (Exception e)
            {
                //this.c.Rolback();
                throw new Exception("Erro no Repositório Estabelecimento");
            }
            finally
            {
                this.c.Connection().Close();
            }
            return est;

        }

        //carregar o último registro
        public Estabelecimento ConsultarEstabelecimento()
        {
            Estabelecimento est = new Estabelecimento();
            MySqlDataAdapter da = new MySqlDataAdapter();
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();

                //carregar o último registro
                {
                    this.c.Command().CommandText = "select * from estabelecimento where idestabelecimento = (SELECT MAX(idestabelecimento) FROM estabelecimento)";
                }

                da.SelectCommand = this.c.Command();
                //this.c.Comitar();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");
                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    est.IdEstabelecimento = (Convert.IsDBNull(item[0])) ? 0 : (int)item[0];
                    est.Cnpj = Convert.ToString(item[1]);
                    est.Razaosocial = Convert.ToString(item[2]);
                    est.Endereco = Convert.ToString(item[3]);
                    est.Numero = (Convert.IsDBNull(item[4])) ? 0 : (int)item[4];
                    est.Bairro = Convert.ToString(item[5]);
                    est.Cidade = Convert.ToString(item[6]);
                    est.Estado = Convert.ToString(item[7]);
                    est.Cep = Convert.ToString(item[8]);
                    est.Email = Convert.ToString(item[9]);
                    est.Fone = Convert.ToString(item[10]);
                    est.Fonecelular = Convert.ToString(item[11]);
                    est.QtdVagas = (Convert.IsDBNull(item[12])) ? 0 : (int)item[12];
                    est.QtdVagasOcupadas = (Convert.IsDBNull(item[13])) ? 0 : (int)item[13];
                }
            }
            catch (MySqlException e)
            {
                //this.c.Rolback();
                throw new Exception("Erro no Repositório Estabelecimento"+ e);
            }
            finally
            {
                this.c.Connection().Close();
            }
            return est;

        }

        public void ExcluirEstabelecimento(int idEstab)
        {
            try
            {
                this.c = new Conectar();
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "delete from estabelecimento where idestabelecimento = @idestabelecimento";
                this.c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = idEstab;
                this.c.Command().ExecuteNonQuery();
                this.c.Comitar();
            }
            catch (Exception e)
            {
                this.c.Rolback();
                throw new Exception("Erro no Repositório Estabelecimento");
            }
            finally
            {
                this.c.Connection().Close();
            }
        }
           
        public DataSet ListarEstabelecimento()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Conectar c = new Conectar();
            DataSet ds = new DataSet();
            DataTable dtEstabelecimento = new DataTable();

            try
            {
                String sql = "select * from Estabelecimento";
                c.Connection().Open();
                c.Command().CommandText = sql;
                da.SelectCommand = c.Command();

                da.Fill(dtEstabelecimento);
                ds.Tables.Add(dtEstabelecimento);
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

        public DataSet ListarEstabelecimento(String sFiltro, List<CampoBD> lsCampos)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            Conectar c = new Conectar();
            try
            {
                sFiltro = Util.f_RetornaFiltroCad(sFiltro, lsCampos);
                String sCampos = Util.f_RetornaSqlCampos(lsCampos);
                String sql = " SELECT " + sCampos + " FROM estabelecimento " + sFiltro;

                c.Connection().Open();
                c.Command().CommandText = sql;
                da.SelectCommand = c.Command();
                da.Fill(ds, "lista");
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
