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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListagemFornecedor));
            this.reportViewer_Fornecedores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.picBox_Header = new System.Windows.Forms.PictureBox();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.txt_NomeFiltro = new System.Windows.Forms.TextBox();
            this.lbl_FiltrarPor = new System.Windows.Forms.Label();
            this.txtBox_TxtFiltro = new System.Windows.Forms.TextBox();
            this.cmbBox_Filtro = new System.Windows.Forms.ComboBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Header)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer_Fornecedores
            // 
            this.reportViewer_Fornecedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.reportViewer_Fornecedores.Location = new System.Drawing.Point(0, 220);
            this.reportViewer_Fornecedores.Name = "reportViewer_Fornecedores";
            this.reportViewer_Fornecedores.ServerReport.BearerToken = null;
            this.reportViewer_Fornecedores.Size = new System.Drawing.Size(1084, 394);
            this.reportViewer_Fornecedores.TabIndex = 0;
            // 
            // picBox_Header
            // 
            this.picBox_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.picBox_Header.Location = new System.Drawing.Point(0, -3);
            this.picBox_Header.Name = "picBox_Header";
            this.picBox_Header.Size = new System.Drawing.Size(1084, 139);
            this.picBox_Header.TabIndex = 5;
            this.picBox_Header.TabStop = false;
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.lbl_Data.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.ForeColor = System.Drawing.Color.White;
            this.lbl_Data.Location = new System.Drawing.Point(945, 165);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(84, 31);
            this.lbl_Data.TabIndex = 6;
            this.lbl_Data.Text = "              ";
            // 
            // txt_NomeFiltro
            // 
            this.txt_NomeFiltro.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txt_NomeFiltro.Location = new System.Drawing.Point(13, 165);
            this.txt_NomeFiltro.Name = "txt_NomeFiltro";
            this.txt_NomeFiltro.Size = new System.Drawing.Size(280, 33);
            this.txt_NomeFiltro.TabIndex = 14;
            this.txt_NomeFiltro.Text = "Nome do Fornecedor";
            // 
            // lbl_FiltrarPor
            // 
            this.lbl_FiltrarPor.AutoSize = true;
            this.lbl_FiltrarPor.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltrarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.lbl_FiltrarPor.Location = new System.Drawing.Point(297, 167);
            this.lbl_FiltrarPor.Name = "lbl_FiltrarPor";
            this.lbl_FiltrarPor.Size = new System.Drawing.Size(127, 31);
            this.lbl_FiltrarPor.TabIndex = 15;
            this.lbl_FiltrarPor.Text = "Filtrar Por:";
            // 
            // txtBox_TxtFiltro
            // 
            this.txtBox_TxtFiltro.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_TxtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.txtBox_TxtFiltro.Location = new System.Drawing.Point(676, 165);
            this.txtBox_TxtFiltro.Multiline = true;
            this.txtBox_TxtFiltro.Name = "txtBox_TxtFiltro";
            this.txtBox_TxtFiltro.Size = new System.Drawing.Size(263, 31);
            this.txtBox_TxtFiltro.TabIndex = 17;
            this.txtBox_TxtFiltro.Text = "Texto Filtrador Ex:(14/07/2000)";
            // 
            // cmbBox_Filtro
            // 
            this.cmbBox_Filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBox_Filtro.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBox_Filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(78)))), ((int)(((byte)(46)))));
            this.cmbBox_Filtro.FormattingEnabled = true;
            this.cmbBox_Filtro.Items.AddRange(new object[] {
            "Nascimento",
            "Registro",
            "Nome",
            "Cidade",
            "RG"});
            this.cmbBox_Filtro.Location = new System.Drawing.Point(425, 163);
            this.cmbBox_Filtro.Name = "cmbBox_Filtro";
            this.cmbBox_Filtro.Size = new System.Drawing.Size(217, 35);
            this.cmbBox_Filtro.TabIndex = 18;
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
            this.picBox_Logo.Location = new System.Drawing.Point(950, 25);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(100, 87);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 42;
            this.picBox_Logo.TabStop = false;
            // 
            // frmListagemFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1084, 614);
            this.Controls.Add(this.picBox_Logo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.cmbBox_Filtro);
            this.Controls.Add(this.txtBox_TxtFiltro);
            this.Controls.Add(this.lbl_FiltrarPor);
            this.Controls.Add(this.txt_NomeFiltro);
            this.Controls.Add(this.lbl_Data);
            this.Controls.Add(this.picBox_Header);
            this.Controls.Add(this.reportViewer_Fornecedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListagemFornecedor";
            this.Text = "Lista de Fornecedores";
            this.Load += new System.EventHandler(this.frmListagemFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Header)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_Fornecedores;
        private System.Windows.Forms.PictureBox picBox_Header;
        private System.Windows.Forms.Label lbl_Data;
        private System.Windows.Forms.TextBox txt_NomeFiltro;
        private System.Windows.Forms.Label lbl_FiltrarPor;
        private System.Windows.Forms.TextBox txtBox_TxtFiltro;
        private System.Windows.Forms.ComboBox cmbBox_Filtro;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.PictureBox picBox_Logo;
    }
}