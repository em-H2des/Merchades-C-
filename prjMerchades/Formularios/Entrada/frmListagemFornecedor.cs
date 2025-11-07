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
            // TODO: esta linha de código carrega dados na tabela 'dsDadosEntrada.COLUNASFORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.cOLUNASFORNECEDORTableAdapter.Fill(this.dsDadosEntrada.COLUNASFORNECEDOR);
            // TODO: esta linha de código carrega dados na tabela 'dsDadosEntrada.FORNECEDOR'. Você pode movê-la ou removê-la conforme necessário.
            this.fORNECEDORTableAdapter.Fill(this.dsDadosEntrada.FORNECEDOR);
            this.ReportViewerFornec.RefreshReport();

            if (cmbFiltro.Items.Count > 0) cmbFiltro.SelectedIndex = 0;
            txtBox_TxtFiltro.Enabled = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vColuna, vProcurar, vTexto, vFiltro;

            vColuna = cmbColunas.SelectedItem.ToString();
            vProcurar = cmbFiltro.Text;
            vTexto = txtBox_TxtFiltro.Text.Trim().Replace("'", "''");
            vFiltro = "";

            switch (vProcurar)
            {
                case "Todos":
                    // Remove qualquer filtro existente
                    fORNECEDORBindingSource.RemoveFilter();
                    txtBox_TxtFiltro.Text = "";
                    return;

                case "Que começa com":
                    if (string.IsNullOrEmpty(vTexto)) break;
                    vFiltro = $"CONVERT([{vColuna}], 'System.String') LIKE '{vTexto}%'";
                    break;

                case "Que contém":
                    if (string.IsNullOrEmpty(vTexto)) break;
                    vFiltro = $"CONVERT([{vColuna}], 'System.String') LIKE '%{vTexto}%'";
                    break;

                case "Que termina com":
                    if (string.IsNullOrEmpty(vTexto)) break;
                    vFiltro = $"CONVERT([{vColuna}], 'System.String') LIKE '%{vTexto}'";
                    break;

                default:
                    fORNECEDORBindingSource.RemoveFilter();
                    return;
            }

            if (!string.IsNullOrEmpty(vFiltro))
            {
                fORNECEDORBindingSource.Filter = vFiltro;
            }
            else
            {
                fORNECEDORBindingSource.RemoveFilter();
            }
        }

        private void cmbBox_Filtro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltro.Text == "Todos")
            {
                txtBox_TxtFiltro.Text = "";
                txtBox_TxtFiltro.Enabled = false;
            }
            else
            {
                txtBox_TxtFiltro.Enabled = true;
            }
        }
    }
}
