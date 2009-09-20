using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

namespace Fachada.BDcon
{
    public class Conectar
    {
        private MySqlConnection conexao;// Será a conexão principal com o Banco de Dados.
        private MySqlCommand comando;  // Componente Command principal para execução de comando diretos (Não Select).
        private MySqlTransaction mt;

        String strConexao;

        public Conectar()
        {   /* String de conexão gerada para acessar o banco localmente, na mesma pasta que o executável. */
            this.strConexao = Properties.Settings.Default.Constring;
            this.conexao = new MySqlConnection(this.strConexao);
            this.comando = new MySqlCommand();
            this.comando.Connection = this.conexao;
        }

        // Método utilizado para a execução de comandos SQL não queries: Insert, Delete ou Update.
        public void ExecutarComando(String cmd)
        {
            try
            {
                this.conexao.Open();
            
                this.IniciarTransacao();
            
                this.comando.CommandText = cmd;
                this.comando.ExecuteNonQuery();
                this.Comitar();
            }
            catch (Exception e)
            {
                this.Rolback();
                throw new Exception("Erro na base de dados");

            }
            finally
            {
                this.conexao.Close();
            }

        }

        // Método utilizado para execução de pesquisas no banco.
        public DataSet ExecutarPerquisa(String query)
        {
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(query, this.conexao);//Este método abre e depois fecha a conexão.
            try
            {
                da.Fill(ds);// Manda o DataAdapter preencher o DataSet com o resultado da pesquisa.

            }
            catch (Exception e)
            {

            }

            return ds;
        }

        //Controle de transações
        public void IniciarTransacao()
        {
            this.mt = this.conexao.BeginTransaction();
        }

        public void Comitar()
        {
            this.mt.Commit();
        }

        public void Rolback()
        {
            this.mt.Rollback();
        }

        public MySqlCommand Command()
        {
            return this.comando;
        }

        public MySqlConnection Connection()
        {
            return this.conexao;
        }

    }
}
