using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.BLL
{
    public class Comanda
    {
        private int numero;
        private string situacao;
        private int ativada;
        private List<ItemComanda> itens;

        public Comanda(int numero)
        {
            this.numero = numero;
            ativada = 1;
            itens = new List<ItemComanda>();
        }

        public Comanda(int numero, string situacao, int ativada) : this(numero)
        {
            this.ativada = ativada;
            this.situacao = situacao;
        }

        public int Numero
        {
            get { return numero; }
        }

        public string Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }


        public int Ativada
        {
            get { return ativada; }
            set { ativada = value; }
        }

        public List<ItemComanda> Itens
        {
            get { return itens; }
        }

        public void AdicionarItem(ItemComanda item)
        {
            if (item != null)
            {
                itens.Add(item);
            }
        }

        public bool ExcluirItem(int item)
        {
            itens.RemoveAt(item);
            return true;
        }

        public void AtualizarItem(int item, int quantidade)
        {
            itens[item].Quantidade = quantidade;
        }

        public double CalcularValorTotal()
        {
            double total = 0.0;
            foreach (ItemComanda item in itens)
            {
                total += item.CalcularPreco();
            }
            return total;
        }

        public void LimparComanda()
        {
            this.itens.Clear();
        }
    }
}
