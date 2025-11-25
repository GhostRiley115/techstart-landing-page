using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechStart.App
{
    public partial class FrmConsultaProdutos : Form
    {
        private readonly string caminhoArquivo;
        private List<Produto> listaProdutos = new List<Produto>();
        public FrmConsultaProdutos()
        {
            InitializeComponent();
            caminhoArquivo = Path.Combine(Application.StartupPath,"dados","produtos.txt");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, panel1.Width, panel1.Height);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(47, 72, 122),
                Color.FromArgb(5, 8, 22),
                LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }
        public class Produto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Categoria { get; set; }
            public decimal Preco { get; set; }
            public int Estoque { get; set; }
            public string CaminhoImagem { get; set; }
            public string Descricao { get; set; }
        }

        private Panel CriarCardProduto(Produto p)
        {
            // painel “card”
            Panel card = new Panel();
            card.Width = 200;
            card.Height = 260;
            card.Margin = new Padding(10);
            card.BackColor = Color.FromArgb(20, 28, 40); // um pouco mais claro que o fundo

            // imagem do produto
            PictureBox pic = new PictureBox();
            pic.Width = 160;
            pic.Height = 140;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Top = 10;
            pic.Left = 20;

            if (!string.IsNullOrEmpty(p.CaminhoImagem) && System.IO.File.Exists(p.CaminhoImagem))
                pic.Image = Image.FromFile(p.CaminhoImagem);

            // nome
            Label lblNome = new Label();
            lblNome.Text = p.Nome;
            lblNome.AutoSize = false;
            lblNome.Width = card.Width - 20;
            lblNome.Left = 10;
            lblNome.Top = pic.Bottom + 10;
            lblNome.ForeColor = Color.White;
            lblNome.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            // categoria (opcional)
            Label lblCategoria = new Label();
            lblCategoria.Text = p.Categoria;
            lblCategoria.AutoSize = false;
            lblCategoria.Width = card.Width - 20;
            lblCategoria.Left = 10;
            lblCategoria.Top = lblNome.Bottom + 2;
            lblCategoria.ForeColor = Color.FromArgb(160, 170, 190);
            lblCategoria.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            // preço
            Label lblPreco = new Label();
            lblPreco.Text = p.Preco.ToString("C");
            lblPreco.AutoSize = false;
            lblPreco.Width = card.Width - 20;
            lblPreco.Left = 10;
            lblPreco.Top = lblCategoria.Bottom + 8;
            lblPreco.ForeColor = Color.FromArgb(0, 200, 140);
            lblPreco.Font = new Font("Segoe UI", 11, FontStyle.Bold);

            // adiciona tudo no card
            card.Controls.Add(pic);
            card.Controls.Add(lblNome);
            card.Controls.Add(lblCategoria);
            card.Controls.Add(lblPreco);

            // se quiser, você pode adicionar um evento de clique no card:
            // card.Click += (s, e) => MessageBox.Show($"Você clicou em {p.Nome}");

            return card;
        }

        private void flpProdutos_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void CarregarProdutos()
        {
            listaProdutos.Clear();
            flpProdutos.Controls.Clear();

            if (!File.Exists(caminhoArquivo))
                return;

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 7)
                    continue;

                if (!int.TryParse(partes[0], out int id))
                    continue;

                if (!decimal.TryParse(partes[3], out decimal preco))
                    preco = 0;

                if (!int.TryParse(partes[4], out int estoque))
                    estoque = 0;

                Produto p = new Produto
                {
                    Id = id,
                    Nome = partes[1],
                    Categoria = partes[2],
                    Preco = preco,
                    Estoque = estoque,
                    CaminhoImagem = partes[5],
                    Descricao = partes[6]
                };

                listaProdutos.Add(p);
            }

            foreach (Produto p in listaProdutos)
            {
                Panel card = CriarCardProduto(p); // aquela função de card que você já fez
                flpProdutos.Controls.Add(card);
            }
        }
        private void FrmConsultaProdutos_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
