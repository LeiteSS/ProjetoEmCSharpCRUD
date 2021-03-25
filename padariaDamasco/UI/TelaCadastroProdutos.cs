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
    public partial class frmCadastroProdutos : Form
    {
        private CadastroProdutos cadastro;

        public frmCadastroProdutos()
        {
            InitializeComponent();
            cadastro = new CadastroProdutos();
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            dgProdutos.DataSource = cadastro.Listar().Tables[0];
            dgProdutos.Columns["Preco"].DefaultCellStyle.Format = "N2";
            LimparCampos();
        }

        private Produto CriarProduto()
        {
            // TODO: validar os campos
            int codigo = Convert.ToInt32(txtCodigo.Text);
            string desc = txtDescricao.Text;
            double preco = Convert.ToDouble(txtPreco.Text);
            return new Produto(codigo, desc, preco);
        }

        private void LimparCampos()
        {
            txtCodigo.Enabled = true;
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPreco.Text = string.Empty;
            btnInserir.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            dgProdutos.ClearSelection();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            Produto p = CriarProduto();
            bool ok = cadastro.Inserir(p);
            if (ok)
            {
                AtualizarTabela();
            }
            else
            {
                MessageBox.Show("Código de produto já existe!");
            }
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Produto p = CriarProduto();
            cadastro.Atualizar(p);
            AtualizarTabela();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCodigo.Text);
            bool ok = cadastro.Excluir(codigo);
            if (ok)
            {
                AtualizarTabela();
            }
            else
            {
                MessageBox.Show("Erro ao excluir o produto.");
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void DgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgProdutos.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells[0].Value + string.Empty;
                txtCodigo.Enabled = false;
                txtDescricao.Text = row.Cells[1].Value + string.Empty;
                txtPreco.Text = row.Cells[2].Value + string.Empty;
                btnInserir.Enabled = false;
                btnAlterar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
