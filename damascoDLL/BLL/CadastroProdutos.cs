using damascoDLL.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.BLL
{
    public class CadastroProdutos
    {
        private IProdutoDAO dao;

        public CadastroProdutos()
        {
            dao = DAOFactory.CriarProdutoDAO();
        }

        public bool Inserir(Produto p)
        {
            return dao.Inserir(p);
        }

        public DataSet Listar()
        {
            return dao.Listar();
        }

        public bool Atualizar(Produto p)
        {
            return dao.Atualizar(p);
        }

        public bool Excluir(int codigo)
        {
            return dao.Excluir(codigo);
        }
    }
}
