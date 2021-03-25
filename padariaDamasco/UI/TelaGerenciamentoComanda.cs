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
    public partial class frmGerenciamentoComanda : Form
    {
        private CadastroComandas comandas;
        private Comanda comandaCorrente;

        public frmGerenciamentoComanda()
        {
            InitializeComponent();
            comandas = new CadastroComandas();
            // inicializa o DataGridView
            dgvItens.ColumnCount = 3;
            dgvItens.Columns[0].Name = "Item";
            dgvItens.Columns[1].Name = "Produto";
            dgvItens.Columns[2].Name = "Quantidade";
            dgvItens.Columns["Item"].Visible = false;
            // inicializa o combo
            cmbComandas.DataSource = comandas.ListarComItens();
            cmbComandas.DisplayMember = "numero";
            cmbComandas.SelectedIndex = -1;
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            string valor = InputBox("Item de Comanda", "Informe a nova quantidade:");
            if (valor != null)
            {
                int qtde = Convert.ToInt32(valor);
                DataGridViewRow row = dgvItens.SelectedRows[0];
                int item = Convert.ToInt32(row.Cells["Item"].Value);
                comandaCorrente.AtualizarItem(item, qtde);
                AtualizarTabela();

            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvItens.SelectedRows[0];
            int item = Convert.ToInt32(row.Cells["Item"].Value);
            comandaCorrente.ExcluirItem(item);
            AtualizarTabela();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmbComandas_SelectedIndexChanged(object sender, EventArgs e)
        {
            comandaCorrente = cmbComandas.SelectedValue as Comanda;
            if (comandaCorrente != null)
            {
                AtualizarTabela();
            }
            else
            {
                dgvItens.Rows.Clear();
                dgvItens.Refresh();
            }
        }

        private void AtualizarTabela()
        {
            dgvItens.Rows.Clear();
            int n = 0;
            foreach (ItemComanda item in comandaCorrente.Itens)
            {
                // popula o data grid view
                string[] linha = new string[3];
                linha[0] = n.ToString();
                linha[1] = item.Produto.Descricao;
                linha[2] = item.Quantidade.ToString();
                dgvItens.Rows.Add(linha);
                n++;
            }
            dgvItens.Refresh();
        }

        private static String InputBox(string title, string promptText)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = string.Empty;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                return textBox.Text;
            }
            else
            {
                return null;
            }
        }
    }
}
