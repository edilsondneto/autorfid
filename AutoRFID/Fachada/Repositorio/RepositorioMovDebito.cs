using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using Fachada.BDcon;
using MySql.Data.MySqlClient;
using Fachada.Basicas;
using System.Data;

namespace Fachada.Repositorio
{
    public class RepositorioMovDebito : IMovDebito
    {
        #region IMovDebito Members

        public void InserirMovDedito(MovDebito mov)
        {
            Conectar c = new Conectar();
            try
            {
                String sql = "insert into movdebitos"
                + "(codigo_etiqueta,idassociado,idestabelecimento,dtEntrada, dtSaida, horaEntrada, horaSaida, valorDebitado)"
                + " values (@codigo_etiqueta,@idassociado,@idestabelecimento,@dtEntrada, @dtSaida, @horaEntrada, @horaSaida, @valorDebitado)";

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@codigo_etiqueta", MySqlDbType.VarChar, 10).Value = mov.IdCodigoEtiqueta;
                c.Command().Parameters.Add("@idassociado", MySqlDbType.Int32).Value = mov.Associado.Idassociado;
                c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = mov.Estabelecimento.IdEstabelecimento;
                c.Command().Parameters.Add("@dtEntrada", MySqlDbType.Date).Value = mov.DataEntrada;
                c.Command().Parameters.Add("@dtSaida", MySqlDbType.Date).Value = mov.DataSaida;
                c.Command().Parameters.Add("@horaEntrada", MySqlDbType.VarChar).Value = mov.HoraEntrada;
                c.Command().Parameters.Add("@horaSaida", MySqlDbType.VarChar).Value = mov.HoraSaida;
                c.Command().Parameters.Add("@valorDebitado", MySqlDbType.Double).Value = mov.ValorDebitado;

                c.Command().ExecuteNonQuery();
                c.Comitar();

            }
            catch (MySqlException e)
            {
                c.Rolback();
                throw new Exception("Erro no Repositorio --> " + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
        }

        public void ExcluirMovDedito(int idMov)
        {
            Conectar c = new Conectar();
            String sql = "delete from movdebitos where idMovDebito = @idMovDebito";
            try
            {
                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;
                
                c.Command().Parameters.Add("@idMovDebito", MySqlDbType.Int32).Value = idMov;
                c.Command().ExecuteNonQuery();
                c.Comitar();

            }
            catch (MySqlException e)
            {
                c.Rolback();
                throw new Exception("Erro no Repositorio --> " + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
        }

        public MovDebito ConsultarMovDebito(int idDebito)
        {
            Conectar c = new Conectar();
            MovDebito md = new MovDebito();
            MySqlDataAdapter da = new MySqlDataAdapter();
            String sql = "select * from movdebitos where idMovDebito = @idMovDebito";
            try
            {
                RepositorioEstabelecimento re = new RepositorioEstabelecimento();
                RepositorioAssociado ra = new RepositorioAssociado();
                RepositorioEtiqAssociado rea = new RepositorioEtiqAssociado();

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@idmMovDebito", MySqlDbType.Int32).Value = idDebito;
                da.SelectCommand = c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    md.IdMovDebito = (int)item[0];

                    Estabelecimento e = new Estabelecimento();
                    e.IdEstabelecimento = (int)item[1];
                    md.Estabelecimento = re.ConsultarEstabelecimento(e.IdEstabelecimento);

                    Associado a = new Associado();
                    a.Idassociado = (int)item[2];
                    md.Associado = ra.consultarAssociado(a.Idassociado);

                    EtiquetaAssociado ea = new EtiquetaAssociado();
                    ea.CodigoEtiqueta = (string)item[3];
               
                    md.DataEntrada = (DateTime)item[4];
                    md.DataSaida = (DateTime)item[5];
                    md.HoraEntrada = (String)item[6];
                    md.HoraSaida = (String)item[7];
                    md.ValorDebitado = (Double)item[8];
                       

                }

            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio --> " + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
            return md;
        }

        public List<MovDebito> ListarMovDebito()
        {
            Conectar c = new Conectar();
            RepositorioEstabelecimento re = new RepositorioEstabelecimento();
            RepositorioAssociado ra = new RepositorioAssociado();
            RepositorioEtiqAssociado rea = new RepositorioEtiqAssociado();
            MySqlDataAdapter da = new MySqlDataAdapter();
            String sql = "select * from movdebitos";
            List<MovDebito> lmv = new List<MovDebito>();
            try
            {
                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                da.SelectCommand = c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    MovDebito md = new MovDebito();
                    md.IdMovDebito = (int)item[0];

                    Estabelecimento e = new Estabelecimento();
                    e.IdEstabelecimento = (int)item[1];
                    md.Estabelecimento = re.ConsultarEstabelecimento(e.IdEstabelecimento);

                    Associado a = new Associado();
                    a.Idassociado = (int)item[2];
                    md.Associado = ra.consultarAssociado(a.Idassociado);

                    EtiquetaAssociado ea = new EtiquetaAssociado();
                    ea.CodigoEtiqueta = (string)item[3];

                    md.DataEntrada = (DateTime)item[4];
                    md.DataSaida = (DateTime)item[5];
                    md.HoraEntrada = (String)item[6];
                      md.HoraSaida = (String)item[7];
                    md.ValorDebitado = (Double)item[8];
                    lmv.Add(md);
                }

            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio --> " + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
            return lmv;
        }

        public DataSet ListarMovDebitoDataset()
        {
            Conectar c = new Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            String sql = "select * from movdebitos";
            try
            {
                c.Connection().Open();
                c.Command().CommandText = sql;

                da.SelectCommand = c.Command();
                da.Fill(ds, "lista");
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio --> " + e.Message);
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
