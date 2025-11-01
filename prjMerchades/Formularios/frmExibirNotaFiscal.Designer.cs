namespace prjMerchades.Formularios
{
    partial class frmExibirNotaFiscal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExibirNotaFiscal));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_UploadNF = new System.Windows.Forms.Button();
            this.picBox_NF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NF)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_UploadNF
            // 
            this.btn_UploadNF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_UploadNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_UploadNF.Location = new System.Drawing.Point(192, 12);
            this.btn_UploadNF.Name = "btn_UploadNF";
            this.btn_UploadNF.Size = new System.Drawing.Size(99, 26);
            this.btn_UploadNF.TabIndex = 0;
            this.btn_UploadNF.Text = "Upload";
            this.btn_UploadNF.UseVisualStyleBackColor = false;
            this.btn_UploadNF.Click += new System.EventHandler(this.button1_Click);
            // 
            // picBox_NF
            // 
            this.picBox_NF.Location = new System.Drawing.Point(12, 44);
            this.picBox_NF.Name = "picBox_NF";
            this.picBox_NF.Size = new System.Drawing.Size(469, 605);
            this.picBox_NF.TabIndex = 1;
            this.picBox_NF.TabStop = false;
            // 
            // frmExibirNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(493, 661);
            this.Controls.Add(this.picBox_NF);
            this.Controls.Add(this.btn_UploadNF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExibirNotaFiscal";
            this.Text = "Nota Fiscal";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_NF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_UploadNF;
        private System.Windows.Forms.PictureBox picBox_NF;
    }
}