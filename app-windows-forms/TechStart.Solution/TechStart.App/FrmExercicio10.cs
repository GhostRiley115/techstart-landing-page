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
    public partial class FrmExercicio10 : Form
    {
        public FrmExercicio10()
        {
            InitializeComponent();
            toolTip1.SetToolTip(btnIniciar, "Inicia o exercício.");
            toolTip1.SetToolTip(btnLimpar, "Limpa os campos.");
            toolTip1.SetToolTip(btnSair, "Sai do exercício.");
        }

        private void FrmExercicio10_Paint(object sender, PaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(Color.FromArgb(120, 0, 0, 0)))
            {
                e.Graphics.FillRectangle(b, this.ClientRectangle);
            }
        }

        private void FrmExercicio10_Load(object sender, EventArgs e)
        {
            txtIdade.Focus();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show("Digite uma idade válida.");
                return;
            }

            string categoria;

            if (idade >= 5 && idade <= 10) { 
                categoria = "Infantil";
            lblResultado.Text = $"O atleta está na categoria {categoria}.";
            lblResultado.Visible = true;
            }
            else if (idade >= 11 && idade <= 15) { 
                categoria = "Juvenil";
            lblResultado.Text = $"O atleta está na categoria {categoria}.";
            lblResultado.Visible = true;
            }
            else if (idade >= 16 && idade <= 20) { 
                categoria = "Júnior";
            lblResultado.Text = $"O atleta está na categoria {categoria}.";
            lblResultado.Visible = true;
            }
            else if (idade >= 21 && idade <= 25) { 
                categoria = "Profissional";
                lblResultado.Text = $"O atleta está na categoria {categoria}.";
                lblResultado.Visible = true;
            }
            else
                lblResultado.Text = "Não está na faixa etária permitida.";
                lblResultado.Visible = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Visible = false;
            txtIdade.Clear();
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

        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }
    }
}
