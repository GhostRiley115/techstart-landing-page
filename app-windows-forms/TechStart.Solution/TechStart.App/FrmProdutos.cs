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
using static TechStart.App.FrmConsultaProdutos;

namespace TechStart.App
{
    public partial class FrmProdutos : Form
    {
        private readonly string caminhoArquivo;
        private List<Produto> listaProdutos = new List<Produto>();
        private int idEmEdicao = 0; // 0 = novo
        public FrmProdutos()
        {
            InitializeComponent();
            caminhoArquivo = Path.Combine(Application.StartupPath,"dados","produtos.txt");
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

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            PopularCategorias();
            GarantirArquivoProdutos();
            CarregarProdutosDoArquivo();
        }
        private void ConfigurarListView()
        {
            lvProdutos.Columns.Clear();
            lvProdutos.View = View.Details;
            lvProdutos.FullRowSelect = true;
            lvProdutos.GridLines = true;

            lvProdutos.Columns.Add("ID", 50);
            lvProdutos.Columns.Add("Nome", 180);
            lvProdutos.Columns.Add("Categoria", 120);
            lvProdutos.Columns.Add("Preço", 80);
            lvProdutos.Columns.Add("Estoque", 70);
        }
        private void PopularCategorias()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Vestuário");
            cmbCategoria.Items.Add("Acessórios");
            cmbCategoria.Items.Add("Brindes");
            cmbCategoria.Items.Add("Tecnologia");
            cmbCategoria.Items.Add("Outro");
        }
        private void GarantirArquivoProdutos()
        {
            if (!File.Exists(caminhoArquivo))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(caminhoArquivo));
                File.Create(caminhoArquivo).Close();
            }
        }
        private void CarregarProdutosDoArquivo()
        {
            listaProdutos.Clear();
            lvProdutos.Items.Clear();

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
                ListViewItem item = new ListViewItem(p.Id.ToString());
                item.SubItems.Add(p.Nome);
                item.SubItems.Add(p.Categoria);
                item.SubItems.Add(p.Preco.ToString("C"));
                item.SubItems.Add(p.Estoque.ToString());

                lvProdutos.Items.Add(item);
            }

            LimparCampos();
        }
        private void SalvarProdutosNoArquivo()
        {
            using (StreamWriter sw = new StreamWriter(caminhoArquivo, false))
            {
                foreach (Produto p in listaProdutos)
                {
                    string linha = string.Join(";",
                        p.Id,
                        p.Nome,
                        p.Categoria,
                        p.Preco.ToString(),   // usa vírgula do sistema
                        p.Estoque,
                        p.CaminhoImagem ?? "",
                        (p.Descricao ?? "").Replace(";", ",")
                    );

                    sw.WriteLine(linha);
                }
            }
        }
        private void LimparCampos()
        {
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            txtImagem.Clear();
            txtDescricao.Clear();
            cmbCategoria.SelectedIndex = -1;
            idEmEdicao = 0;
            lvProdutos.SelectedItems.Clear();
        }

        private int ObterProximoId()
        {
            if (listaProdutos.Count == 0)
                return 1;

            return listaProdutos.Max(p => p.Id) + 1;
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();
            txtNomeProduto.Focus();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text.Trim();
            string categoria = cmbCategoria.SelectedItem != null ? cmbCategoria.SelectedItem.ToString() : "";
            string caminhoImg = txtImagem.Text.Trim();
            string descricao = txtDescricao.Text.Trim();

            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Informe um preço válido.");
                txtPreco.Focus();
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoque))
            {
                MessageBox.Show("Informe um estoque válido (número inteiro).");
                txtEstoque.Focus();
                return;
            }

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome do produto.");
                return;
            }

            if (string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Selecione a categoria.");
                return;
            }

            if (idEmEdicao == 0)
            {
                Produto novo = new Produto
                {
                    Id = ObterProximoId(),
                    Nome = nome,
                    Categoria = categoria,
                    Preco = preco,
                    Estoque = estoque,
                    CaminhoImagem = caminhoImg,
                    Descricao = descricao
                };
                listaProdutos.Add(novo);
            }
            else
            {
                Produto existente = listaProdutos.FirstOrDefault(p => p.Id == idEmEdicao);
                if (existente != null)
                {
                    existente.Nome = nome;
                    existente.Categoria = categoria;
                    existente.Preco = preco;
                    existente.Estoque = estoque;
                    existente.CaminhoImagem = caminhoImg;
                    existente.Descricao = descricao;
                }
            }

            SalvarProdutosNoArquivo();
            CarregarProdutosDoArquivo();

            MessageBox.Show("Produto salvo com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void lvProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProdutos.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvProdutos.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            Produto p = listaProdutos.FirstOrDefault(x => x.Id == id);
            if (p != null)
            {
                idEmEdicao = p.Id;
                txtNomeProduto.Text = p.Nome;
                cmbCategoria.SelectedItem = p.Categoria;
                txtPreco.Text = p.Preco.ToString();
                txtEstoque.Text = p.Estoque.ToString();
                txtImagem.Text = p.CaminhoImagem;
                txtDescricao.Text = p.Descricao;
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvProdutos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            ListViewItem item = lvProdutos.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            var resp = MessageBox.Show(
                "Deseja realmente excluir este produto?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resp == DialogResult.No)
                return;

            Produto p = listaProdutos.FirstOrDefault(x => x.Id == id);
            if (p != null)
            {
                listaProdutos.Remove(p);
                SalvarProdutosNoArquivo();
                CarregarProdutosDoArquivo();
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btnBuscarImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.png;*.jpg;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtImagem.Text = ofd.FileName;
            }
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
    }
}
