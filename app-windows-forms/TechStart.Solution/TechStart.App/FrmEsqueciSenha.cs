using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TechStart.App
{
    public partial class FrmEsqueciSenha : Form
    {
        private readonly string caminhoArquivo;
        public FrmEsqueciSenha()
        {
            InitializeComponent();
            caminhoArquivo = Path.Combine(
            Application.StartupPath,
            "dados",
            "usuarios.txt"
             );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "Deseja realmente sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (resp == DialogResult.No)
                return;
            else
                this.Close();
        }

        private void txtUsuarioEsqueci_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetterOrDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.')
                return;

            e.Handled = true;
        }

        private void FrmEsqueciSenha_Load(object sender, EventArgs e)
        {
            txtUsuarioEsqueci.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioEsqueci.Text.Trim();

            if (string.IsNullOrEmpty(usuario))
            {
                MessageBox.Show(
                    "Digite o usuário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtUsuarioEsqueci.Focus();
                return;
            }

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show(
                    "Arquivo de usuários não encontrado.\nVerifique a pasta 'dados'.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string[] linhas = File.ReadAllLines(caminhoArquivo);
            string senhaEncontrada = null;

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 2)
                    continue;

                string usuarioArquivo = partes[0].Trim();
                string senhaArquivo = partes[1].Trim();

                if (usuario.Equals(usuarioArquivo, StringComparison.OrdinalIgnoreCase))
                {
                    senhaEncontrada = senhaArquivo;
                    break;
                }
            }

            if (senhaEncontrada == null)
            {
                MessageBox.Show(
                    "Usuário não encontrado.",
                    "Resultado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"A senha cadastrada para o usuário '{usuario}' é:\n\n{senhaEncontrada}",
                    "Senha encontrada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
