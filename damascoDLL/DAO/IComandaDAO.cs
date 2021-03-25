using damascoDLL.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.DAO
{
    interface IComandaDAO
    {
        bool Inserir(Comanda c);

        List<Comanda> ListarTodas();

        List<Comanda> ListarAtivadas();

        bool Atualizar(Comanda c);
    }
}
