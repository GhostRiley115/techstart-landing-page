using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace TechStart.App
{
    public partial class FrmExercicio1 : Form
    {
        public FrmExercicio1()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnIniciar, "Inicia o exercício.");
            toolTip1.SetToolTip(btnLimpar, "Limpa os campos.");
            toolTip1.SetToolTip(btnSair, "Sai do exercício.");
        }

        private void FrmExercicio1_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio1_Load(object sender, EventArgs e)
        {
            txtN1.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtN1.Text, out double n1) ||
                !double.TryParse(txtN2.Text, out double n2) ||
                !double.TryParse(txtN3.Text, out double n3))
            {
                MessageBox.Show("Digite três números válidos.");
                return;
            }

            double media = (n1 + n2 + n3) / 3.0;
            lblResultado.Text = $"A média dos números é: {media}";
            lblResultado.Visible = true;
            txtN1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
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

        private void txtN1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            var txt = sender as System.Windows.Forms.TextBox;
            if (e.KeyChar == ',' && txt != null && !txt.Text.Contains(","))
                return;

            e.Handled = true;
        }

    }
}
