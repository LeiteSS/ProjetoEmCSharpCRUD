using damascoDLL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.BLL
{
    public class CadastroComandas
    {
        private IComandaDAO dao;
        private static List<Comanda> comandas;

        public CadastroComandas()
        {
            dao = DAOFactory.CriarComandaDAO();
            if (comandas == null)
            {
                comandas = dao.ListarTodas();
            }
        }

        public bool Inserir(Comanda c)
        {
            if (dao.Inserir(c))
            {
                comandas.Add(c);
            }
            return false;
        }

        public List<Comanda> ListarTodas()
        {
            return comandas;
        }

        public List<Comanda> ListarAtivadas()
        {
            List<Comanda> ativadas = new List<Comanda>();
            foreach (Comanda c in comandas)
            {
                if (c.Ativada == 1)
                {
                    ativadas.Add(c);
                }
            }
            return ativadas;
        }

        public List<Comanda> ListarComItens()
        {
            List<Comanda> lista = new List<Comanda>();
            foreach (Comanda c in comandas)
            {
                if (c.Itens.Count > 0)
                {
                    lista.Add(c);
                }
            }
            return lista;
        }

        public bool Atualizar(Comanda c)
        {
            if (dao.Atualizar(c))
            {
                foreach (Comanda comanda in comandas)
                {
                    if (comanda.Numero == c.Numero)
                    {
                        comanda.Ativada = c.Ativada;
                        return true;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
