namespace Merchades
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.tabControlSaida = new System.Windows.Forms.TabControl();
            this.tabCaixa = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDiminuiQtd = new System.Windows.Forms.Button();
            this.btnAumentaQtd = new System.Windows.Forms.Button();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.lblTotalParc = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescontos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizaCompra = new System.Windows.Forms.Button();
            this.btnCancelaVenda = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            this.dataGridViewProdutosCarrinho = new System.Windows.Forms.DataGridView();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCodigoCompra = new System.Windows.Forms.Label();
            this.tabProdutos = new System.Windows.Forms.TabPage();
            this.btnVoltarTelaInicial = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnAddItemCarrinho = new System.Windows.Forms.Button();
            this.lblBuscarProduto = new System.Windows.Forms.Label();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dataGridViewProdutosDisponíveis = new System.Windows.Forms.DataGridView();
            this.ColumnCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUniM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlSaida.SuspendLayout();
            this.tabCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).BeginInit();
            this.tabProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosDisponíveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSaida
            // 
            this.tabControlSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSaida.Controls.Add(this.tabCaixa);
            this.tabControlSaida.Controls.Add(this.tabProdutos);
            this.tabControlSaida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.tabControlSaida.HotTrack = true;
            this.tabControlSaida.Location = new System.Drawing.Point(0, 71);
            this.tabControlSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlSaida.Name = "tabControlSaida";
            this.tabControlSaida.SelectedIndex = 0;
            this.tabControlSaida.Size = new System.Drawing.Size(1533, 758);
            this.tabControlSaida.TabIndex = 0;
            // 
            // tabCaixa
            // 
            this.tabCaixa.Controls.Add(this.label7);
            this.tabCaixa.Controls.Add(this.btnDiminuiQtd);
            this.tabCaixa.Controls.Add(this.btnAumentaQtd);
            this.tabCaixa.Controls.Add(this.lblTotalFinal);
            this.tabCaixa.Controls.Add(this.lblTotalParc);
            this.tabCaixa.Controls.Add(this.label6);
            this.tabCaixa.Controls.Add(this.label8);
            this.tabCaixa.Controls.Add(this.lblDescontos);
            this.tabCaixa.Controls.Add(this.label5);
            this.tabCaixa.Controls.Add(this.label4);
            this.tabCaixa.Controls.Add(this.btnFinalizaCompra);
            this.tabCaixa.Controls.Add(this.btnCancelaVenda);
            this.tabCaixa.Controls.Add(this.btnExcluirItem);
            this.tabCaixa.Controls.Add(this.btnAdicionarItem);
            this.tabCaixa.Controls.Add(this.dataGridViewProdutosCarrinho);
            this.tabCaixa.Controls.Add(this.lblCodigoCompra);
            this.tabCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabCaixa.Location = new System.Drawing.Point(4, 59);
            this.tabCaixa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCaixa.Name = "tabCaixa";
            this.tabCaixa.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCaixa.Size = new System.Drawing.Size(1525, 695);
            this.tabCaixa.TabIndex = 0;
            this.tabCaixa.Text = "Caixa";
            this.tabCaixa.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label7.Location = new System.Drawing.Point(339, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 26);
            this.label7.TabIndex = 59;
            this.label7.Text = "Alterar Quantidade";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDiminuiQtd
            // 
            this.btnDiminuiQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDiminuiQtd.AutoSize = true;
            this.btnDiminuiQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnDiminuiQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiminuiQtd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnDiminuiQtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDiminuiQtd.Location = new System.Drawing.Point(344, 624);
            this.btnDiminuiQtd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDiminuiQtd.Name = "btnDiminuiQtd";
            this.btnDiminuiQtd.Size = new System.Drawing.Size(213, 38);
            this.btnDiminuiQtd.TabIndex = 58;
            this.btnDiminuiQtd.Text = "▼";
            this.btnDiminuiQtd.UseVisualStyleBackColor = false;
            // 
            // btnAumentaQtd
            // 
            this.btnAumentaQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAumentaQtd.AutoSize = true;
            this.btnAumentaQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAumentaQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAumentaQtd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnAumentaQtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAumentaQtd.Location = new System.Drawing.Point(344, 532);
            this.btnAumentaQtd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAumentaQtd.Name = "btnAumentaQtd";
            this.btnAumentaQtd.Size = new System.Drawing.Size(213, 38);
            this.btnAumentaQtd.TabIndex = 57;
            this.btnAumentaQtd.Text = "▲";
            this.btnAumentaQtd.UseVisualStyleBackColor = false;
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.lblTotalFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblTotalFinal.Location = new System.Drawing.Point(1239, 306);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(155, 43);
            this.lblTotalFinal.TabIndex = 56;
            this.lblTotalFinal.Text = "R$ 0,00";
            // 
            // lblTotalParc
            // 
            this.lblTotalParc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalParc.AutoSize = true;
            this.lblTotalParc.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.lblTotalParc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblTotalParc.Location = new System.Drawing.Point(1284, 211);
            this.lblTotalParc.Name = "lblTotalParc";
            this.lblTotalParc.Size = new System.Drawing.Size(155, 43);
            this.lblTotalParc.TabIndex = 55;
            this.lblTotalParc.Text = "R$ 0,00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(999, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 43);
            this.label6.TabIndex = 54;
            this.label6.Text = "Total Final:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label8.Location = new System.Drawing.Point(989, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 43);
            this.label8.TabIndex = 53;
            this.label8.Text = "Total Parcial:";
            // 
            // lblDescontos
            // 
            this.lblDescontos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescontos.AutoSize = true;
            this.lblDescontos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.lblDescontos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblDescontos.Location = new System.Drawing.Point(1251, 129);
            this.lblDescontos.Name = "lblDescontos";
            this.lblDescontos.Size = new System.Drawing.Size(155, 43);
            this.lblDescontos.TabIndex = 52;
            this.lblDescontos.Text = "R$ 0,00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label5.Location = new System.Drawing.Point(999, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 43);
            this.label5.TabIndex = 50;
            this.label5.Text = "Descontos:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(384, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 50);
            this.label4.TabIndex = 49;
            this.label4.Text = "Código:";
            // 
            // btnFinalizaCompra
            // 
            this.btnFinalizaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnFinalizaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizaCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnFinalizaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizaCompra.Location = new System.Drawing.Point(1026, 552);
            this.btnFinalizaCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinalizaCompra.MaximumSize = new System.Drawing.Size(424, 79);
            this.btnFinalizaCompra.MinimumSize = new System.Drawing.Size(183, 55);
            this.btnFinalizaCompra.Name = "btnFinalizaCompra";
            this.btnFinalizaCompra.Size = new System.Drawing.Size(393, 79);
            this.btnFinalizaCompra.TabIndex = 48;
            this.btnFinalizaCompra.Text = "Finalizar Venda ⇉";
            this.btnFinalizaCompra.UseVisualStyleBackColor = false;
            this.btnFinalizaCompra.Click += new System.EventHandler(this.btnFinalizaCompra_Click);
            // 
            // btnCancelaVenda
            // 
            this.btnCancelaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnCancelaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnCancelaVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaVenda.Location = new System.Drawing.Point(1026, 439);
            this.btnCancelaVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelaVenda.MaximumSize = new System.Drawing.Size(424, 79);
            this.btnCancelaVenda.MinimumSize = new System.Drawing.Size(208, 60);
            this.btnCancelaVenda.Name = "btnCancelaVenda";
            this.btnCancelaVenda.Size = new System.Drawing.Size(393, 79);
            this.btnCancelaVenda.TabIndex = 41;
            this.btnCancelaVenda.Text = "⇇ Cancelar Venda";
            this.btnCancelaVenda.UseVisualStyleBackColor = false;
            this.btnCancelaVenda.Click += new System.EventHandler(this.btnCancelaVenda_Click);
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnExcluirItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirItem.Location = new System.Drawing.Point(663, 561);
            this.btnExcluirItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcluirItem.MaximumSize = new System.Drawing.Size(288, 71);
            this.btnExcluirItem.MinimumSize = new System.Drawing.Size(168, 45);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(258, 65);
            this.btnExcluirItem.TabIndex = 39;
            this.btnExcluirItem.Text = "Excluir Item";
            this.btnExcluirItem.UseVisualStyleBackColor = false;
            // 
            // btnAdicionarItem
            // 
            this.btnAdicionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAdicionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnAdicionarItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdicionarItem.Location = new System.Drawing.Point(26, 561);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdicionarItem.MaximumSize = new System.Drawing.Size(288, 71);
            this.btnAdicionarItem.MinimumSize = new System.Drawing.Size(168, 45);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(258, 65);
            this.btnAdicionarItem.TabIndex = 38;
            this.btnAdicionarItem.Text = "+ Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            this.btnAdicionarItem.Click += new System.EventHandler(this.btnAdicionarItem_Click);
            // 
            // dataGridViewProdutosCarrinho
            // 
            this.dataGridViewProdutosCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutosCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDesc,
            this.ColumnQtd,
            this.ColumnValUni,
            this.ColumnTotal});
            this.dataGridViewProdutosCarrinho.Location = new System.Drawing.Point(26, 129);
            this.dataGridViewProdutosCarrinho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProdutosCarrinho.MinimumSize = new System.Drawing.Size(658, 169);
            this.dataGridViewProdutosCarrinho.Name = "dataGridViewProdutosCarrinho";
            this.dataGridViewProdutosCarrinho.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinho.RowTemplate.Height = 28;
            this.dataGridViewProdutosCarrinho.Size = new System.Drawing.Size(837, 369);
            this.dataGridViewProdutosCarrinho.TabIndex = 37;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.HeaderText = "Produto";
            this.ColumnDesc.MinimumWidth = 8;
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.Width = 150;
            // 
            // ColumnQtd
            // 
            this.ColumnQtd.HeaderText = "Quantidade";
            this.ColumnQtd.MinimumWidth = 8;
            this.ColumnQtd.Name = "ColumnQtd";
            this.ColumnQtd.Width = 150;
            // 
            // ColumnValUni
            // 
            this.ColumnValUni.HeaderText = "ValorUnitário";
            this.ColumnValUni.MinimumWidth = 8;
            this.ColumnValUni.Name = "ColumnValUni";
            this.ColumnValUni.Width = 150;
            // 
            // ColumnTotal
            // 
            this.ColumnTotal.HeaderText = "Total";
            this.ColumnTotal.MinimumWidth = 8;
            this.ColumnTotal.Name = "ColumnTotal";
            this.ColumnTotal.Width = 150;
            // 
            // lblCodigoCompra
            // 
            this.lblCodigoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.lblCodigoCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.lblCodigoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigoCompra.Location = new System.Drawing.Point(656, 38);
            this.lblCodigoCompra.Name = "lblCodigoCompra";
            this.lblCodigoCompra.Size = new System.Drawing.Size(675, 42);
            this.lblCodigoCompra.TabIndex = 36;
            this.lblCodigoCompra.Text = "xxxxxx";
            this.lblCodigoCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabProdutos
            // 
            this.tabProdutos.Controls.Add(this.btnVoltarTelaInicial);
            this.tabProdutos.Controls.Add(this.label3);
            this.tabProdutos.Controls.Add(this.label2);
            this.tabProdutos.Controls.Add(this.label1);
            this.tabProdutos.Controls.Add(this.btnAplicar);
            this.tabProdutos.Controls.Add(this.btnAddItemCarrinho);
            this.tabProdutos.Controls.Add(this.lblBuscarProduto);
            this.tabProdutos.Controls.Add(this.cmbOrdenar);
            this.tabProdutos.Controls.Add(this.cmbFiltro);
            this.tabProdutos.Controls.Add(this.dataGridViewProdutosDisponíveis);
            this.tabProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.tabProdutos.Location = new System.Drawing.Point(4, 59);
            this.tabProdutos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProdutos.Name = "tabProdutos";
            this.tabProdutos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabProdutos.Size = new System.Drawing.Size(1525, 695);
            this.tabProdutos.TabIndex = 1;
            this.tabProdutos.Text = "Estoque";
            this.tabProdutos.UseVisualStyleBackColor = true;
            // 
            // btnVoltarTelaInicial
            // 
            this.btnVoltarTelaInicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoltarTelaInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnVoltarTelaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltarTelaInicial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnVoltarTelaInicial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltarTelaInicial.Location = new System.Drawing.Point(1230, 41);
            this.btnVoltarTelaInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltarTelaInicial.MaximumSize = new System.Drawing.Size(424, 79);
            this.btnVoltarTelaInicial.MinimumSize = new System.Drawing.Size(183, 55);
            this.btnVoltarTelaInicial.Name = "btnVoltarTelaInicial";
            this.btnVoltarTelaInicial.Size = new System.Drawing.Size(285, 58);
            this.btnVoltarTelaInicial.TabIndex = 45;
            this.btnVoltarTelaInicial.Text = "↺  Voltar";
            this.btnVoltarTelaInicial.UseVisualStyleBackColor = false;
            this.btnVoltarTelaInicial.Click += new System.EventHandler(this.btnVoltarTelaInicial_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label3.Location = new System.Drawing.Point(960, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 61);
            this.label3.TabIndex = 44;
            this.label3.Text = "Ordenar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(962, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 61);
            this.label2.TabIndex = 43;
            this.label2.Text = "Filtro:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label1.Location = new System.Drawing.Point(960, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 61);
            this.label1.TabIndex = 42;
            this.label1.Text = "Buscar:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnAplicar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAplicar.Location = new System.Drawing.Point(1059, 494);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAplicar.MaximumSize = new System.Drawing.Size(288, 71);
            this.btnAplicar.MinimumSize = new System.Drawing.Size(111, 41);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(288, 71);
            this.btnAplicar.TabIndex = 41;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            // 
            // btnAddItemCarrinho
            // 
            this.btnAddItemCarrinho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItemCarrinho.AutoSize = true;
            this.btnAddItemCarrinho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAddItemCarrinho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItemCarrinho.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnAddItemCarrinho.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddItemCarrinho.Location = new System.Drawing.Point(966, 585);
            this.btnAddItemCarrinho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItemCarrinho.MinimumSize = new System.Drawing.Size(111, 41);
            this.btnAddItemCarrinho.Name = "btnAddItemCarrinho";
            this.btnAddItemCarrinho.Size = new System.Drawing.Size(381, 71);
            this.btnAddItemCarrinho.TabIndex = 40;
            this.btnAddItemCarrinho.Text = "+ Adicionar à venda";
            this.btnAddItemCarrinho.UseVisualStyleBackColor = false;
            // 
            // lblBuscarProduto
            // 
            this.lblBuscarProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuscarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.lblBuscarProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.lblBuscarProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblBuscarProduto.Location = new System.Drawing.Point(960, 181);
            this.lblBuscarProduto.Name = "lblBuscarProduto";
            this.lblBuscarProduto.Size = new System.Drawing.Size(518, 42);
            this.lblBuscarProduto.TabIndex = 38;
            this.lblBuscarProduto.Text = "xxxxxx";
            this.lblBuscarProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.cmbOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbOrdenar.Font = new System.Drawing.Font("Arial", 13.8F);
            this.cmbOrdenar.ForeColor = System.Drawing.Color.White;
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Location = new System.Drawing.Point(962, 431);
            this.cmbOrdenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(517, 34);
            this.cmbOrdenar.TabIndex = 37;
            this.cmbOrdenar.Text = "Selecione como deseja ordenar ↓";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFiltro.Font = new System.Drawing.Font("Arial", 13.8F);
            this.cmbFiltro.ForeColor = System.Drawing.Color.White;
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(960, 301);
            this.cmbFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(517, 34);
            this.cmbFiltro.TabIndex = 36;
            this.cmbFiltro.Text = "Selecione como deseja filtrar ↓";
            // 
            // dataGridViewProdutosDisponíveis
            // 
            this.dataGridViewProdutosDisponíveis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProdutosDisponíveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosDisponíveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCod,
            this.ColumnNome,
            this.ColumnUniM,
            this.ColumnCat,
            this.ColumnPreco,
            this.ColumnStatus,
            this.ColumnEstoque});
            this.dataGridViewProdutosDisponíveis.Location = new System.Drawing.Point(3, 41);
            this.dataGridViewProdutosDisponíveis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProdutosDisponíveis.Name = "dataGridViewProdutosDisponíveis";
            this.dataGridViewProdutosDisponíveis.RowHeadersWidth = 62;
            this.dataGridViewProdutosDisponíveis.RowTemplate.Height = 28;
            this.dataGridViewProdutosDisponíveis.Size = new System.Drawing.Size(883, 634);
            this.dataGridViewProdutosDisponíveis.TabIndex = 8;
            // 
            // ColumnCod
            // 
            this.ColumnCod.HeaderText = "Código";
            this.ColumnCod.MinimumWidth = 8;
            this.ColumnCod.Name = "ColumnCod";
            this.ColumnCod.Width = 150;
            // 
            // ColumnNome
            // 
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.MinimumWidth = 8;
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.Width = 150;
            // 
            // ColumnUniM
            // 
            this.ColumnUniM.HeaderText = "UnidadeMedida";
            this.ColumnUniM.MinimumWidth = 8;
            this.ColumnUniM.Name = "ColumnUniM";
            this.ColumnUniM.Width = 150;
            // 
            // ColumnCat
            // 
            this.ColumnCat.HeaderText = "Categoria";
            this.ColumnCat.MinimumWidth = 8;
            this.ColumnCat.Name = "ColumnCat";
            this.ColumnCat.Width = 150;
            // 
            // ColumnPreco
            // 
            this.ColumnPreco.HeaderText = "PrecoVenda";
            this.ColumnPreco.MinimumWidth = 8;
            this.ColumnPreco.Name = "ColumnPreco";
            this.ColumnPreco.Width = 150;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.MinimumWidth = 8;
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.Width = 150;
            // 
            // ColumnEstoque
            // 
            this.ColumnEstoque.HeaderText = "EstoqueAtual";
            this.ColumnEstoque.MinimumWidth = 8;
            this.ColumnEstoque.Name = "ColumnEstoque";
            this.ColumnEstoque.Width = 150;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::prjMerchades.Properties.Resources.logoMerchades1;
            this.pictureBox1.Location = new System.Drawing.Point(1178, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1533, 826);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControlSaida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.formMenu_Load);
            this.tabControlSaida.ResumeLayout(false);
            this.tabCaixa.ResumeLayout(false);
            this.tabCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).EndInit();
            this.tabProdutos.ResumeLayout(false);
            this.tabProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosDisponíveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSaida;
        private System.Windows.Forms.TabPage tabCaixa;
        private System.Windows.Forms.TabPage tabProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCodigoCompra;
        private System.Windows.Forms.DataGridView dataGridViewProdutosCarrinho;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnAdicionarItem;
        private System.Windows.Forms.Button btnCancelaVenda;
        private System.Windows.Forms.DataGridView dataGridViewProdutosDisponíveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUniM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstoque;
        private System.Windows.Forms.Label lblBuscarProduto;
        private System.Windows.Forms.ComboBox cmbOrdenar;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnAddItemCarrinho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltarTelaInicial;
        private System.Windows.Forms.Button btnFinalizaCompra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescontos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalParc;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Button btnAumentaQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDiminuiQtd;
    }
}