namespace prjMerchades.Formularios.Financeiro
{
    partial class frmRelFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelFinanceiro));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl_Financeiro = new System.Windows.Forms.TabControl();
            this.tabPage_NF = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Linha2 = new System.Windows.Forms.Label();
            this.tabPage_Divida = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_CompraAntg = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.btnConfirmaCompra = new System.Windows.Forms.Button();
            this.tabControl_Financeiro.SuspendLayout();
            this.tabPage_NF.SuspendLayout();
            this.tabPage_Divida.SuspendLayout();
            this.tabPage_CompraAntg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "Relatório Financeiro ";
            // 
            // tabControl_Financeiro
            // 
            this.tabControl_Financeiro.Controls.Add(this.tabPage_NF);
            this.tabControl_Financeiro.Controls.Add(this.tabPage_Divida);
            this.tabControl_Financeiro.Controls.Add(this.tabPage_CompraAntg);
            this.tabControl_Financeiro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl_Financeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Financeiro.Location = new System.Drawing.Point(0, 114);
            this.tabControl_Financeiro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl_Financeiro.Name = "tabControl_Financeiro";
            this.tabControl_Financeiro.SelectedIndex = 0;
            this.tabControl_Financeiro.Size = new System.Drawing.Size(1640, 935);
            this.tabControl_Financeiro.TabIndex = 5;
            this.tabControl_Financeiro.SelectedIndexChanged += new System.EventHandler(this.tabControl_Financeiro_SelectedIndexChanged);
            // 
            // tabPage_NF
            // 
            this.tabPage_NF.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_NF.Controls.Add(this.reportViewer1);
            this.tabPage_NF.Controls.Add(this.comboBox2);
            this.tabPage_NF.Controls.Add(this.label3);
            this.tabPage_NF.Controls.Add(this.lbl_Linha2);
            this.tabPage_NF.Location = new System.Drawing.Point(4, 34);
            this.tabPage_NF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_NF.Name = "tabPage_NF";
            this.tabPage_NF.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_NF.Size = new System.Drawing.Size(1632, 897);
            this.tabPage_NF.TabIndex = 0;
            this.tabPage_NF.Text = "Gastos";
            this.tabPage_NF.Click += new System.EventHandler(this.tabPage_NF_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(4, 102);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1614, 777);
            this.reportViewer1.TabIndex = 42;
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox2.Location = new System.Drawing.Point(364, 23);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 33);
            this.comboBox2.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Selecione o mês desejado :";
            // 
            // lbl_Linha2
            // 
            this.lbl_Linha2.AutoSize = true;
            this.lbl_Linha2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Linha2.Location = new System.Drawing.Point(38, 714);
            this.lbl_Linha2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Linha2.Name = "lbl_Linha2";
            this.lbl_Linha2.Size = new System.Drawing.Size(1380, 25);
            this.lbl_Linha2.TabIndex = 34;
            this.lbl_Linha2.Text = "_________________________________________________________________________________" +
    "_________________________________";
            // 
            // tabPage_Divida
            // 
            this.tabPage_Divida.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_Divida.Controls.Add(this.reportViewer2);
            this.tabPage_Divida.Controls.Add(this.comboBox1);
            this.tabPage_Divida.Controls.Add(this.label2);
            this.tabPage_Divida.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Divida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Divida.Name = "tabPage_Divida";
            this.tabPage_Divida.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_Divida.Size = new System.Drawing.Size(1632, 897);
            this.tabPage_Divida.TabIndex = 1;
            this.tabPage_Divida.Text = "Vendas";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Location = new System.Drawing.Point(4, 102);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1614, 777);
            this.reportViewer2.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox1.Location = new System.Drawing.Point(364, 23);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 33);
            this.comboBox1.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Selecione o mês desejado :";
            // 
            // tabPage_CompraAntg
            // 
            this.tabPage_CompraAntg.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage_CompraAntg.Controls.Add(this.reportViewer3);
            this.tabPage_CompraAntg.Controls.Add(this.comboBox3);
            this.tabPage_CompraAntg.Controls.Add(this.label4);
            this.tabPage_CompraAntg.Location = new System.Drawing.Point(4, 34);
            this.tabPage_CompraAntg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_CompraAntg.Name = "tabPage_CompraAntg";
            this.tabPage_CompraAntg.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage_CompraAntg.Size = new System.Drawing.Size(1632, 897);
            this.tabPage_CompraAntg.TabIndex = 2;
            this.tabPage_CompraAntg.Text = "Geral";
            // 
            // reportViewer3
            // 
            this.reportViewer3.Location = new System.Drawing.Point(4, 102);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(1614, 777);
            this.reportViewer3.TabIndex = 43;
            // 
            // comboBox3
            // 
            this.comboBox3.AllowDrop = true;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox3.Location = new System.Drawing.Point(364, 23);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(158, 33);
            this.comboBox3.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Selecione o mês desejado :";
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Logo.Image")));
            this.picBox_Logo.Location = new System.Drawing.Point(1446, 8);
            this.picBox_Logo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(150, 134);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 7;
            this.picBox_Logo.TabStop = false;
            // 
            // btnConfirmaCompra
            // 
            this.btnConfirmaCompra.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnConfirmaCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(28)))));
            this.btnConfirmaCompra.FlatAppearance.BorderSize = 0;
            this.btnConfirmaCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaCompra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmaCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmaCompra.Location = new System.Drawing.Point(1194, 17);
            this.btnConfirmaCompra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmaCompra.MinimumSize = new System.Drawing.Size(183, 55);
            this.btnConfirmaCompra.Name = "btnConfirmaCompra";
            this.btnConfirmaCompra.Size = new System.Drawing.Size(183, 55);
            this.btnConfirmaCompra.TabIndex = 31;
            this.btnConfirmaCompra.Text = "Deslogar";
            this.btnConfirmaCompra.UseVisualStyleBackColor = false;
            // 
            // frmRelFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1640, 1049);
            this.Controls.Add(this.btnConfirmaCompra);
            this.Controls.Add(this.picBox_Logo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl_Financeiro);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRelFinanceiro";
            this.Text = "Relatórios Financeiros";
            this.Load += new System.EventHandler(this.frmRelFinanceiro_Load);
            this.tabControl_Financeiro.ResumeLayout(false);
            this.tabPage_NF.ResumeLayout(false);
            this.tabPage_NF.PerformLayout();
            this.tabPage_Divida.ResumeLayout(false);
            this.tabPage_Divida.PerformLayout();
            this.tabPage_CompraAntg.ResumeLayout(false);
            this.tabPage_CompraAntg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl_Financeiro;
        private System.Windows.Forms.TabPage tabPage_NF;
        private System.Windows.Forms.Label lbl_Linha2;
        private System.Windows.Forms.TabPage tabPage_Divida;
        private System.Windows.Forms.TabPage tabPage_CompraAntg;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.Button btnConfirmaCompra;
    }
}