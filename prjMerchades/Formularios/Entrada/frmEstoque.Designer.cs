namespace prjMerchades.Formularios.Entrada
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.RprtVw_Estoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_AddProduto = new System.Windows.Forms.Button();
            this.picBox_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // RprtVw_Estoque
            // 
            this.RprtVw_Estoque.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RprtVw_Estoque.Location = new System.Drawing.Point(0, 116);
            this.RprtVw_Estoque.Name = "RprtVw_Estoque";
            this.RprtVw_Estoque.ServerReport.BearerToken = null;
            this.RprtVw_Estoque.Size = new System.Drawing.Size(800, 334);
            this.RprtVw_Estoque.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Open Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Titulo.Location = new System.Drawing.Point(25, 23);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(222, 69);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Estoque";
            // 
            // btn_AddProduto
            // 
            this.btn_AddProduto.BackColor = System.Drawing.Color.White;
            this.btn_AddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddProduto.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.btn_AddProduto.Location = new System.Drawing.Point(514, 27);
            this.btn_AddProduto.Name = "btn_AddProduto";
            this.btn_AddProduto.Size = new System.Drawing.Size(142, 65);
            this.btn_AddProduto.TabIndex = 2;
            this.btn_AddProduto.Text = "Adicionar Produtos";
            this.btn_AddProduto.UseVisualStyleBackColor = false;
            this.btn_AddProduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_Logo
            // 
            this.picBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("picBox_Logo.Image")));
            this.picBox_Logo.Location = new System.Drawing.Point(676, 12);
            this.picBox_Logo.Name = "picBox_Logo";
            this.picBox_Logo.Size = new System.Drawing.Size(100, 87);
            this.picBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Logo.TabIndex = 3;
            this.picBox_Logo.TabStop = false;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(147)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picBox_Logo);
            this.Controls.Add(this.btn_AddProduto);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.RprtVw_Estoque);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoque";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RprtVw_Estoque;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_AddProduto;
        private System.Windows.Forms.PictureBox picBox_Logo;
    }
}