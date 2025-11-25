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
    public partial class FrmCadastroUsuario : Form
    {
        private readonly string caminhoArquivo;

        public FrmCadastroUsuario()
        {
            InitializeComponent();

            caminhoArquivo = Path.Combine(Application.StartupPath,"dados","usuarios.txt");
        }

        private void FrmCadastroUsuario_Load(object sender, EventArgs e)
        {
            txtNovoUsuario.Focus();
        }


        private void chkMostrarSenha1_CheckedChanged(object sender, EventArgs e)
        {
            txtConfirmarSenha.UseSystemPasswordChar = !chkMostrarSenha1.Checked;
            txtNovaSenha.UseSystemPasswordChar = !chkMostrarSenha1.Checked;
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string usuario = txtNovoUsuario.Text.Trim();
            string senha = txtNovaSenha.Text.Trim();
            string confirmar = txtConfirmarSenha.Text.Trim();
            lblErro.Visible = false;
            lblErro.Text = string.Empty;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmar))
            {
                lblErro.Text = "Preencha todos os campos.";
                lblErro.Visible = true;
                return;
            }

            if (senha != confirmar)
            {
                lblErro.Text = "A confirmação de senha não confere.";
                lblErro.Visible = true;
                txtConfirmarSenha.Focus();
                return;
            }

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.\nVerifique a pasta 'dados'.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 2)
                    continue;

                string usuarioArquivo = partes[0].Trim();

                if (usuario.Equals(usuarioArquivo, StringComparison.OrdinalIgnoreCase))
                {
                    lblErro.Text = "Usuário já existe. Escolha outro nome.";
                    lblErro.Visible = true;
                    txtNovoUsuario.Focus();
                    return;
                }
            }

            try
            {
                using (StreamWriter sw = new StreamWriter(caminhoArquivo, append: true))
                {
                    sw.WriteLine($"{usuario};{senha}");
                }

                MessageBox.Show("Usuário cadastrado com sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar o usuário.\nDetalhes: " + ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resp == DialogResult.No)
                return;
            else
                this.Close();
        }
        private void txtNovoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetterOrDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.')
                return;

            e.Handled = true;
        }
    }
}
