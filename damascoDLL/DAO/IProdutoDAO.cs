using damascoDLL.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.DAO
{
    interface IProdutoDAO
    {
        bool Inserir(Produto p);

        DataSet Listar();

        bool Atualizar(Produto p);

        bool Excluir(int codigo);
    }
}
