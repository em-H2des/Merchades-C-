using prjMerchades.Formularios.Financeiro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjMerchades.Formularios
{
    public partial class MDIFinanceiro : Form
    {
        private int childFormNumber = 0;

        public MDIFinanceiro()
        {
            InitializeComponent();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Deseja realmente fechar?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void RelFinanceiro_Click(object sender, EventArgs e)
        {
            frmRelFinanceiro frmRelFinanceiro = new frmRelFinanceiro();
            frmRelFinanceiro.MdiParent = this;
            frmRelFinanceiro.Show();
        }
    }
}
