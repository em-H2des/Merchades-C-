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
    public partial class frmExibirNotaFiscal : Form
    {
        public frmExibirNotaFiscal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Criar e configurar o OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Imagens (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp",
                Title = "Selecione uma imagem"
            };

            // Verificar se o usuário selecionou um arquivo
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Exibir a imagem no PictureBox
                picBox_NF.Image = Image.FromFile(openFileDialog.FileName);
                picBox_NF.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar a imagem ao tamanho do PictureBox
            }
        }
    }
}
