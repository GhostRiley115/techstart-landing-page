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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnIniciar, "Inicia o exercício.");
            toolTip1.SetToolTip(btnLimpar, "Limpa os campos.");
            toolTip1.SetToolTip(btnSair, "Sai do exercício.");
        }

        private void FrmExercicio2_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio2_Load(object sender, EventArgs e)
        {
            txtValorProduto.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtValorProduto.Text, out decimal valor) ||
                !int.TryParse(txtQuantidade.Text, out int qtd))
            {
                MessageBox.Show("Informe um valor e uma quantidade válidos.");
                return;
            }

            decimal total = valor * qtd;
            lblResultado.Text = $"Total a ser pago: {total:C}";
            lblResultado.Visible = true;
            txtValorProduto.Clear();
            txtQuantidade.Clear();
            txtValorProduto.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtQuantidade.Clear();
            txtValorProduto.Clear();
            lblResultado.Visible = false;
            txtValorProduto.Focus();
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

        private void txtValorProduto_KeyPress(object sender, KeyPressEventArgs e)
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
