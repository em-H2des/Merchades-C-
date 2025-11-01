using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjMerchades.Formularios.Entrada
{
    public partial class frmCompras : Form
    {

        public frmCompras()
        {
            InitializeComponent();
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lbl_Data2.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int codigoFornecedor =  int.Parse(txtCodFornecedor.Text);

            if (codigoFornecedor == 888)
            {
                MessageBox.Show("O fornecedor infomrado nao existe, cadastre-o.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var formCadastroFornecedor = new frmCadFornecedor();
                formCadastroFornecedor.MdiParent = this.MdiParent;
                formCadastroFornecedor.Show();
                //formCadastroFornecedor.ShowDialog();
            }

            else
            {
                //aqui é o resto do codigo caso o fornecedor ja exista
            }
        }
    }
}
