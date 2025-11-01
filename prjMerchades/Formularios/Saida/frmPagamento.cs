using prjMerchades.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchades
{
    public partial class frmPagamento : Form
    {
        public frmPagamento()
        {
            InitializeComponent();
        }

        

        private void btnCancelaVenda_Click(object sender, EventArgs e)
        {
            frmMenuSaida novoForm = new frmMenuSaida();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for aberto

        }

        private void btnCancelaOperacao_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha o formPagamento e mostra a tela formVendas que está aberta atrás
        }

        private void btnConfirmaCompra_Click(object sender, EventArgs e)
        {
            frmMenuSaida novoForm = new frmMenuSaida();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for aberto
        }
    }
}
