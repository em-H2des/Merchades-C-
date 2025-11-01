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
        public partial class frmMenu : Form
        {
            public frmMenu()
            {
                InitializeComponent();
                this.WindowState = FormWindowState.Maximized; // abre em tela cheia
            }

            // Abre formulários dentro de uma aba
            private void AbrirFormulario(Form form, string titulo)
            {
                foreach (TabPage page in tabControlSaida.TabPages)
                {
                    if (page.Text == titulo)
                    {
                        tabControlSaida.SelectedTab = page;
                        return;
                    }
                }

                TabPage novaAba = new TabPage(titulo);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                novaAba.Controls.Add(form);
                tabControlSaida.TabPages.Add(novaAba);
                tabControlSaida.SelectedTab = novaAba;

                form.Show();
            }

            
        private void btnFecharAba_Click(object sender, EventArgs e)
        {
            if (tabControlSaida.TabPages.Count > 0)
                tabControlSaida.TabPages.Remove(tabControlSaida.SelectedTab);
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            /*formMerchades novoForm = new formMerchades();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for fechado*/
            // Abre o formCaixa dentro da aba "Caixa"
            // Seleciona a aba "Caixa" dentro do tabControlSaida
            foreach (TabPage page in tabControlSaida.TabPages)
            {
                if (page.Name == "tabCaixa") // ou use page.Text se quiser pelo título da aba
                {
                    tabControlSaida.SelectedTab = page;
                    break;
                }
            }
        }

        private void BtnNovoProduto2_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha o formProduto e mostra a tela formVendas que está aberta atrás
        }

        private void btnCancelaVenda_Click(object sender, EventArgs e)
        {
            frmMenuSaida novoForm = new frmMenuSaida();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for fechado
        }

        private void btnFinalizaCompra_Click(object sender, EventArgs e)
        {
            frmPagamento novoForm = new frmPagamento();
            novoForm.Show();//Abre uma tela do formProdutos
        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            //Troca para a aba de estoque
            tabControlSaida.SelectedIndex = 1;
        }
    }
}


