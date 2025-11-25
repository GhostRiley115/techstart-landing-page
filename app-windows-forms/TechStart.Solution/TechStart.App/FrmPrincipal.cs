using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStart.App
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void mnuSair_Click(object sender, EventArgs e)
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
            Application.Exit();
        }

        private void mnuCadProdutos_Click(object sender, EventArgs e)
        {
            using (FrmProdutos frm = new FrmProdutos())
            {
                frm.ShowDialog();
                frm.MdiParent = this;   
                frm.Show();             
            }
        }

        private void mnuCadEventos_Click(object sender, EventArgs e)
        {
            using (FrmEventos frm = new FrmEventos())
            {
                frm.ShowDialog();
                frm.MdiParent = this;  
                frm.Show();            
            }
        }

        private void mnuConProdutos_Click(object sender, EventArgs e)
        {
            using (FrmConsultaProdutos frm = new FrmConsultaProdutos())
            {
                frm.ShowDialog();
                frm.MdiParent = this;  
                frm.Show();            
            }
        }

        private void mnuConEventos_Click(object sender, EventArgs e)
        {
            using (FrmConsultaEventos frm = new FrmConsultaEventos())
            {
                frm.ShowDialog();
                frm.MdiParent = this;    
                frm.Show();            
            }
        }

        private void mnuSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "TechStart Júnior\n\n" +
            "Sistema interno de apoio ao cliente TechStart.\n\n" +
            "Desenvolvido por Clayton Sardinha de Brito\n" +
            "Curso: Técnico em Desenvolvimento de Sistemas - ETEC\n" +
            "Ano: 2025",
            "Sobre",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            );
        }

        private void tsbEventos_Click(object sender, EventArgs e)
        {
            mnuCadEventos_Click(sender, e);
        }

        private void tsbProdutos_Click(object sender, EventArgs e)
        {
            mnuCadProdutos_Click(sender, e);
        }

        private void tsbExercicios_Click(object sender, EventArgs e)
        {
            mnuExer9_Click(sender, e);
        }

        private void tsbSair_Click(object sender, EventArgs e)
        {
            mnuSair_Click(sender, e);
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlDashboard.Width, pnlDashboard.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(47, 72, 122),  
                Color.FromArgb(5, 8, 22),     
                LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void pnlEventos_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlDashboard.Width, pnlDashboard.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(30, 38, 74),  
                Color.FromArgb(18, 27, 51),     
                LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void pnlLojinha_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlDashboard.Width, pnlDashboard.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(30, 38, 74),  
                Color.FromArgb(18, 27, 51),     
                LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void pnlNovidades_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlDashboard.Width, pnlDashboard.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(30, 38, 74), 
                Color.FromArgb(18, 27, 51),    
                LinearGradientMode.Vertical)) 
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }

        private void mnuExer1_Click(object sender, EventArgs e)
        {
            using (FrmExercicio1 frm = new FrmExercicio1())
            {
                frm.ShowDialog();
                frm.MdiParent = this;   
                frm.Show();             
            }
        }

        private void mnuExer2_Click(object sender, EventArgs e)
        {
            using (FrmExercicio2 frm = new FrmExercicio2())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer3_Click(object sender, EventArgs e)
        {
            using (FrmExercicio3 frm = new FrmExercicio3())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer4_Click(object sender, EventArgs e)
        {
            using (FrmExercicio4 frm = new FrmExercicio4())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer5_Click(object sender, EventArgs e)
        {
            using (FrmExercicio5 frm = new FrmExercicio5())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer6_Click(object sender, EventArgs e)
        {
            using (FrmExercicio6 frm = new FrmExercicio6())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer7_Click(object sender, EventArgs e)
        {
            using (FrmExercicio7 frm = new FrmExercicio7())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer8_Click(object sender, EventArgs e)
        {
            using (FrmExercicio8 frm = new FrmExercicio8())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer9_Click(object sender, EventArgs e)
        {
            using (FrmExercicio9 frm = new FrmExercicio9())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuExer10_Click(object sender, EventArgs e)
        {
            using (FrmExercicio10 frm = new FrmExercicio10())
            {
                frm.ShowDialog();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuTrocarUsuario_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show(
            "Deseja trocar de usuário?",
            "Trocar usuário",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resposta == DialogResult.No)
                return;

            Application.Restart();
        }

        private void tsbTrocarConta_Click(object sender, EventArgs e)
        {
            mnuTrocarUsuario_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mnuConEventos_Click(sender, e);
        }

        private void pnlEventos_MouseClick(object sender, MouseEventArgs e)
        {
            mnuConEventos_Click(sender, e);
        }
    }
}
