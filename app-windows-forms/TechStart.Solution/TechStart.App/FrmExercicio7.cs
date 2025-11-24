using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechStart.App
{
    public partial class FrmExercicio7 : Form
    {
        public FrmExercicio7()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnIniciar, "Inicia o exercício.");
            toolTip1.SetToolTip(btnLimpar, "Limpa os campos.");
            toolTip1.SetToolTip(btnSair, "Sai do exercício.");
        }

        private void FrmExercicio7_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio7_Load(object sender, EventArgs e)
        {
            txtNumeros.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] linhas = txtNumeros.Lines;

            bool encontrouAlgum = false;
            int menor = 0;
            int maior = 0;

            foreach (string linha in linhas)
            {
                string texto = linha.Trim();

                if (string.IsNullOrEmpty(texto))
                    continue;

                if (!int.TryParse(texto, out int n))
                {
                    MessageBox.Show($"Valor inválido: {texto}");
                    return;
                }

                if (!encontrouAlgum)
                {
                    menor = n;
                    maior = n;
                    encontrouAlgum = true;
                }
                else
                {
                    if (n < menor)
                        menor = n;

                    if (n > maior)
                        maior = n;
                }
            }

            lblResultado.Text = $"Menor número: {menor}   |   Maior número: {maior}";
            lblResultado.Visible = true;
            txtNumeros.Clear();
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.BackColor = Color.LightBlue;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            txtNumeros.Clear();
            txtNumeros.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_MouseEnter(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.LightBlue;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.LightBlue;
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.BackColor = Color.White;
        }

        private void btnLimpar_MouseLeave(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.White;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.BackColor = Color.White;
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }
    }
}
