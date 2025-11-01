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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int vErros = 0;

        private bool CaixasOK()
        {
            if (TextBox_NomeUsuario.Text == "")
            {
                errorProvider.SetError(TextBox_NomeUsuario, "Informe o nome do usuário");
                return false;
            }
            else
                errorProvider.SetError(TextBox_NomeUsuario, "");

            if (TextBox_Senha.Text == "")
            {
                errorProvider.SetError(TextBox_Senha, "Informe a senha");
                return false;
            }
            else
                errorProvider.SetError(TextBox_Senha, "");

            return true;
        }    

        private void Btn_Cancelar_Click(object sender, EventArgs e)
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

        private void Btn_Mostrar_Click(object sender, EventArgs e)
        {
            if (TextBox_Senha.UseSystemPasswordChar)
            {
                TextBox_Senha.UseSystemPasswordChar = false;
                Btn_Mostrar.Font = new Font("Segoe MDL2 Assets", 14);
                Btn_Mostrar.Text = "\xf78a"; // Olho aberto
            }
            else
            {
                TextBox_Senha.UseSystemPasswordChar = true;
                Btn_Mostrar.Font = new Font("Segoe MDL2 Assets", 14);
                Btn_Mostrar.Text = "\xE7B3"; // Olho riscado
            }
        }


        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                string usuario = TextBox_NomeUsuario.Text.Trim().ToLower();
                string senha = TextBox_Senha.Text;

                if (usuario == "entrada" && senha == "123")
                {
                    // Abre o MDIEntrada
                    MDIEntrada frmEntrada = new MDIEntrada();
                    frmEntrada.Show();
                    this.Hide(); // ou Close() se preferir
                }
                else if (usuario == "saida" && senha == "123")
                {
                    // Abre o MDISaida
                    frmMenuSaida frmMenuSaida = new frmMenuSaida();
                    frmMenuSaida.Show();
                    this.Hide();
                }
                else if (usuario == "financeiro" && senha == "123")
                {
                    // Abre o MDIfinanceiro
                    MDIFinanceiro frmFinanceiro = new MDIFinanceiro();
                    frmFinanceiro.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    vErros++;

                    if (vErros == 3)
                    {
                        MessageBox.Show("Número de tentativas esgotado...");
                        Application.Exit();
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Btn_Mostrar.Text = "\xE7B3";
        }
    }
}
