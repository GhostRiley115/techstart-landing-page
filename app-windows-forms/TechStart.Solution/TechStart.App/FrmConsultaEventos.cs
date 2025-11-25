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
using static TechStart.App.FrmEventos;

namespace TechStart.App
{
    public partial class FrmConsultaEventos : Form
    {
        private readonly string caminhoArquivo;
        private List<Evento> listaEventos = new List<Evento>();
        public FrmConsultaEventos()
        {
            InitializeComponent();caminhoArquivo = Path.Combine(Application.StartupPath,"dados","eventos.txt");
            toolTip1.SetToolTip(btnFiltrar, "Filtrar eventos por nome ou local");
            toolTip1.SetToolTip(btnLimpar, "Limpar filtro e mostrar todos os eventos");
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


        private void FrmConsultaEventos_Load(object sender, EventArgs e)
        {
            ConfigurarListView();
            CarregarEventos();
        }
        private void ConfigurarListView()
        {
            lvEventosConsulta.Columns.Clear();
            lvEventosConsulta.View = View.Details;
            lvEventosConsulta.FullRowSelect = true;
            lvEventosConsulta.GridLines = true;

            lvEventosConsulta.Columns.Add("ID", 50);
            lvEventosConsulta.Columns.Add("Nome", 200);
            lvEventosConsulta.Columns.Add("Data", 100);
            lvEventosConsulta.Columns.Add("Local", 150);
            lvEventosConsulta.Columns.Add("Tipo", 120);
        }

        private void CarregarEventos()
        {
            listaEventos.Clear();
            lvEventosConsulta.Items.Clear();

            if (!File.Exists(caminhoArquivo))
                return;

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

            PreencherListView(listaEventos);
        }
        private void PreencherListView(IEnumerable<Evento> eventos)
        {
            lvEventosConsulta.Items.Clear();

            foreach (Evento ev in eventos)
            {
                ListViewItem item = new ListViewItem(ev.Id.ToString());
                item.SubItems.Add(ev.Nome);
                item.SubItems.Add(ev.Data.ToShortDateString());
                item.SubItems.Add(ev.Local);
                item.SubItems.Add(ev.Tipo);

                lvEventosConsulta.Items.Add(item);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string termo = txtBusca.Text.Trim();

            if (string.IsNullOrEmpty(termo))
            {
                // se não digitou nada, mostra tudo
                PreencherListView(listaEventos);
                return;
            }

            termo = termo.ToLower();

            var filtrados = listaEventos
                .Where(ev =>
                    ev.Nome.ToLower().Contains(termo) ||
                    ev.Local.ToLower().Contains(termo)
                );

            PreencherListView(filtrados);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            PreencherListView(listaEventos);
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
    }
}
