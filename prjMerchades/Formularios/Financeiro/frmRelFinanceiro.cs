using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios.Financeiro
{
    public partial class frmRelFinanceiro : Form
    {
        public frmRelFinanceiro()
        {
            InitializeComponent();
        }

        private void tabControl_Financeiro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_NF_Click(object sender, EventArgs e)
        {

        }

        private void frmRelFinanceiro_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
