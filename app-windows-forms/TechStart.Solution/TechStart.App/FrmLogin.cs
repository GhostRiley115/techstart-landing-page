using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace TechStart.App
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            
            InitializeComponent();
            toolTip1.SetToolTip(txtUser, "Digite o nome de usuário que você cadastrou.");
            toolTip1.SetToolTip(txtPassword, "Digite a senha correspondente ao seu usuário.");

        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }
        private bool ValidarLogin(string usuario, string senha)
        {
            string caminhoArquivo = Path.Combine(Application.StartupPath, "dados", "usuarios.txt");

            if (!File.Exists(caminhoArquivo))
            {
                MessageBox.Show("Arquivo de usuários não encontrado.\nVerifique a pasta 'dados'.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
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
                string senhaArquivo = partes[1].Trim();

                if (usuario.Equals(usuarioArquivo, StringComparison.OrdinalIgnoreCase) &&
                    senha == senhaArquivo)
                {
                    return true; 
                }
            }

            return false;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUser.Text.Trim();
            string senha = txtPassword.Text.Trim();
            lblErro.Visible = false;
            lblErro.Text = string.Empty;

            if (string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                lblErro.Text = "Digite o usuário e a senha.";
                lblErro.Visible = true;

                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(usuario))
            {
                lblErro.Text = "Digite o usuário.";
                lblErro.Visible = true;

                txtUser.Focus();
                return;
            }

            if (string.IsNullOrEmpty(senha))
            {
                lblErro.Text = "Digite sua senha.";
                lblErro.Visible = true;

                txtPassword.Focus();
                return;
            }

            if (ValidarLogin(usuario, senha))
            {
                FrmPrincipal principal = new FrmPrincipal();
                principal.FormClosed += (s, args) => this.Close();
                principal.Show();
                this.Hide();
            }
            else
            {
                lblErro.Text = "Usuário ou senha inválidos.";
                lblErro.Visible = true;

                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void chkMostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkMostrarSenha.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja realmente sair?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resp == DialogResult.No)
                return;
            else
                Application.Exit();
        }

        private void lnkEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmEsqueciSenha frm = new FrmEsqueciSenha();
            frm.ShowDialog(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FrmCadastroUsuario cadastro = new FrmCadastroUsuario())
            {
                cadastro.ShowDialog(); 
            }
        }
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsLetterOrDigit(e.KeyChar))
                return;

            if (e.KeyChar == '.')
                return;

            e.Handled = true;
        }

        private void pnlBrand_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlBrand.Width, pnlBrand.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(47, 72, 122),  
                Color.FromArgb(5, 8, 22),     
                LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }
    }
}
