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
    public partial class frmCadastroComandas : Form
    {
        private CadastroComandas cadastro;

        public frmCadastroComandas()
        {
            InitializeComponent();
            cadastro = new CadastroComandas();
            // carrega o combo de situação com os valores
            cmbSituacao.Items.Add("Ativada");
            cmbSituacao.Items.Add("Desativada");
            AtualizarTabela();
        }

        private void AtualizarTabela()
        {
            dgvComandas.DataSource = cadastro.ListarTodas();
            dgvComandas.Columns["Numero"].HeaderText = "Código";
            dgvComandas.Columns["Situacao"].HeaderText = "Situacao";
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNumero.Enabled = true;
            txtNumero.Text = string.Empty;
            cmbSituacao.SelectedIndex = -1;
            btnInserir.Enabled = true;
            btnAtualizar.Enabled = false;
            dgvComandas.ClearSelection();
        }

        private Comanda CriarComanda()
        {
            int ativada;
            // TODO: validar os campos
            int numero = Convert.ToInt32(txtNumero.Text);
            string situacao = cmbSituacao.SelectedText;
            if(situacao == "Ativada")
            {
                ativada = 1;
            }
            else
            {
                ativada = 0;
            }
            return new Comanda(numero, situacao, ativada);
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            Comanda c = CriarComanda();
            cadastro.Inserir(c);
            AtualizarTabela();
        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Comanda c = CriarComanda();
            cadastro.Atualizar(c);
            AtualizarTabela();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DgvComandas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvComandas.Rows[e.RowIndex];
                txtNumero.Text = row.Cells[0].Value + string.Empty;
                txtNumero.Enabled = false;
                cmbSituacao.SelectedText = (Convert.ToString(row.Cells[1].Value));
                btnInserir.Enabled = false;
                btnAtualizar.Enabled = true;
            }
        }
    }
}
