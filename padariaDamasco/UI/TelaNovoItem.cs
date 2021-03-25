using damascoDLL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace padariaDamasco.UI
{
    public partial class frmNovoItem : Form
    {
        private CadastroProdutos produtos;
        private CadastroComandas comandas;
        private DataSet dtProdutos;


        public frmNovoItem()
        {
            InitializeComponent();
            comandas = new CadastroComandas();
            produtos = new CadastroProdutos();
            dtProdutos = produtos.Listar();
            Limpar();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            // obtém o objeto comanda selecionado
            Comanda c = cbComandas.SelectedValue as Comanda;
            // busca o objeto produto a partir do produto selecionado
            Produto p = ObterProduto(Convert.ToInt32(cbProdutos.SelectedValue));
            if (p != null)
            {
                // TODO: validar campo
                double quantidade = Convert.ToDouble(txtQuantidade.Text);
                // cria um novo item e adiciona na comanda
                ItemComanda item = new ItemComanda(p, quantidade);
                c.AdicionarItem(item);
            }
            // verifica se deseja adicionar um novo item, senão fecha a tela
            DialogResult resultado = MessageBox.Show("Item incluido com sucesso\r\nDeseja incluir outro item?",
                "Confirmação", MessageBoxButtons.YesNoCancel);
            if (resultado == DialogResult.No)
            {
                Close();
            }
            else
            {
                Limpar();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Produto ObterProduto(int codigo)
        {
            foreach (DataRow l in dtProdutos.Tables[0].Rows)
            {
                if (l["Codigo"].Equals(codigo))
                {
                    string desc = l["Descricao"].ToString();
                    double preco = Convert.ToDouble(l["Preco"]);
                    return new Produto(codigo, desc, preco);
                }
            }
            return null;
        }

        private void Limpar()
        {
            // carrega o combo de comandas
            cbComandas.DataSource = comandas.ListarAtivadas();
            cbComandas.DisplayMember = "numero";
            // carrega o combo de produtos
            cbProdutos.DataSource = dtProdutos.Tables[0];
            cbProdutos.DisplayMember = "Descricao";
            cbProdutos.ValueMember = "Codigo";
            // limpa o campo de quantidade
            txtQuantidade.Text = string.Empty;

        }
    }
}
