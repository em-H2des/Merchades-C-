using prjMerchades.Formularios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchades
{
    public partial class frmNotaFiscal : Form
    {
        public frmNotaFiscal()
        {
            InitializeComponent();
        }

        private void btnVoltarTelaInicial_Click(object sender, EventArgs e)
        {
            frmMenuSaida novoForm = new frmMenuSaida();
            this.Hide(); // apenas esconde o atual
            novoForm.ShowDialog();
            this.Close(); // fecha depois que o novo for fechado
        }

        private void frmNotaFiscal_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MARCO\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";
            string query = "SELECT ID_NOTA_VENDA FROM NOTA_FISCAL_VENDA";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                int posY = 35;   // Começa mais abaixo

                while (dr.Read())
                {
                    int id = dr.GetInt32(0);

                    // Criar o GroupBox reposicionado
                    GroupBox gb = new GroupBox();
                    gb.Width = panel2.Width - 60;
                    gb.Height = 55;
                    gb.Left = 22;                   
                    gb.Top = posY;
                    gb.BackColor = Color.FromArgb(58, 147, 116);

                    // Criar Label centralizado
                    Label lbl = new Label();
                    lbl.Text = $"{id} - Venda {id}";
                    lbl.ForeColor = Color.White;
                    lbl.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

                    // Centralizar horizontalmente
                    lbl.AutoSize = true;
                    lbl.Left = 5;
                    lbl.Top = 20;

                    // Criando Botão
                    Button btn = new Button();
                    btn.Text = "Ver compra";
                    btn.Width = 83;
                    btn.Height = 27;
                    btn.Top = 16;
                    btn.Left = 147;
                    btn.BackColor = Color.White;

                    // Adicionando ao GroupBox
                    gb.Controls.Add(lbl);
                    gb.Controls.Add(btn);

                    // Adicionar ao Panel
                    panel2.Controls.Add(gb);

                    posY += gb.Height + 15; // espaço vertical entre os groupBox
                }
            }
        }
    }
}
