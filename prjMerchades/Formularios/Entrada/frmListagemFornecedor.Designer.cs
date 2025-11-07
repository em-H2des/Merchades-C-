namespace prjMerchades.Formularios.Entrada
{
    partial class frmListagemFornecedor
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemFornecedor));
            this.ReportViewerFornec = new Microsoft.Reporting.WinForms.ReportViewer();
            this.picBox_Header = new System.Windows.Forms.PictureBox();
            this.lbl_FiltrarPor = new System.Windows.Forms.Label();
            this.txtBox_TxtFiltro = new System.Windows.Forms.TextBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            this.cmbColunas = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblColunas = new System.Windows.Forms.Label();
            this.fORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDadosEntrada = new prjMerchades.Dados.dsDadosEntrada();
            this.fORNECEDORTableAdapter = new prjMerchades.Dados.dsDadosEntradaTableAdapters.FORNECEDORTableAdapter();
            this.cOLUNASFORNECEDORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOLUNASFORNECEDORTableAdapter = new prjMerchades.Dados.dsDadosEntradaTableAdapters.COLUNASFORNECEDORTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOLUNASFORNECEDORBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerFornec
            // 
            this.ReportViewerFornec.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource2.Name = "DadosFornec";
            reportDataSource2.Value = this.fORNECEDORBindingSource;
            this.ReportViewerFornec.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewerFornec.LocalReport.ReportEmbeddedResource = "prjMerchades.Relatorios.RelatorioFornecedores.rdlc";
            this.ReportViewerFornec.Location = new System.Drawing.Point(0, 220);
            this.ReportViewerFornec.Name = "ReportViewerFornec";
            this.ReportViewerFornec.ServerReport.BearerToken = null;
            this.ReportViewerFornec.Size = new System.Drawing.Size(1174, 394);
            this.ReportViewerFornec.TabIndex = 0;
            // 
            // picBox_Header
            // 
            this.picBox_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.picBox_Header.Location = new System.Drawing.Point(0, -3);
            this.picBox_Header.Name = "picBox_Header";
            this.picBox_Header.Size = new System.Drawing.Size(1154, 139);
            this.picBox_Header.TabIndex = 5;
            this.picBox_Header.TabStop = false;
            // 
            // lbl_FiltrarPor
            // 
            this.lbl_FiltrarPor.AutoSize = true;
            this.lbl_FiltrarPor.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_FiltrarPor.Location = new System.Drawing.Point(399, 166);
            this.lbl_FiltrarPor.Name = "lbl_FiltrarPor";
            this.lbl_FiltrarPor.Size = new System.Drawing.Size(127, 31);
            this.lbl_FiltrarPor.TabIndex = 15;
            this.lbl_FiltrarPor.Text = "Filtrar Por:";
            // 
            // txtBox_TxtFiltro
            // 
            this.txtBox_TxtFiltro.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TxtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtBox_TxtFiltro.Location = new System.Drawing.Point(745, 166);
            this.txtBox_TxtFiltro.Multiline = true;
            this.txtBox_TxtFiltro.Name = "txtBox_TxtFiltro";
            this.txtBox_TxtFiltro.Size = new System.Drawing.Size(263, 31);
            this.txtBox_TxtFiltro.TabIndex = 17;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltro.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Que começa com",
            "Que contém",
            "Que termina com"});
            this.cmbFiltro.Location = new System.Drawing.Point(522, 163);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(217, 35);
            this.cmbFiltro.TabIndex = 18;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbBox_Filtro_SelectedIndexChanged);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.lbl_titulo.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_titulo.Location = new System.Drawing.Point(35, 35);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(655, 69);
            this.lbl_titulo.TabIndex = 41;
            this.lbl_titulo.Text = "Listagem de Fornecedores";
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.picBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Logo.Image")));
            this.picBox_Logo.Location = new System.Drawing.Point(1021, 26);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(100, 87);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 42;
            this.picBox_Logo.TabStop = false;
            // 
            // cmbColunas
            // 
            this.cmbColunas.DataSource = this.cOLUNASFORNECEDORBindingSource;
            this.cmbColunas.DisplayMember = "COLUMN_NAME";
            this.cmbColunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColunas.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColunas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.cmbColunas.FormattingEnabled = true;
            this.cmbColunas.Location = new System.Drawing.Point(117, 163);
            this.cmbColunas.Name = "cmbColunas";
            this.cmbColunas.Size = new System.Drawing.Size(279, 35);
            this.cmbColunas.TabIndex = 43;
            this.cmbColunas.ValueMember = "COLUMN_NAME";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFiltrar.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(1014, 165);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(122, 31);
            this.btnFiltrar.TabIndex = 44;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblColunas
            // 
            this.lblColunas.AutoSize = true;
            this.lblColunas.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColunas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lblColunas.Location = new System.Drawing.Point(13, 167);
            this.lblColunas.Name = "lblColunas";
            this.lblColunas.Size = new System.Drawing.Size(103, 31);
            this.lblColunas.TabIndex = 45;
            this.lblColunas.Text = "Colunas:";
            // 
            // fORNECEDORBindingSource
            // 
            this.fORNECEDORBindingSource.DataMember = "FORNECEDOR";
            this.fORNECEDORBindingSource.DataSource = this.dsDadosEntrada;
            // 
            // dsDadosEntrada
            // 
            this.dsDadosEntrada.DataSetName = "dsDadosEntrada";
            this.dsDadosEntrada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fORNECEDORTableAdapter
            // 
            this.fORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // cOLUNASFORNECEDORBindingSource
            // 
            this.cOLUNASFORNECEDORBindingSource.DataMember = "COLUNASFORNECEDOR";
            this.cOLUNASFORNECEDORBindingSource.DataSource = this.dsDadosEntrada;
            // 
            // cOLUNASFORNECEDORTableAdapter
            // 
            this.cOLUNASFORNECEDORTableAdapter.ClearBeforeFill = true;
            // 
            // frmListagemFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1174, 614);
            this.Controls.Add(this.lblColunas);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.cmbColunas);
            this.Controls.Add(this.picBox_Logo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.txtBox_TxtFiltro);
            this.Controls.Add(this.lbl_FiltrarPor);
            this.Controls.Add(this.picBox_Header);
            this.Controls.Add(this.ReportViewerFornec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListagemFornecedor";
            this.Text = "Lista de Fornecedores";
            this.Load += new System.EventHandler(this.frmListagemFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fORNECEDORBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDadosEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOLUNASFORNECEDORBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerFornec;
        private System.Windows.Forms.PictureBox picBox_Header;
        private System.Windows.Forms.Label lbl_FiltrarPor;
        private System.Windows.Forms.TextBox txtBox_TxtFiltro;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox picBox_Logo;
        private System.Windows.Forms.ComboBox cmbColunas;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblColunas;
        private Dados.dsDadosEntrada dsDadosEntrada;
        private System.Windows.Forms.BindingSource fORNECEDORBindingSource;
        private Dados.dsDadosEntradaTableAdapters.FORNECEDORTableAdapter fORNECEDORTableAdapter;
        private System.Windows.Forms.BindingSource cOLUNASFORNECEDORBindingSource;
        private Dados.dsDadosEntradaTableAdapters.COLUNASFORNECEDORTableAdapter cOLUNASFORNECEDORTableAdapter;
    }
}