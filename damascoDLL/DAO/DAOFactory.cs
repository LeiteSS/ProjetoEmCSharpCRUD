using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.DAO
{
    class DAOFactory
    {
        public static IProdutoDAO CriarProdutoDAO()
        {
            // return ProdutoDAOMemoria.Instancia();
            return new ProdutoSQL();
        }

        public static IComandaDAO CriarComandaDAO()
        {
            // return new ComandaDAOMySQL();
            return new ComandaSQL();
        }
    }
}
