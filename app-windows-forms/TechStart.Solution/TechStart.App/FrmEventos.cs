using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TechStart.App
{
    public partial class FrmEventos : Form
    {
        private readonly string caminhoArquivo;
        private List<Evento> listaEventos = new List<Evento>();
        private int idEmEdicao = 0; 

        public FrmEventos()
        {
            InitializeComponent();

            caminhoArquivo = Path.Combine(Application.StartupPath,"dados","eventos.txt");
        }
        private void FrmEventos_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            PopularComboTipo();
            GarantirArquivoEventos();
            CarregarEventosDoArquivo();
        }

        public class Evento
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime Data { get; set; }
            public string Local { get; set; }
            public string Tipo { get; set; }
            public string Descricao { get; set; }
        }

        private void ConfigurarListView()
        {
            lvEventos.Columns.Clear();
            lvEventos.Columns.Add("ID", 50);
            lvEventos.Columns.Add("Nome", 200);
            lvEventos.Columns.Add("Data", 100);
            lvEventos.Columns.Add("Local", 150);
            lvEventos.Columns.Add("Tipo", 120);
        }

        private void PopularComboTipo()
        {
            cmbTipo.Items.Clear();
            cmbTipo.Items.Add("Palestra");
            cmbTipo.Items.Add("Workshop");
            cmbTipo.Items.Add("Treinamento");
            cmbTipo.Items.Add("Lançamento");
            cmbTipo.Items.Add("Meetup");
            cmbTipo.Items.Add("Outro");
        }
        private void LimparCampos()
        {
            txtNomeEvento.Clear();
            txtLocal.Clear();
            txtDescricao.Clear();
            cmbTipo.SelectedIndex = -1;
            dtpDataEvento.Value = DateTime.Today;

            idEmEdicao = 0;
            lvEventos.SelectedItems.Clear();
        }
        private int ObterProximoId()
        {
            if (listaEventos.Count == 0)
                return 1;

            return listaEventos.Max(e => e.Id) + 1;
        }

        private void GarantirArquivoEventos()
        {
            if (!File.Exists(caminhoArquivo))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(caminhoArquivo));
                File.Create(caminhoArquivo).Close();
            }
        }

        private void CarregarEventosDoArquivo()
        {
            listaEventos.Clear();
            lvEventos.Items.Clear();

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            foreach (string linha in linhas)
            {
                if (string.IsNullOrWhiteSpace(linha))
                    continue;

                string[] partes = linha.Split(';');
                if (partes.Length < 6)
                    continue;

                if (!int.TryParse(partes[0], out int id))
                    continue;

                DateTime data;
                if (!DateTime.TryParse(partes[2], out data))
                    data = DateTime.Today;

                Evento ev = new Evento
                {
                    Id = id,
                    Nome = partes[1],
                    Data = data,
                    Local = partes[3],
                    Tipo = partes[4],
                    Descricao = partes[5]
                };

                listaEventos.Add(ev);
            }

            foreach (Evento ev in listaEventos)
            {
                ListViewItem item = new ListViewItem(ev.Id.ToString());
                item.SubItems.Add(ev.Nome);
                item.SubItems.Add(ev.Data.ToShortDateString());
                item.SubItems.Add(ev.Local);
                item.SubItems.Add(ev.Tipo);

                lvEventos.Items.Add(item);
            }

            LimparCampos();
        }

        private void SalvarEventosNoArquivo()
        {
            using (StreamWriter sw = new StreamWriter(caminhoArquivo, false))
            {
                foreach (Evento ev in listaEventos)
                {
                    string linha = string.Join(";",
                        ev.Id,
                        ev.Nome,
                        ev.Data.ToString("yyyy-MM-dd"),
                        ev.Local,
                        ev.Tipo,
                        (ev.Descricao ?? string.Empty).Replace(";", ",")
                    );

                    sw.WriteLine(linha);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeEvento.Text.Trim();
            string local = txtLocal.Text.Trim();
            string tipo = cmbTipo.SelectedItem != null ? cmbTipo.SelectedItem.ToString() : "";
            string descricao = txtDescricao.Text.Trim();
            DateTime data = dtpDataEvento.Value.Date;

            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Informe o nome do evento.", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeEvento.Focus();
                return;
            }

            if (string.IsNullOrEmpty(local))
            {
                MessageBox.Show("Informe o local do evento.", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLocal.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("Selecione o tipo do evento.", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTipo.DroppedDown = true;
                return;
            }

            if (idEmEdicao == 0)
            {
                Evento novo = new Evento
                {
                    Id = ObterProximoId(),
                    Nome = nome,
                    Data = data,
                    Local = local,
                    Tipo = tipo,
                    Descricao = descricao
                };

                listaEventos.Add(novo);
            }
            else
            {
                Evento existente = listaEventos.FirstOrDefault(ev => ev.Id == idEmEdicao);
                if (existente != null)
                {
                    existente.Nome = nome;
                    existente.Data = data;
                    existente.Local = local;
                    existente.Tipo = tipo;
                    existente.Descricao = descricao;
                }
            }

            SalvarEventosNoArquivo();
            CarregarEventosDoArquivo();

            MessageBox.Show("Evento salvo com sucesso!", "Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lvEventos.SelectedItems.Count == 0 || idEmEdicao == 0)
            {
                MessageBox.Show("Selecione um evento na lista para editar.","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Evento ev = listaEventos.FirstOrDefault(x => x.Id == idEmEdicao);
            if (ev != null)
            {
                txtNomeEvento.Text = ev.Nome;
                dtpDataEvento.Value = ev.Data;
                txtLocal.Text = ev.Local;
                cmbTipo.SelectedItem = ev.Tipo;
                txtDescricao.Text = ev.Descricao;

                txtNomeEvento.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lvEventos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um evento na lista para excluir.", "Atenção",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lvEventos.SelectedItems[0];
            int id = int.Parse(item.SubItems[0].Text);

            DialogResult resp = MessageBox.Show("Deseja realmente excluir este evento?","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resp == DialogResult.No)
                return;

            Evento ev = listaEventos.FirstOrDefault(x => x.Id == id);
            if (ev != null)
            {
                listaEventos.Remove(ev);
                SalvarEventosNoArquivo();
                CarregarEventosDoArquivo();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void lvEventos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEventos.SelectedItems.Count == 0)
            {
                idEmEdicao = 0;
                return;
            }

            ListViewItem item = lvEventos.SelectedItems[0];
            idEmEdicao = int.Parse(item.SubItems[0].Text);
        }
        private void pnlFundo_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(0, 0, pnlFundo.Width, pnlFundo.Height);

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