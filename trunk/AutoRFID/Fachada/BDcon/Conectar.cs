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

        //executar comando sql
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
