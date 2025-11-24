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
    public partial class FrmExercicio6 : Form
    {
        public FrmExercicio6()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnIniciar, "Inicia o exercício.");
            toolTip1.SetToolTip(btnLimpar, "Limpa os campos.");
            toolTip1.SetToolTip(btnSair, "Sai do exercício.");
            toolTip1.SetToolTip(txtNumero, "O programa só calcula até 20.");
        }

        private void FrmExercicio6_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio6_Load(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int n))
            {
                MessageBox.Show("Digite um número inteiro válido.");
                return;
            }

            if (n < 0)
            {
                lblResultado.Text = "Fatorial é definido para números não negativos.";
                lblResultado.Visible = true;
                return;
            }

            if (n > 20)
            {
                lblResultado.Text = "Número muito grande. Informe um valor até 20.";
                lblResultado.Visible = true;
                return;
            }

            long fat = 1;
            for (int i = 1; i <= n; i++)
            {
                fat *= i;
            }

            lblResultado.Text = $"O fatorial de {n} é: {fat}";
            lblResultado.Visible = true;
            txtNumero.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtNumero.Focus();
            lblResultado.Visible = false;
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.BackColor = Color.LightBlue;
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

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }
    }
}
