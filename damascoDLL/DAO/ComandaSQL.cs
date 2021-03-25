using damascoDLL.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace damascoDLL.DAO
{
    class ComandaSQL : IComandaDAO
    {
        private ConexaoSQL conexao;

        public ComandaSQL()
        {
            conexao = new ConexaoSQL();
        }

        public bool Atualizar(Comanda c)
        {
            String sql = "UPDATE COMANDA SET SITUACAO =  " + c.Ativada +
                            " WHERE NUMERO = " + c.Numero;
            try
            {
                conexao.ExecutarSemConsulta(sql);
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro de Conexao SQL: " + e);
            }
            return false;
        }

        public bool Inserir(Comanda c)
        {
            String sql = "INSERT INTO COMANDA (NUMERO, SITUACAO, ATIVADA) " +
                 "VALUES (" + c.Numero + ", '" + c.Situacao  +"', "+ c.Ativada + ")";
            try
            {
                conexao.ExecutarSemConsulta(sql);
                return true;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Erro de Conexao SQL: " + e);
            }
            return false;
        }

        public List<Comanda> ListarAtivadas()
        {
            string consulta = "SELECT NUMERO, SITUACAO, ATIVADA FROM COMANDA WHERE ATIVADA = 1"; ;
            return Listar(consulta);
        }

        public List<Comanda> ListarTodas()
        {
            string consulta = "SELECT NUMERO, SITUACAO, ATIVADA FROM COMANDA";
            return Listar(consulta);
        }

        private List<Comanda> Listar(string sql)
        {
            List<Comanda> comandas = new List<Comanda>();
            SqlDataReader reader = conexao.ExecutarConsulta(sql);
            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                int n = Convert.ToInt32(reader["numero"]);
                string s = Convert.ToString(reader["situacao"]);
                int a = Convert.ToInt32(reader["ativada"]);
                comandas.Add(new Comanda(n, s, a));
            }
            conexao.FecharConexao();
            return comandas;
        }
    }
}
