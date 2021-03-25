using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.BLL
{
    public class ItemComanda
    {
        private Produto produto;
        private double quantidade;

        public ItemComanda(Produto produto, double quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
        }

        public Produto Produto
        {
            get { return produto; }
            set { produto = value; }
        }

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double CalcularPreco()
        {
            return produto.Preco * quantidade;
        }
    }
}
