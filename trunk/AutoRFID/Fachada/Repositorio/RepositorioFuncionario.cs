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
    public class RepositorioFuncionario : Ifuncionario
    {

        private Conectar c;

        public RepositorioFuncionario()
        {
            this.c = new Conectar();
        }

        #region Ifuncionario Members

        public void InserirFuncionario(Funcionario f)
        {
            try
            {
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "insert into funcionario (idestabelecimento, cpf, nome, numero) " +
                                                "bairro, cidade, estado, cep,email,idtipofuncionario,fone,foto" +
                                                "values(@idestabelecimento, @cpf, @nome, @numero,"
                                        + "@bairro, @cidade, @estado, @cep,@email,@idtipofuncionario,@fone,@foto)";

                this.c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = f.Idestabelecimento;
                this.c.Command().Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = f.Cpf;
                this.c.Command().Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = f.Nome;
                this.c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = f.Numero;
                this.c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = f.Bairro;
                this.c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = f.Cidade;
                this.c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = f.Estado;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = f.Cep;
                this.c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 40).Value = f.Email;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = f.Cep;
                this.c.Command().Parameters.Add("@idtipofuncionario", MySqlDbType.Int32).Value = f.Idtipofuncionario;
                this.c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = f.Fone;
                this.c.Command().Parameters.Add("@foto", MySqlDbType.VarChar, 60).Value = f.Foto;
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

        public void AlterarFuncionario(Funcionario f)
        {
            try
            {
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "update funcionario set idestabelecimento = @idestabelecimento," +
                "cpf = @cpf, nome = @nome, numero = @numero, bairro = @bairro, cidade = @cidade, estado = @estado, " +
                 "cep = @cep , email = @email, idtipofuncionario = @idtipofuncionario, fone = @fone, foto = @foto" +
                 "where idfuncionario = @idfuncionario";

                this.c.Command().Parameters.Add("@idfuncionario", MySqlDbType.Int32).Value = f.Idfuncionario;
                this.c.Command().Parameters.Add("@idestabelecimento", MySqlDbType.Int32).Value = f.Idestabelecimento;
                this.c.Command().Parameters.Add("@cpf", MySqlDbType.VarChar, 11).Value = f.Cpf;
                this.c.Command().Parameters.Add("@nome", MySqlDbType.VarChar, 60).Value = f.Nome;
                this.c.Command().Parameters.Add("@numero", MySqlDbType.Int32).Value = f.Numero;
                this.c.Command().Parameters.Add("@bairro", MySqlDbType.VarChar, 40).Value = f.Bairro;
                this.c.Command().Parameters.Add("@cidade", MySqlDbType.VarChar, 40).Value = f.Cidade;
                this.c.Command().Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = f.Estado;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = f.Cep;
                this.c.Command().Parameters.Add("@email", MySqlDbType.VarChar, 40).Value = f.Email;
                this.c.Command().Parameters.Add("@cep", MySqlDbType.VarChar, 8).Value = f.Cep;
                this.c.Command().Parameters.Add("@idtipofuncionario", MySqlDbType.Int32).Value = f.Idtipofuncionario;
                this.c.Command().Parameters.Add("@fone", MySqlDbType.VarChar, 10).Value = f.Fone;
                this.c.Command().Parameters.Add("@foto", MySqlDbType.VarChar, 60).Value = f.Foto;
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

        public void ExcluirFuncionario(int codigo)
        {
            try
            {
                this.c.Connection().Open();
                this.c.IniciarTransacao();
                this.c.Command().CommandText = "delete from funcionario where idfuncionario = @idfuncionario";
                this.c.Command().Parameters.Add("@idfuncionario", MySqlDbType.Int32).Value = codigo;
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

        public Funcionario ConsultarFuncionario(Funcionario f)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ListarFuncionario()
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}
