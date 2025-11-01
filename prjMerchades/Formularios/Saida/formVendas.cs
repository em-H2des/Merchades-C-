using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchades
{
    public partial class formVendas : System.Windows.Forms.Form
    {
        private Label label7;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label labelCodigoCompra;
        private Button btnFinalizaCompra;
        private Button btnCancelaVenda;
        private DataGridView dataGridViewProdutosCarrinho;
        private DataGridViewTextBoxColumn ColumnDesc;
        private DataGridViewTextBoxColumn ColumnQtd;
        private DataGridViewTextBoxColumn ColumnValUni;
        private DataGridViewTextBoxColumn ColumnTotal;
        private Button btnAltQtd;
        private Button btnExcluirItem;
        private Button btnAdicionarItem;

        public formVendas()
        {
            InitializeComponent();
        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void CancelaVenda_Click(object sender, EventArgs e)
        {

        }

        private void btnFinalizaCompra_Click(object sender, EventArgs e)
        {
            formPagamento novoForm = new formPagamento();
            novoForm.Show();//Abre uma tela do formProdutos
        }

        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCodigoCompra = new System.Windows.Forms.Label();
            this.btnFinalizaCompra = new System.Windows.Forms.Button();
            this.btnCancelaVenda = new System.Windows.Forms.Button();
            this.dataGridViewProdutosCarrinho = new System.Windows.Forms.DataGridView();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAltQtd = new System.Windows.Forms.Button();
            this.btnExcluirItem = new System.Windows.Forms.Button();
            this.btnAdicionarItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(941, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 40);
            this.label7.TabIndex = 60;
            this.label7.Text = "R$ 0,00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label4.Location = new System.Drawing.Point(941, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 40);
            this.label4.TabIndex = 59;
            this.label4.Text = "R$ 0,00";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label6.Location = new System.Drawing.Point(941, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 40);
            this.label6.TabIndex = 58;
            this.label6.Text = "R$ 0,00";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(760, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 40);
            this.label3.TabIndex = 57;
            this.label3.Text = "Total Final:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(744, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 40);
            this.label1.TabIndex = 56;
            this.label1.Text = "Total Parcial:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(760, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 40);
            this.label2.TabIndex = 55;
            this.label2.Text = "Descontos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label5.Location = new System.Drawing.Point(242, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 40);
            this.label5.TabIndex = 54;
            this.label5.Text = "Código:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCodigoCompra
            // 
            this.labelCodigoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCodigoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.labelCodigoCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.labelCodigoCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCodigoCompra.Location = new System.Drawing.Point(418, 26);
            this.labelCodigoCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoCompra.Name = "labelCodigoCompra";
            this.labelCodigoCompra.Size = new System.Drawing.Size(450, 28);
            this.labelCodigoCompra.TabIndex = 53;
            this.labelCodigoCompra.Text = "xxxxxx";
            this.labelCodigoCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFinalizaCompra
            // 
            this.btnFinalizaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalizaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnFinalizaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizaCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnFinalizaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizaCompra.Location = new System.Drawing.Point(784, 484);
            this.btnFinalizaCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizaCompra.MaximumSize = new System.Drawing.Size(283, 51);
            this.btnFinalizaCompra.MinimumSize = new System.Drawing.Size(122, 36);
            this.btnFinalizaCompra.Name = "btnFinalizaCompra";
            this.btnFinalizaCompra.Size = new System.Drawing.Size(283, 51);
            this.btnFinalizaCompra.TabIndex = 52;
            this.btnFinalizaCompra.Text = "Finalizar Compra ⇉";
            this.btnFinalizaCompra.UseVisualStyleBackColor = false;
            // 
            // btnCancelaVenda
            // 
            this.btnCancelaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnCancelaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnCancelaVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaVenda.Location = new System.Drawing.Point(784, 416);
            this.btnCancelaVenda.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelaVenda.MaximumSize = new System.Drawing.Size(283, 51);
            this.btnCancelaVenda.MinimumSize = new System.Drawing.Size(139, 39);
            this.btnCancelaVenda.Name = "btnCancelaVenda";
            this.btnCancelaVenda.Size = new System.Drawing.Size(283, 51);
            this.btnCancelaVenda.TabIndex = 51;
            this.btnCancelaVenda.Text = "⇇ Cancelar Compra";
            this.btnCancelaVenda.UseVisualStyleBackColor = false;
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
            this.dataGridViewProdutosCarrinho.Location = new System.Drawing.Point(31, 108);
            this.dataGridViewProdutosCarrinho.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProdutosCarrinho.MinimumSize = new System.Drawing.Size(439, 110);
            this.dataGridViewProdutosCarrinho.Name = "dataGridViewProdutosCarrinho";
            this.dataGridViewProdutosCarrinho.RowHeadersWidth = 62;
            this.dataGridViewProdutosCarrinho.RowTemplate.Height = 28;
            this.dataGridViewProdutosCarrinho.Size = new System.Drawing.Size(709, 322);
            this.dataGridViewProdutosCarrinho.TabIndex = 50;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.HeaderText = "Descrição";
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
            // btnAltQtd
            // 
            this.btnAltQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAltQtd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnAltQtd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltQtd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnAltQtd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAltQtd.Location = new System.Drawing.Point(262, 458);
            this.btnAltQtd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAltQtd.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnAltQtd.MinimumSize = new System.Drawing.Size(112, 29);
            this.btnAltQtd.Name = "btnAltQtd";
            this.btnAltQtd.Size = new System.Drawing.Size(192, 46);
            this.btnAltQtd.TabIndex = 49;
            this.btnAltQtd.Text = "Alterar Quantidade";
            this.btnAltQtd.UseVisualStyleBackColor = false;
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnExcluirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirItem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.8F);
            this.btnExcluirItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluirItem.Location = new System.Drawing.Point(486, 458);
            this.btnExcluirItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluirItem.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnExcluirItem.MinimumSize = new System.Drawing.Size(112, 29);
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(192, 46);
            this.btnExcluirItem.TabIndex = 48;
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
            this.btnAdicionarItem.Location = new System.Drawing.Point(40, 458);
            this.btnAdicionarItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarItem.MaximumSize = new System.Drawing.Size(192, 46);
            this.btnAdicionarItem.MinimumSize = new System.Drawing.Size(112, 29);
            this.btnAdicionarItem.Name = "btnAdicionarItem";
            this.btnAdicionarItem.Size = new System.Drawing.Size(192, 46);
            this.btnAdicionarItem.TabIndex = 47;
            this.btnAdicionarItem.Text = "+ Adicionar Item";
            this.btnAdicionarItem.UseVisualStyleBackColor = false;
            // 
            // formVendas
            // 
            this.ClientSize = new System.Drawing.Size(1114, 550);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelCodigoCompra);
            this.Controls.Add(this.btnFinalizaCompra);
            this.Controls.Add(this.btnCancelaVenda);
            this.Controls.Add(this.dataGridViewProdutosCarrinho);
            this.Controls.Add(this.btnAltQtd);
            this.Controls.Add(this.btnExcluirItem);
            this.Controls.Add(this.btnAdicionarItem);
            this.Name = "formVendas";
            this.Text = "Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosCarrinho)).EndInit();
            this.ResumeLayout(false);

        }

        
    }
}
