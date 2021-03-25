using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damascoDLL.DAO
{
    class ConexaoSQL
    {
        // objeto de conexão com o MySQL
        private static SqlConnection conexao;

        public ConexaoSQL()
        {
            Inicializar();
        }

        private void Inicializar()
        {
            if (conexao == null)
            {
                conexao = new SqlConnection();
                // string de conexão com o MySQL obtida do arquivo App.config
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["sql"].ConnectionString;
            }
        }

        public bool AbrirConexao()
        {
            try
            {
                if (conexao.State != ConnectionState.Open)
                {
                    conexao.Open();
                }
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro de Conexao SQL: " + e);
            }
            return false;
        }

        public bool FecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro ao fechar Conexao SQL: " + e);
                Console.WriteLine(e);
            }
            return false;
        }

        public void ExecutarSemConsulta(string sql)
        {
            if (AbrirConexao() == true)
            {
                // cria um objeto MySqlCommand
                SqlCommand cmd = new SqlCommand();
                // define a conexao com o MySQL que será utilizada
                cmd.Connection = conexao;
                // define o texto do comando SQL que será executado
                cmd.CommandText = sql;
                // executa o comando de INSERT / UPDATE / DELETE
                cmd.ExecuteNonQuery();
                FecharConexao();
            }
        }

        public SqlDataReader ExecutarConsulta(string sql)
        {
            if (AbrirConexao() == true)
            {
                // cria um objeto MySqlCommand
                SqlCommand cmd = new SqlCommand();
                // define a conexao com o MySQL que será utilizada
                cmd.Connection = conexao;
                // define o texto do comando SQL que será executado
                cmd.CommandText = sql;
                // executa o comando de SELECT e retorna um objeto MySqlDataReader
                return cmd.ExecuteReader();
            }
            return null;
        }
    }
}
