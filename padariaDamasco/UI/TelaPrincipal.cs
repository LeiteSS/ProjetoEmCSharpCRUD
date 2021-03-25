using damascoDLL.BLL;
using padariaDamasco.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace padariaDamasco
{
    public partial class frmTelaPrincipal : Form
    {
        private CadastroComandas comandas;
        private Comanda comandaCorrente;

        public frmTelaPrincipal()
        {
            InitializeComponent();
            comandas = new CadastroComandas();
            txtItens.BackColor = System.Drawing.SystemColors.Window;
            txtItens.Font = new Font(FontFamily.GenericMonospace, txtItens.Font.Size);
            Limpar();
        }

        private void ItemProdutos_Click(object sender, EventArgs e)
        {
            // abre a tela no modo Modal.
            new frmCadastroProdutos().ShowDialog();
            Limpar();
        }

        private void ItemIncluir_Click(object sender, EventArgs e)
        {
            new frmNovoItem().ShowDialog();
            Limpar();
        }

        private void CbComanda_SelectedIndexChanged(object sender, EventArgs e)
        {
            comandaCorrente = cbComanda.SelectedValue as Comanda;
            if (comandaCorrente != null)
            {
                txtItens.Clear();
                txtItens.Visible = true;
                btnFecharComanda.Visible = true;
                string formatoCabecalho = "{0,-6} | {1,-50} | {2,11} | {3,7}\n";
                string formato = "{0,6:0} | {1,-50} | {2,11:#.00} | {3,7:#.00}\n";
                string cabecalho = string.Format(formatoCabecalho, "Código", "Descrição", "Quantidade", "Preço");
                txtItens.AppendText(cabecalho);
                for (int i = 0; i < 83; i++)
                {
                    txtItens.AppendText("-");
                }
                txtItens.AppendText("\n");
                foreach (ItemComanda item in comandaCorrente.Itens)
                {
                    string s = string.Format(formato, item.Produto.Codigo, item.Produto.Descricao,
                        item.Quantidade, item.CalcularPreco());
                    txtItens.AppendText(s);

                }
                lbTotal.Text = string.Format("Total: R$ {0,7:0.00}", comandaCorrente.CalcularValorTotal());
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void BtnFecharComanda_Click(object sender, EventArgs e)
        {
            comandaCorrente.LimparComanda();
            Limpar();
        }

        private void Limpar()
        {
            cbComanda.DataSource = comandas.ListarAtivadas();
            cbComanda.DisplayMember = "numero";
            cbComanda.SelectedIndex = -1;
            txtItens.Clear();
            txtItens.Visible = false;
            lbTotal.Text = string.Empty;
            btnFecharComanda.Visible = false;
        }

        private void ItemComandas_Click(object sender, EventArgs e)
        {
            new frmCadastroComandas().ShowDialog();
            Limpar();
        }

        private void ItemGerenciarComandas_Click(object sender, EventArgs e)
        {
            new frmGerenciamentoComanda().ShowDialog();
            Limpar();
        }
    }
}
