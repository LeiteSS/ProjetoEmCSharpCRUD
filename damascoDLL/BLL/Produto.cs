using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace damascoDLL.BLL
{
    public class Produto
    {
        private int codigo;
        private string descricao;
        private double preco;

        public Produto(int codigo, string descricao, double preco)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }
}
