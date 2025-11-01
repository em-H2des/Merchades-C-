namespace Merchades
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTrocoVenda = new System.Windows.Forms.Label();
            this.lblValorPagoVenda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnCancelaVenda = new System.Windows.Forms.Button();
            this.btnCancelaOperacao = new System.Windows.Forms.Button();
            this.btnConfirmaCompra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numEstoqueAddProduto = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueAddProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // cmbFormaPagamento
            // 
            this.cmbFormaPagamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFormaPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.cmbFormaPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaPagamento.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaPagamento.ForeColor = System.Drawing.Color.White;
            this.cmbFormaPagamento.FormattingEnabled = true;
            this.cmbFormaPagamento.Location = new System.Drawing.Point(849, 226);
            this.cmbFormaPagamento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFormaPagamento.Name = "cmbFormaPagamento";
            this.cmbFormaPagamento.Size = new System.Drawing.Size(517, 34);
            this.cmbFormaPagamento.TabIndex = 22;
            this.cmbFormaPagamento.Text = "Dinheiro, Cartão (Cred/Deb), PIX ↓";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numEstoqueAddProduto);
            this.groupBox1.Controls.Add(this.lblTrocoVenda);
            this.groupBox1.Controls.Add(this.lblValorPagoVenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.btnCancelaVenda);
            this.groupBox1.Controls.Add(this.btnCancelaOperacao);
            this.groupBox1.Controls.Add(this.cmbFormaPagamento);
            this.groupBox1.Controls.Add(this.btnConfirmaCompra);
            this.groupBox1.Location = new System.Drawing.Point(0, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1680, 754);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // lblTrocoVenda
            // 
            this.lblTrocoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrocoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.lblTrocoVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.lblTrocoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblTrocoVenda.Location = new System.Drawing.Point(1102, 462);
            this.lblTrocoVenda.Name = "lblTrocoVenda";
            this.lblTrocoVenda.Size = new System.Drawing.Size(213, 61);
            this.lblTrocoVenda.TabIndex = 39;
            this.lblTrocoVenda.Text = "R$ 0,00";
            this.lblTrocoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorPagoVenda
            // 
            this.lblValorPagoVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorPagoVenda.BackColor = System.Drawing.SystemColors.Window;
            this.lblValorPagoVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.lblValorPagoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblValorPagoVenda.Location = new System.Drawing.Point(468, 462);
            this.lblValorPagoVenda.Name = "lblValorPagoVenda";
            this.lblValorPagoVenda.Size = new System.Drawing.Size(213, 61);
            this.lblValorPagoVenda.TabIndex = 38;
            this.lblValorPagoVenda.Text = "R$ 0,00";
            this.lblValorPagoVenda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(840, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(561, 61);
            this.label4.TabIndex = 37;
            this.label4.Text = "Troco:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1673, 139);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tela de Pagamento";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(170, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(561, 61);
            this.label2.TabIndex = 35;
            this.label2.Text = "Valor Pago:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.SystemColors.Window;
            this.label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label.Location = new System.Drawing.Point(231, 208);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(484, 50);
            this.label.TabIndex = 33;
            this.label.Text = "Forma de Pagamento:";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelaVenda
            // 
            this.btnCancelaVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelaVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.btnCancelaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnCancelaVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaVenda.Location = new System.Drawing.Point(39, 646);
            this.btnCancelaVenda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelaVenda.MaximumSize = new System.Drawing.Size(424, 79);
            this.btnCancelaVenda.MinimumSize = new System.Drawing.Size(208, 60);
            this.btnCancelaVenda.Name = "btnCancelaVenda";
            this.btnCancelaVenda.Size = new System.Drawing.Size(424, 79);
            this.btnCancelaVenda.TabIndex = 28;
            this.btnCancelaVenda.Text = "⇇ Cancelar Venda";
            this.btnCancelaVenda.UseVisualStyleBackColor = false;
            this.btnCancelaVenda.Click += new System.EventHandler(this.btnCancelaVenda_Click);
            // 
            // btnCancelaOperacao
            // 
            this.btnCancelaOperacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelaOperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnCancelaOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelaOperacao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnCancelaOperacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelaOperacao.Location = new System.Drawing.Point(657, 646);
            this.btnCancelaOperacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelaOperacao.MaximumSize = new System.Drawing.Size(424, 79);
            this.btnCancelaOperacao.MinimumSize = new System.Drawing.Size(183, 55);
            this.btnCancelaOperacao.Name = "btnCancelaOperacao";
            this.btnCancelaOperacao.Size = new System.Drawing.Size(424, 79);
            this.btnCancelaOperacao.TabIndex = 30;
            this.btnCancelaOperacao.Text = "Cancelar Operação";
            this.btnCancelaOperacao.UseVisualStyleBackColor = false;
            this.btnCancelaOperacao.Click += new System.EventHandler(this.btnCancelaOperacao_Click);
            // 
            // btnConfirmaCompra
            // 
            this.btnConfirmaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(213)))), ((int)(((byte)(134)))));
            this.btnConfirmaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 17F);
            this.btnConfirmaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmaCompra.Location = new System.Drawing.Point(1191, 646);
            this.btnConfirmaCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmaCompra.MinimumSize = new System.Drawing.Size(183, 55);
            this.btnConfirmaCompra.Name = "btnConfirmaCompra";
            this.btnConfirmaCompra.Size = new System.Drawing.Size(424, 79);
            this.btnConfirmaCompra.TabIndex = 29;
            this.btnConfirmaCompra.Text = "Confirmar Pagamento ⇉";
            this.btnConfirmaCompra.UseVisualStyleBackColor = false;
            this.btnConfirmaCompra.Click += new System.EventHandler(this.btnConfirmaCompra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = global::prjMerchades.Properties.Resources.logoMerchades;
            this.pictureBox1.Location = new System.Drawing.Point(243, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1680, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1124, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25.8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.label7.Location = new System.Drawing.Point(234, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 61);
            this.label7.TabIndex = 41;
            this.label7.Text = "Qtd Parcelas:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numEstoqueAddProduto
            // 
            this.numEstoqueAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numEstoqueAddProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.numEstoqueAddProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numEstoqueAddProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F);
            this.numEstoqueAddProduto.ForeColor = System.Drawing.Color.White;
            this.numEstoqueAddProduto.Location = new System.Drawing.Point(848, 302);
            this.numEstoqueAddProduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numEstoqueAddProduto.Name = "numEstoqueAddProduto";
            this.numEstoqueAddProduto.Size = new System.Drawing.Size(518, 38);
            this.numEstoqueAddProduto.TabIndex = 40;
            // 
            // formPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1680, 880);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formPagamento";
            this.Text = "Tela de Pagamento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEstoqueAddProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFormaPagamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelaVenda;
        private System.Windows.Forms.Button btnConfirmaCompra;
        private System.Windows.Forms.Button btnCancelaOperacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTrocoVenda;
        private System.Windows.Forms.Label lblValorPagoVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numEstoqueAddProduto;
    }
}