using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.Basicas;
using System.Data;
using Fachada.BDcon;
using MySql.Data.MySqlClient;
using Fachada.Controlador;

namespace Fachada.Repositorio
{
    class RepositorioEtiqAssociado : IEtiquetaAssociado
    {

        public RepositorioEtiqAssociado()
        {
        }

        #region IetiquetaAssociado Members
        public void InserirEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado)
        {
            Conectar conexao = new Conectar();
            try
            {
                conexao.Connection().Open();
                conexao.IniciarTransacao();
                conexao.Command().CommandText = "insert into etiquetaassociado (codigo_etiqueta, idAssociado, saldo, situacao, valor) values (@codigo_etiqueta, @idAssociado, @saldo, @situacao, @valor)";

                conexao.Command().Parameters.Add("@codigo_etiqueta", MySqlDbType.VarChar, 10).Value = etiquetaAssociado.CodigoEtiqueta;
                conexao.Command().Parameters.Add("@idAssociado", MySqlDbType.Int16, 11).Value = etiquetaAssociado.Associado.Idassociado;
                conexao.Command().Parameters.Add("@saldo", MySqlDbType.Decimal).Value = etiquetaAssociado.Saldo;
                conexao.Command().Parameters.Add("@situacao", MySqlDbType.VarChar, 1).Value = etiquetaAssociado.Situacao;
                conexao.Command().Parameters.Add("@valor", MySqlDbType.Decimal).Value = etiquetaAssociado.Valor;

                conexao.Command().ExecuteNonQuery();
                conexao.Comitar();
            }
            catch (MySqlException ex)
            {
                conexao.Rolback();
                throw new Exception("Erro no repositório EtiquetaAssociado " + ex.Message);
            }
            finally
            {
                conexao.Connection().Close();
            }

        }

        public void AlterarEtiquetaAssociado(EtiquetaAssociado etiquetaAssociado)
        {
            Conectar conexao = new Conectar();
            try
            {
                conexao.Connection().Open();
                conexao.IniciarTransacao();
                conexao.Command().CommandText = "update etiquetaassociado set codigo_etiqueta = @codigo_etiqueta, idAssociado = @idAssociado, saldo = @saldo, situacao = @situacao, valor = @valor where codigo_etiqueta = @codigo_etiqueta";

                conexao.Command().Parameters.Add("@codigo_etiqueta", MySqlDbType.VarChar, 10).Value = etiquetaAssociado.CodigoEtiqueta;
                conexao.Command().Parameters.Add("@idAssociado", MySqlDbType.Int16, 11).Value = etiquetaAssociado.Associado.Idassociado;
                conexao.Command().Parameters.Add("@saldo", MySqlDbType.Decimal).Value = etiquetaAssociado.Saldo;
                conexao.Command().Parameters.Add("@situacao", MySqlDbType.VarChar, 1).Value = etiquetaAssociado.Situacao;
                conexao.Command().Parameters.Add("@valor", MySqlDbType.Decimal).Value = etiquetaAssociado.Valor;

                conexao.Command().ExecuteNonQuery();
                conexao.Comitar();
            }
            catch (MySqlException ex)
            {
                conexao.Rolback();
                throw new Exception("Erro no repositório EtiquetaAssociado " + ex.Message);
            }
            finally
            {
                conexao.Connection().Close();
            }
        }

        public void ExcluirEtiquetaAssociado(String codigo)
        {
            Conectar conexao = new Conectar();
            try
            {
                conexao.Connection().Open();
                conexao.IniciarTransacao();
                conexao.Command().CommandText = "delete from etiquetaassociado where codigo_etiqueta = @codigo_etiqueta;";

                conexao.Command().Parameters.Add("@codigo_etiqueta", MySqlDbType.VarChar, 10).Value = codigo;

                conexao.Command().ExecuteNonQuery();
                conexao.Comitar();
            }
            catch (MySqlException ex)
            {
                conexao.Rolback();
                throw new Exception("Erro no repositório EtiquetaAssociado " + ex.Message);
            }
            finally
            {
                conexao.Connection().Close();
            }
        }

        public EtiquetaAssociado ConsultarEtiquetaAssociado(String codigoetiqueta)
        {
            EtiquetaAssociado est = new EtiquetaAssociado();
            MySqlDataAdapter da = new MySqlDataAdapter();
            RepositorioAssociado ra = new RepositorioAssociado();
            Conectar conexao = new Conectar();
            try
            {
                String sql = "";

                if (!codigoetiqueta.Equals("0"))
                {
                    sql = "select * from etiquetaassociado where codigo_etiqueta = @codigo_etiqueta";
                }
                else
                {
                    sql = "select * from etiquetaassociado where codigo_etiqueta = (SELECT MAX(codigo_etiqueta) FROM etiquetaassociado)";
                }

                conexao.Connection().Open();
                conexao.Command().CommandText = sql;
                conexao.Command().Parameters.Add("@codigo_etiqueta", MySqlDbType.VarChar, 10).Value = codigoetiqueta;
                da.SelectCommand = conexao.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {

                    est.CodigoEtiqueta = (String)item[0];
                    est.Associado = ra.consultarAssociado((int)item[1] );
                    est.Saldo = (decimal)item[2];
                    est.Situacao = (String)item[3];
                    est.Valor = (decimal)item[4];

                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositório EtiquetaAssociado");
            }
            finally
            {
                conexao.Connection().Close();
            }
            return est;
        }

        public DataSet ListarEtiquetaAssociado()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Conectar c = new Conectar();
            DataSet ds = new DataSet();
            try
            {
                String sql = "select * from etiquetaassociado";
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

        public DataSet ListarEtiquetaAssociado(int idAssociado)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Conectar c = new Conectar();
            DataSet ds = new DataSet();

            try
            {
                String sql = "select * from etiquetaassociado where idAssociado = @idAssociado";

                c.Connection().Open();
                c.Command().Parameters.Add("@idAssociado", MySqlDbType.Int16).Value = idAssociado;
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

        public DataSet ListarEtiquetaAssociado(string situacao)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            Conectar c = new Conectar();
            DataSet ds = new DataSet();

            try
            {
                String sql = "select * from etiquetaassociado where situacao = @situacao";

                c.Connection().Open();
                c.Command().Parameters.Add("@situacao", MySqlDbType.VarChar, 1).Value = situacao;
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

        public DataSet ListarEtiquetaAssociado(string sFiltro, List<CampoBD> lsCampos)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            Conectar c = new Conectar();
            try
            {
                sFiltro = Util.f_RetornaFiltroCad(sFiltro, lsCampos);
                String sCampos = Util.f_RetornaSqlCampos(lsCampos);
                String sql = " SELECT " + sCampos + " FROM etiquetaassociado " + sFiltro;

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
