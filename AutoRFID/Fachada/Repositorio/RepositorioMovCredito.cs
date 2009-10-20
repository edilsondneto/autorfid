using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Interface;
using MySql.Data.MySqlClient;
using Fachada.BDcon;
using System.Data;
using Fachada.Basicas;

namespace Fachada.Repositorio
{
    public class RepositorioMovCredito:IMovCredito
    {
        public RepositorioMovCredito()
        {

        }

        #region IMovCredito Members
        public void InserirMovCredito(MovCredito mov)
        {
            Conectar c = new Conectar();
            try
            {
                String sql = "insert into movcreditos"
                + "(idmovcreditos,idfuncionario,idestabelecimento,idassociado,codigo_etiqueta,"
                + "idformapagamento,dtcompra,dtcredito,valorcreditado,tipopagamento)"
                + " values(@idmovcreditos,@idfuncionario,@idestabelecimento,@idassociado,@codigo_etiqueta,"
                + "@idformapagamento,@dtcompra,@dtcredito,@valorcreditado,@tipopagamento)";

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@idmovcreditos", MySqlDbType.Int32).Value = mov.IdMovCredito;
                c.Command().Parameters.Add("@idfuncionario", MySqlDbType.Int32).Value = mov.Funcionario.Idfuncionario;
                c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = mov.Estabelecimento.IdEstabelecimento;
                c.Command().Parameters.Add("@idassociado", MySqlDbType.Int32).Value = mov.Associado.Idassociado;
                c.Command().Parameters.Add("@codigo_etiqueta", MySqlDbType.VarChar, 10).Value = mov.Etiquetaassociado.CodigoEtiqueta;
                c.Command().Parameters.Add("@idformapagamento", MySqlDbType.Int32).Value = mov.FormaPag;
                c.Command().Parameters.Add("@dtcompra", MySqlDbType.Date).Value = mov.DtCompra;
                c.Command().Parameters.Add("@dtcredito", MySqlDbType.Date).Value = mov.DtCredito;
                c.Command().Parameters.Add("@valorcreditado", MySqlDbType.Float).Value = mov.VlCredito;
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

        public void ExcluirMovCredito(int idMov)
        {
            Conectar c = new Conectar();
            String sql = "delete from movcreditos where idmovcreditos = @idmovcreditos";
            try
            {
                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@idmovcreditos", MySqlDbType.Int32).Value = idMov;
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

        public MovCredito ConsultarMovCredito(int idCredito)
        {
            Conectar c = new Conectar();
            MovCredito mc = new MovCredito();
            MySqlDataAdapter da = new MySqlDataAdapter();
            String sql = "select * from movcreditos where idmovcreditos = @idmovcreditos";
            try
            {
                RepositorioFuncionario rf = new RepositorioFuncionario();
                RepositorioEstabelecimento re = new RepositorioEstabelecimento();
                RepositorioAssociado ra = new RepositorioAssociado();
                RepositorioEtiqAssociado rea = new RepositorioEtiqAssociado();

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@idmovcreditos", MySqlDbType.Int32).Value = idCredito;
                da.SelectCommand = c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    mc.IdMovCredito = (int) item[0];
                    mc.Funcionario = rf.ConsultarFuncionario((int) item[1]);
                    
                    Estabelecimento e = new Estabelecimento();
                    e.IdEstabelecimento = (int)item[2];
                    mc.Estabelecimento = re.ConsultarEstabelecimento(e.IdEstabelecimento);

                    Associado a = new Associado();
                    a.Idassociado = (int)item[3];
                    mc.Associado = ra.consultarAssociado(a.Idassociado);

                    EtiquetaAssociado ea = new EtiquetaAssociado();
                    ea.CodigoEtiqueta = (string)item[4];
                  //  mc.Etiquetaassociado = rea.ConsultarEtiquetaAssociado(ea);

                    mc.DtCompra = (DateTime)item[5];
                    mc.DtCredito = (DateTime)item[6];
                    mc.VlCredito = (float)item[7];
                    mc.FormaPag = (string)item[8];

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
            return mc;
        }

        public List<MovCredito> ListarMovCredito()
        {
            Conectar c = new Conectar();
            RepositorioFuncionario rf = new RepositorioFuncionario();
            RepositorioEstabelecimento re = new RepositorioEstabelecimento();
            RepositorioAssociado ra = new RepositorioAssociado();
            RepositorioEtiqAssociado rea = new RepositorioEtiqAssociado();
            MySqlDataAdapter da = new MySqlDataAdapter();
            String sql = "select * from movcreditos";
            List<MovCredito> lmv = new List<MovCredito>();
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
                    MovCredito mc = new MovCredito();
                    mc.IdMovCredito = (int)item[0];
                    mc.Funcionario = rf.ConsultarFuncionario((int)item[1]);

                    Estabelecimento e = new Estabelecimento();
                    e.IdEstabelecimento = (int)item[2];
                    mc.Estabelecimento = re.ConsultarEstabelecimento(e.IdEstabelecimento);

                    Associado a = new Associado();
                    a.Idassociado = (int)item[3];
                    mc.Associado = ra.consultarAssociado(a.Idassociado);

                    EtiquetaAssociado ea = new EtiquetaAssociado();
                    ea.CodigoEtiqueta = (string)item[4];
             //       mc.Etiquetaassociado = rea.ConsultarEtiquetaAssociado(ea);

                    mc.DtCompra = (DateTime)item[5];
                    mc.DtCredito = (DateTime)item[6];
                    mc.VlCredito = (float)item[7];
                    mc.FormaPag = (string)item[8];
                    lmv.Add(mc);
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

        public DataSet ListarMovCreditoDataset()
        {
            Conectar c = new Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            String sql = "select * from movcreditos";
            try
            {
                c.Connection().Open();
                c.IniciarTransacao();
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
