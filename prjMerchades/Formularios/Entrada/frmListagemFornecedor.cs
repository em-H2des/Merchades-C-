using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios.Entrada
{
    public partial class frmListagemFornecedor : Form
    {
        public frmListagemFornecedor()
        {
            InitializeComponent();

            picBox_Header.SendToBack();
        }

        private void frmListagemFornecedor_Load(object sender, EventArgs e)
        {
            lbl_Data.Text = DateTime.Now.ToString("dd/MM/yyyy");

            this.reportViewer_Fornecedores.RefreshReport();
        }
    }
}
