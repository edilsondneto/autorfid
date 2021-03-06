﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fachada.Basicas;
using Fachada.Interface;
using Fachada.BDcon;
using MySql.Data.MySqlClient;
using System.Data;

namespace Fachada.Repositorio
{
    public class RepositorioFuncionario : Ifuncionario
    {

        public RepositorioFuncionario()
        {

        }

        #region Ifuncionario Members
        public void InserirFuncionario(Funcionario f)
        {
            Conectar c = new Conectar();
            try
            {
                String sql = "insert into funcionario"
                + "(cpf, nome, endereco, numero, bairro, cidade, estado, cep, email, fone, fonecelular,"
                + "idEstabelecimento, funcao) values(@cpf, @nome, @endereco, @numero, @bairro,"
                + "@cidade, @estado, @cep, @email, @fone, @fonecelular, @idEstabelecimento, @funcao)";

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = f.Cpf;
                c.Command().Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = f.Nome;
                c.Command().Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = f.Endereco;
                c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = f.Numero;
                c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = f.Bairro;
                c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = f.Cidade;
                c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = f.Estado;
                c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = f.Cep;
                c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 40).Value = f.Email;
                c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = f.Fone;
                c.Command().Parameters.Add("@fonecelular", MySqlDbType.VarChar, 10).Value = f.Fonecelular;
                c.Command().Parameters.Add("@idEstabelecimento", MySqlDbType.Int32).Value = f.Idestabelecimento;
                c.Command().Parameters.Add("@funcao", MySqlDbType.VarChar, 1).Value = f.Funcao;
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

        public void AlterarFuncionario(Funcionario f)
        {
            Conectar c = new Conectar();
            try
            {

                String sql = "update funcionario set cpf = @cpf," +
                "nome = @nome, endereco = @endereco, numero = @numero, bairro = @bairro, cidade = @cidade, estado = @estado, " +
                "cep = @cep , email = @email, fone = @fone, fonecelular = @fonecelular, idestabelecimento = @idestabelecimento, funcao = @funcao " +
                "where idfuncionario = @idfuncionario";

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@idfuncionario", MySqlDbType.Int32, 11).Value = f.Idfuncionario;
                c.Command().Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = f.Cpf;
                c.Command().Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = f.Nome;
                c.Command().Parameters.Add("@endereco", MySqlDbType.VarChar, 60).Value = f.Endereco;
                c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = f.Numero;
                c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = f.Bairro;
                c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = f.Cidade;
                c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = f.Estado;
                c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = f.Cep;
                c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 60).Value = f.Email;
                c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = f.Fone;
                c.Command().Parameters.Add("@fonecelular", MySqlDbType.VarChar, 10).Value = f.Fonecelular;
                c.Command().Parameters.Add("@idEstabelecimento", MySqlDbType.Int32).Value = f.Idestabelecimento;
                c.Command().Parameters.Add("@funcao", MySqlDbType.VarChar, 1).Value = f.Funcao;
                c.Command().ExecuteNonQuery();
                c.Comitar();
            }
            catch (MySqlException e)
            {
                c.Rolback();
                throw new Exception("Erro no Repositorio" + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
        }

        public void ExcluirFuncionario(String cpf)
        {
            Conectar c = new Conectar();
            try
            {
                String sql = "delete from funcionario where cpf = @cpf";

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = cpf;
                c.Command().ExecuteNonQuery();
                c.Comitar();

            }
            catch (MySqlException e)
            {
                c.Rolback();
                throw new Exception("Erro no Repositorio" + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
        }

        public void ExcluirFuncionario(int idfuncionario)
        {
            Conectar c = new Conectar();
            try
            {
                String sql = "delete from funcionario where idfuncionario = @idfuncionario";

                c.Connection().Open();
                c.IniciarTransacao();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@idfuncionario", MySqlDbType.Int32).Value = idfuncionario;
                c.Command().ExecuteNonQuery();
                c.Comitar();

            }
            catch (MySqlException e)
            {
                c.Rolback();
                throw new Exception("Erro no Repositorio" + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
        }

        public Funcionario ConsultarFuncionario(int codigo)
        {
            Funcionario func = new Funcionario();
            Conectar c = new Conectar();
            try
            {
                String sql = "";
                MySqlDataAdapter da = new MySqlDataAdapter();
                if (codigo != 0)
                {
                    sql = "select * from funcionario where idfuncionario = @idfuncionario";
                }
                else
                {
                    sql = "select * from funcionario where idfuncionario = (SELECT MAX(idfuncionario) FROM funcionario)";
                }

                c.Connection().Open();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@idfuncionario", MySqlDbType.Int32).Value = codigo;
                da.SelectCommand = c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    func.Idfuncionario = (Convert.IsDBNull(item[0])) ? 0 : (int)item[0];
                    func.Cpf = Convert.ToString(item[1]);
                    func.Nome = Convert.ToString(item[2]);
                    func.Endereco = Convert.ToString(item[3]);
                    func.Numero = (Convert.IsDBNull(item[4])) ? 0 : (int)item[4];
                    func.Bairro = Convert.ToString(item[5]);
                    func.Cidade = Convert.ToString(item[6]);
                    func.Estado = Convert.ToString(item[7]);
                    func.Cep = Convert.ToString(item[8]);
                    func.Email = Convert.ToString(item[9]);
                    func.Fone = Convert.ToString(item[10]);
                    func.Fonecelular = Convert.ToString(item[11]);
                    func.Idestabelecimento = (Convert.IsDBNull(item[12])) ? 0 : (int)item[12];
                    func.Funcao = Convert.ToString(item[13]);
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio" + e.Message);
            }
            finally
            {
                c.Connection().Close();
            }
            return func;
        }

        public Funcionario ConsultarFuncionario(String cpf)
        {
            Funcionario func = new Funcionario();
            MySqlDataAdapter da = new MySqlDataAdapter();
            Conectar c = new Conectar();
            try
            {
                String sql = "select * from funcionario where cpf = @cpf";

                c.Connection().Open();
                c.Command().CommandText = sql;

                c.Command().Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = cpf;
                da.SelectCommand = c.Command();
                DataSet ds = new DataSet();
                da.Fill(ds, "lista");

                foreach (DataRow item in ds.Tables["lista"].Rows)
                {
                    func.Idfuncionario = (Convert.IsDBNull(item[0])) ? 0 : (int)item[0];
                    func.Cpf = Convert.ToString(item[1]);
                    func.Nome = Convert.ToString(item[2]);
                    func.Endereco = Convert.ToString(item[3]);
                    func.Numero = (Convert.IsDBNull(item[4])) ? 0 : (int)item[4];
                    func.Bairro = Convert.ToString(item[5]);
                    func.Cidade = Convert.ToString(item[6]);
                    func.Estado = Convert.ToString(item[7]);
                    func.Cep = Convert.ToString(item[8]);
                    func.Email = Convert.ToString(item[9]);
                    func.Fone = Convert.ToString(item[10]);
                    func.Fonecelular = Convert.ToString(item[11]);
                    func.Idestabelecimento = (Convert.IsDBNull(item[12])) ? 0 : (int)item[12];
                    func.Funcao = Convert.ToString(item[13]);
                }
            }
            catch (MySqlException e)
            {
                throw new Exception("Erro no Repositorio" + e);
            }
            finally
            {
                c.Connection().Close();
            }
            return func;
        }

        public DataSet ListarFuncionario(String sFiltro, List<CampoBD> lsCampos)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            Conectar c = new Conectar();
            try
            {
                sFiltro = Util.f_RetornaFiltroCad(sFiltro, lsCampos);
                String sCampos = Util.f_RetornaSqlCampos(lsCampos);
                String sql = " SELECT " + sCampos + " FROM FUNCIONARIO " + sFiltro;

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

        public DataSet ListarFuncionario()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataSet ds = new DataSet();
            Conectar c = new Conectar();
            try
            {
                String sql = " SELECT * FROM FUNCIONARIO";

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
