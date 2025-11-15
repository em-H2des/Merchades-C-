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
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada2.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada2.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada1.compraDividas'. Você pode movê-la ou removê-la conforme necessário.
            this.compraDividasTableAdapter.Fill(this.daDadosEntrada1.compraDividas);
            // TODO: esta linha de código carrega dados na tabela 'daDadosEntrada.NOTA_FISCAL_FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.nOTA_FISCAL_FORNECEDORTableAdapter.Fill(this.daDadosEntrada.NOTA_FISCAL_FORNECEDOR);
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string coluna, filtro, resultado;

            coluna = cmbFiltro.Text;
            filtro = txtFiltro.Text;

            if (coluna == "Fornecedor") 
            {
                resultado = "NOME_FORNECEDOR like '%" + filtro + "%'";
                compraDividasBindingSource1.Filter = resultado;
            }

            else if (coluna == "Data")
            {
                resultado = $"Convert(DATA_EMISSAO, 'System.String') LIKE '%{filtro}%'";
                compraDividasBindingSource1.Filter = resultado;
            }

            if (coluna == "Valor")
            {
                resultado = $"Convert(VALOR_COMPRA, 'System.String') LIKE '%{filtro}%'";
                compraDividasBindingSource1.Filter = resultado;
            }
        }
    }
}
