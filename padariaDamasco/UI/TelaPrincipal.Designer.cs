namespace padariaDamasco
{
    partial class frmTelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.itemProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemGerenciarComandas = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemIncluir = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbComanda = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtItens = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnFecharComanda = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadastro,
            this.comandaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemCadastro
            // 
            this.itemCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemProdutos,
            this.itemComandas});
            this.itemCadastro.Name = "itemCadastro";
            this.itemCadastro.Size = new System.Drawing.Size(66, 20);
            this.itemCadastro.Text = "Cadastro";
            // 
            // itemProdutos
            // 
            this.itemProdutos.Name = "itemProdutos";
            this.itemProdutos.Size = new System.Drawing.Size(180, 22);
            this.itemProdutos.Text = "Produtos";
            this.itemProdutos.Click += new System.EventHandler(this.ItemProdutos_Click);
            // 
            // itemComandas
            // 
            this.itemComandas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemGerenciarComandas});
            this.itemComandas.Name = "itemComandas";
            this.itemComandas.Size = new System.Drawing.Size(180, 22);
            this.itemComandas.Text = "Comandas";
            this.itemComandas.Click += new System.EventHandler(this.ItemComandas_Click);
            // 
            // itemGerenciarComandas
            // 
            this.itemGerenciarComandas.Name = "itemGerenciarComandas";
            this.itemGerenciarComandas.Size = new System.Drawing.Size(184, 22);
            this.itemGerenciarComandas.Text = "Gerenciar Comandas";
            this.itemGerenciarComandas.Click += new System.EventHandler(this.ItemGerenciarComandas_Click);
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemIncluir});
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.comandaToolStripMenuItem.Text = "Comanda";
            // 
            // itemIncluir
            // 
            this.itemIncluir.Name = "itemIncluir";
            this.itemIncluir.Size = new System.Drawing.Size(180, 22);
            this.itemIncluir.Text = "Incluir Item";
            this.itemIncluir.Click += new System.EventHandler(this.ItemIncluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Comanda:";
            // 
            // cbComanda
            // 
            this.cbComanda.FormattingEnabled = true;
            this.cbComanda.Location = new System.Drawing.Point(73, 36);
            this.cbComanda.Name = "cbComanda";
            this.cbComanda.Size = new System.Drawing.Size(121, 21);
            this.cbComanda.TabIndex = 2;
            this.cbComanda.SelectedIndexChanged += new System.EventHandler(this.CbComanda_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(209, 34);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // txtItens
            // 
            this.txtItens.Location = new System.Drawing.Point(15, 74);
            this.txtItens.Multiline = true;
            this.txtItens.Name = "txtItens";
            this.txtItens.ReadOnly = true;
            this.txtItens.Size = new System.Drawing.Size(593, 306);
            this.txtItens.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(56, 387);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 6;
            // 
            // btnFecharComanda
            // 
            this.btnFecharComanda.Location = new System.Drawing.Point(448, 388);
            this.btnFecharComanda.Name = "btnFecharComanda";
            this.btnFecharComanda.Size = new System.Drawing.Size(160, 23);
            this.btnFecharComanda.TabIndex = 7;
            this.btnFecharComanda.Text = "Fechar Comanda";
            this.btnFecharComanda.UseVisualStyleBackColor = true;
            this.btnFecharComanda.Click += new System.EventHandler(this.BtnFecharComanda_Click);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 423);
            this.Controls.Add(this.btnFecharComanda);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtItens);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbComanda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria Damasco";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemCadastro;
        private System.Windows.Forms.ToolStripMenuItem itemProdutos;
        private System.Windows.Forms.ToolStripMenuItem itemComandas;
        private System.Windows.Forms.ToolStripMenuItem itemGerenciarComandas;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbComanda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtItens;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnFecharComanda;
    }
}

