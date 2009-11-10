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
                + "(idfuncionario,idestabelecimento,idassociado,codigo_etiqueta,"
                + "idformapagamento,dtcompra,dtcredito,valorcreditado,tipopagamento)"
                + " values(@idfuncionario,@idestabelecimento,@idassociado,@codigo_etiqueta,"
                + "@idformapagamento,@dtcompra,@dtcredito,@valorcreditado,@tipopagamento)";
                

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                //c.Command().Parameters.Add("@idmovcreditos", MySqlDbType.Int32).Value = mov.IdMovCredito;
                c.Command().Parameters.Add("@idfuncionario", MySqlDbType.Int32).Value = mov.Funcionario.Idfuncionario;
                c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = mov.Estabelecimento.IdEstabelecimento;
                c.Command().Parameters.Add("@idassociado", MySqlDbType.Int32).Value = mov.Associado.Idassociado;
                c.Command().Parameters.Add("@codigo_etiqueta", MySqlDbType.VarChar, 10).Value = mov.Etiquetaassociado.CodigoEtiqueta;
                c.Command().Parameters.Add("@tipopagamento", MySqlDbType.VarChar,1).Value = mov.FormaPag;
                c.Command().Parameters.Add("@dtcompra", MySqlDbType.Date).Value = mov.DtCompra;
                c.Command().Parameters.Add("@dtcredito", MySqlDbType.Date).Value = mov.DtCredito;
                c.Command().Parameters.Add("@valorcreditado", MySqlDbType.Float).Value = mov.VlCredito;
                c.Command().Parameters.Add("@idformapagamento",MySqlDbType.Int32).Value = 1;
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
                    mc.IdMovCredito = (Convert.IsDBNull(item[0])) ? 0 : Convert.ToInt32(item[0]);
                    mc.Funcionario = rf.ConsultarFuncionario((Convert.IsDBNull(item[1])) ? 0 :Convert.ToInt32( item[1]));
                    mc.Estabelecimento = re.ConsultarEstabelecimento((Convert.IsDBNull(item[2])) ? 0 : Convert.ToInt32(item[2]));
                    mc.Associado = ra.consultarAssociado((Convert.IsDBNull(item[3])) ? 0 : Convert.ToInt32(item[3]));
                    mc.Etiquetaassociado = rea.ConsultarEtiquetaAssociado((Convert.IsDBNull(item[4])) ? " " : Convert.ToString(item[4]));
                    mc.DtCredito = Convert.ToDateTime(item[6]);
                    if (!Convert.IsDBNull(item[7]))
                    {
                        mc.DtCredito = Convert.ToDateTime(item[7]);
                    }
                    mc.VlCredito = (Convert.IsDBNull(item[8])) ? 0 : (float.Parse(item[8].ToString().Replace('.', ',')));
                    mc.FormaPag = (Convert.IsDBNull(item[9])) ? " " : Convert.ToString(item[9]);

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
                    mc.IdMovCredito = (Convert.IsDBNull(item[0])) ? 0 : Convert.ToInt32(item[0]);
                    mc.Funcionario = rf.ConsultarFuncionario((Convert.IsDBNull(item[1])) ? 0 : Convert.ToInt32(item[1]));
                    mc.Estabelecimento = re.ConsultarEstabelecimento((Convert.IsDBNull(item[2])) ? 0 : Convert.ToInt32(item[2]));
                    mc.Associado = ra.consultarAssociado((Convert.IsDBNull(item[3])) ? 0 : Convert.ToInt32(item[3]));
                    mc.Etiquetaassociado = rea.ConsultarEtiquetaAssociado((Convert.IsDBNull(item[4])) ? " " : Convert.ToString(item[4]));
                    mc.DtCompra = Convert.ToDateTime(item[6]);
                    if(!Convert.IsDBNull(item[7])){
                        mc.DtCredito = Convert.ToDateTime(item[7]);
                    }
                    mc.VlCredito = (Convert.IsDBNull(item[8])) ? 0 : (float.Parse(item[8].ToString().Replace('.',',')));
                    mc.FormaPag = (Convert.IsDBNull(item[9])) ? " " : Convert.ToString(item[9]);
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

        public DataSet ListarMovCreditoDataset(String sFiltro, List<CampoBD> lsCampos)
        {
            Conectar c = new Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet(); 
            sFiltro = Util.f_RetornaFiltroCad(sFiltro, lsCampos);
            String sCampos = Util.f_RetornaSqlCampos(lsCampos);
            String sql = " SELECT " + sCampos + " FROM MOVCREDITOS " + sFiltro;
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
