using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using damascoDLL.BLL;

namespace damascoDLL.DAO
{
    class ProdutoSQL : IProdutoDAO
    {
        // objeto usado para se conectar ao banco de dados
        private static SqlConnection conexao;

        public ProdutoSQL()
        {
            // cria um novo objeto de conexao, se não existir
            if (conexao == null)
            {
                conexao = new SqlConnection();
                // define a string de conexao com o banco de dados
                conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Produto.mdf;Integrated Security=True";
            }
        }

        public bool Atualizar(Produto p)
        {
            try
            {
                // verifica se existe uma conexao aberta
                if (conexao.State != ConnectionState.Open)
                {
                    // abre uma conexão com o banco de dados
                    conexao.Open();
                }
                // cria um comando SQL para ser executado
                SqlCommand cmd = new SqlCommand();
                // define a conexao com o banco de dados que será utilizada
                cmd.Connection = conexao;
                // define o texto do comando SQL que será executado
                cmd.CommandText = "UPDATE PRODUTO SET " +
                    "DESCRICAO = '" + p.Descricao + "', " +
                    "PRECO = " + p.Preco.ToString().Replace(",", ".") +
                    " WHERE CODIGO = " + p.Codigo;
                // executa o comando UPDATE                
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            return true;
        }

        public bool Excluir(int codigo)
        {
            try
            {
                // verifica se existe uma conexao aberta
                if (conexao.State != ConnectionState.Open)
                {
                    // abre uma conexão com o banco de dados
                    conexao.Open();
                }
                // cria um comando SQL para ser executado
                SqlCommand cmd = new SqlCommand();
                // define a conexao com o banco de dados que será utilizada
                cmd.Connection = conexao;
                // define o texto do comando SQL que será executado
                cmd.CommandText = "DELETE FROM PRODUTO WHERE CODIGO = " + codigo;
                // executa o comando DELETE                
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            return true;
        }

        public bool Inserir(Produto p)
        {
            try
            {
                // verifica se existe uma conexao aberta
                if (conexao.State != ConnectionState.Open)
                {
                    // abre uma conexão com o banco de dados
                    conexao.Open();
                }
                // cria um comando SQL para ser executado
                SqlCommand cmd = new SqlCommand();
                // define a conexao com o banco de dados que será utilizada
                cmd.Connection = conexao;
                // define o texto do comando SQL que será executado
                cmd.CommandText = "INSERT INTO PRODUTO (CODIGO, DESCRICAO, PRECO) " +
                    "VALUES (" + p.Codigo + ", '" + p.Descricao + "', " + p.Preco.ToString().Replace(",", ".") + ")";
                // executa o comando INSERT                
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return false;
            }
            return true;
        }

        public DataSet Listar()
        {
            string consulta = "SELECT CODIGO, DESCRICAO, PRECO FROM PRODUTO ORDER BY DESCRICAO";
            // cria um objeto DataAdapter para obter os dados do banco e carregar em um DataSet
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexao);
            DataSet produtos = new DataSet();
            // preenche o DataSet com os dados objetos pelo DataAdapter
            adapter.Fill(produtos, "Produto");
            return produtos;
        }
    }
}
