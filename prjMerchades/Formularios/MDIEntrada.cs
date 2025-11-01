using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjMerchades.Formularios.Entrada;


namespace prjMerchades.Formularios
{
    public partial class MDIEntrada : Form
    {
        private int childFormNumber = 0;

        public MDIEntrada()
        {
            InitializeComponent();
        }

        private void listagemDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListagemFornecedor frmListagemFornecedor = new frmListagemFornecedor();
            frmListagemFornecedor.MdiParent = this;
            frmListagemFornecedor.Show();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque frmEstoque = new frmEstoque();
            frmEstoque.MdiParent = this;
            frmEstoque.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompras frmCompras = new frmCompras();
            frmCompras.MdiParent = this;
            frmCompras.Show();
        }

        private void exibirNotaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExibirNotaFiscal frmExibirNotaFiscal = new frmExibirNotaFiscal();
            frmExibirNotaFiscal.MdiParent = this;
            frmExibirNotaFiscal.Show();
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

        private void MDIEntrada_Load(object sender, EventArgs e)
        {
            dataToolStripStatusLabel.Text = "Data: " + DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void cadastroFrncdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadFornecedor frmCadastroFornecedor = new frmCadFornecedor();
            frmCadastroFornecedor.MdiParent = this;
            frmCadastroFornecedor.Show();
        }
    }
}