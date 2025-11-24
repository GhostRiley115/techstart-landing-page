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
    public partial class FrmExercicio8 : Form
    {
        public FrmExercicio8()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnIniciar, "Inicia o exercício.");
            toolTip1.SetToolTip(btnLimpar, "Limpa os campos.");
            toolTip1.SetToolTip(btnSair, "Sai do exercício.");
        }

        private void FrmExercicio8_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio8_Load(object sender, EventArgs e)
        {
            txtQuantidade.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantidade.Text, out int termos))
            {
                MessageBox.Show("Digite uma quantidade de termos válida.");
                return;
            }

            if (termos <= 0)
            {
                MessageBox.Show("Digite um número maior que zero.");
                return;
            }

            if (termos > 30)
            {
                MessageBox.Show("Digite no máximo 30 termos para a visualização ficar melhor.");
                return;
            }

            long anterior = 0;
            long atual = 1;

            string sequencia = "";

            for (int i = 0; i < termos; i++)
            {
                if (i == 0)
                {
                    sequencia = anterior.ToString();
                }
                else
                {
                    sequencia += ", " + anterior.ToString();
                }

                long proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }

            lblResultado.Text = "Sequência: " + sequencia;
            lblResultado.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            txtQuantidade.Clear();
            txtQuantidade.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }
    }
}
