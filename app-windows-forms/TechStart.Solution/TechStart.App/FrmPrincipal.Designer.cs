namespace TechStart.App
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConEventos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExercicios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer4 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer5 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer6 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer7 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer8 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer9 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExer10 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrocarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbEventos = new System.Windows.Forms.ToolStripButton();
            this.tsbProdutos = new System.Windows.Forms.ToolStripButton();
            this.tsbExercicios = new System.Windows.Forms.ToolStripButton();
            this.tsbTrocarConta = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.picJujuba = new System.Windows.Forms.PictureBox();
            this.lblDesign = new System.Windows.Forms.Label();
            this.lblRodape = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlLojinha = new System.Windows.Forms.Panel();
            this.picLojinha = new System.Windows.Forms.PictureBox();
            this.lblLojinha = new System.Windows.Forms.Label();
            this.pnlEventos = new System.Windows.Forms.Panel();
            this.picEventos = new System.Windows.Forms.PictureBox();
            this.lblEventos = new System.Windows.Forms.Label();
            this.pnlNovidades = new System.Windows.Forms.Panel();
            this.picNovidades = new System.Windows.Forms.PictureBox();
            this.lblNovidades = new System.Windows.Forms.Label();
            this.menuPrincipal.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJujuba)).BeginInit();
            this.pnlLojinha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLojinha)).BeginInit();
            this.pnlEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventos)).BeginInit();
            this.pnlNovidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNovidades)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastros,
            this.mnuConsultas,
            this.mnuAjuda,
            this.mnuExercicios,
            this.mnuSistema});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuPrincipal.Size = new System.Drawing.Size(1284, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadProdutos,
            this.mnuCadEventos});
            this.mnuCadastros.Image = ((System.Drawing.Image)(resources.GetObject("mnuCadastros.Image")));
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(87, 20);
            this.mnuCadastros.Text = "Cadastros";
            // 
            // mnuCadProdutos
            // 
            this.mnuCadProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnuCadProdutos.Image")));
            this.mnuCadProdutos.Name = "mnuCadProdutos";
            this.mnuCadProdutos.Size = new System.Drawing.Size(180, 22);
            this.mnuCadProdutos.Text = "Produtos da Lojinha";
            this.mnuCadProdutos.Click += new System.EventHandler(this.mnuCadProdutos_Click);
            // 
            // mnuCadEventos
            // 
            this.mnuCadEventos.Image = ((System.Drawing.Image)(resources.GetObject("mnuCadEventos.Image")));
            this.mnuCadEventos.Name = "mnuCadEventos";
            this.mnuCadEventos.Size = new System.Drawing.Size(180, 22);
            this.mnuCadEventos.Text = "Eventos TechStart";
            this.mnuCadEventos.Click += new System.EventHandler(this.mnuCadEventos_Click);
            // 
            // mnuConsultas
            // 
            this.mnuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConProdutos,
            this.mnuConEventos});
            this.mnuConsultas.Image = ((System.Drawing.Image)(resources.GetObject("mnuConsultas.Image")));
            this.mnuConsultas.Name = "mnuConsultas";
            this.mnuConsultas.Size = new System.Drawing.Size(87, 20);
            this.mnuConsultas.Text = "Consultas";
            // 
            // mnuConProdutos
            // 
            this.mnuConProdutos.Image = ((System.Drawing.Image)(resources.GetObject("mnuConProdutos.Image")));
            this.mnuConProdutos.Name = "mnuConProdutos";
            this.mnuConProdutos.Size = new System.Drawing.Size(176, 22);
            this.mnuConProdutos.Text = "Consultar Produtos";
            this.mnuConProdutos.Click += new System.EventHandler(this.mnuConProdutos_Click);
            // 
            // mnuConEventos
            // 
            this.mnuConEventos.Image = ((System.Drawing.Image)(resources.GetObject("mnuConEventos.Image")));
            this.mnuConEventos.Name = "mnuConEventos";
            this.mnuConEventos.Size = new System.Drawing.Size(176, 22);
            this.mnuConEventos.Text = "Consultar Eventos";
            this.mnuConEventos.Click += new System.EventHandler(this.mnuConEventos_Click);
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSobre});
            this.mnuAjuda.Image = ((System.Drawing.Image)(resources.GetObject("mnuAjuda.Image")));
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(66, 20);
            this.mnuAjuda.Text = "Ajuda";
            // 
            // mnuSobre
            // 
            this.mnuSobre.Image = ((System.Drawing.Image)(resources.GetObject("mnuSobre.Image")));
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(104, 22);
            this.mnuSobre.Text = "Sobre";
            this.mnuSobre.Click += new System.EventHandler(this.mnuSobre_Click);
            // 
            // mnuExercicios
            // 
            this.mnuExercicios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExer1,
            this.mnuExer2,
            this.mnuExer3,
            this.mnuExer4,
            this.mnuExer5,
            this.mnuExer6,
            this.mnuExer7,
            this.mnuExer8,
            this.mnuExer9,
            this.mnuExer10});
            this.mnuExercicios.Image = ((System.Drawing.Image)(resources.GetObject("mnuExercicios.Image")));
            this.mnuExercicios.Name = "mnuExercicios";
            this.mnuExercicios.Size = new System.Drawing.Size(86, 20);
            this.mnuExercicios.Text = "Exercícios";
            // 
            // mnuExer1
            // 
            this.mnuExer1.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer1.Image")));
            this.mnuExer1.Name = "mnuExer1";
            this.mnuExer1.Size = new System.Drawing.Size(135, 22);
            this.mnuExer1.Text = "Exercício 1";
            this.mnuExer1.Click += new System.EventHandler(this.mnuExer1_Click);
            // 
            // mnuExer2
            // 
            this.mnuExer2.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer2.Image")));
            this.mnuExer2.Name = "mnuExer2";
            this.mnuExer2.Size = new System.Drawing.Size(135, 22);
            this.mnuExer2.Text = "Exercício 2";
            this.mnuExer2.Click += new System.EventHandler(this.mnuExer2_Click);
            // 
            // mnuExer3
            // 
            this.mnuExer3.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer3.Image")));
            this.mnuExer3.Name = "mnuExer3";
            this.mnuExer3.Size = new System.Drawing.Size(135, 22);
            this.mnuExer3.Text = "Exercício 3";
            this.mnuExer3.Click += new System.EventHandler(this.mnuExer3_Click);
            // 
            // mnuExer4
            // 
            this.mnuExer4.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer4.Image")));
            this.mnuExer4.Name = "mnuExer4";
            this.mnuExer4.Size = new System.Drawing.Size(135, 22);
            this.mnuExer4.Text = "Exercício 4";
            this.mnuExer4.Click += new System.EventHandler(this.mnuExer4_Click);
            // 
            // mnuExer5
            // 
            this.mnuExer5.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer5.Image")));
            this.mnuExer5.Name = "mnuExer5";
            this.mnuExer5.Size = new System.Drawing.Size(135, 22);
            this.mnuExer5.Text = "Exercício 5";
            this.mnuExer5.Click += new System.EventHandler(this.mnuExer5_Click);
            // 
            // mnuExer6
            // 
            this.mnuExer6.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer6.Image")));
            this.mnuExer6.Name = "mnuExer6";
            this.mnuExer6.Size = new System.Drawing.Size(135, 22);
            this.mnuExer6.Text = "Exercício 6";
            this.mnuExer6.Click += new System.EventHandler(this.mnuExer6_Click);
            // 
            // mnuExer7
            // 
            this.mnuExer7.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer7.Image")));
            this.mnuExer7.Name = "mnuExer7";
            this.mnuExer7.Size = new System.Drawing.Size(135, 22);
            this.mnuExer7.Text = "Exercício 7";
            this.mnuExer7.Click += new System.EventHandler(this.mnuExer7_Click);
            // 
            // mnuExer8
            // 
            this.mnuExer8.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer8.Image")));
            this.mnuExer8.Name = "mnuExer8";
            this.mnuExer8.Size = new System.Drawing.Size(135, 22);
            this.mnuExer8.Text = "Exercício 8";
            this.mnuExer8.Click += new System.EventHandler(this.mnuExer8_Click);
            // 
            // mnuExer9
            // 
            this.mnuExer9.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer9.Image")));
            this.mnuExer9.Name = "mnuExer9";
            this.mnuExer9.Size = new System.Drawing.Size(135, 22);
            this.mnuExer9.Text = "Exercício 9";
            this.mnuExer9.Click += new System.EventHandler(this.mnuExer9_Click);
            // 
            // mnuExer10
            // 
            this.mnuExer10.Image = ((System.Drawing.Image)(resources.GetObject("mnuExer10.Image")));
            this.mnuExer10.Name = "mnuExer10";
            this.mnuExer10.Size = new System.Drawing.Size(135, 22);
            this.mnuExer10.Text = "Exercício 10";
            this.mnuExer10.Click += new System.EventHandler(this.mnuExer10_Click);
            // 
            // mnuSistema
            // 
            this.mnuSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrocarUsuario,
            this.mnuSair});
            this.mnuSistema.Image = ((System.Drawing.Image)(resources.GetObject("mnuSistema.Image")));
            this.mnuSistema.Name = "mnuSistema";
            this.mnuSistema.Size = new System.Drawing.Size(76, 20);
            this.mnuSistema.Text = "Sistema";
            // 
            // mnuTrocarUsuario
            // 
            this.mnuTrocarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("mnuTrocarUsuario.Image")));
            this.mnuTrocarUsuario.Name = "mnuTrocarUsuario";
            this.mnuTrocarUsuario.Size = new System.Drawing.Size(149, 22);
            this.mnuTrocarUsuario.Text = "Trocar usuário";
            this.mnuTrocarUsuario.Click += new System.EventHandler(this.mnuTrocarUsuario_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Image = ((System.Drawing.Image)(resources.GetObject("mnuSair.Image")));
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(149, 22);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoSize = true;
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.pnlDashboard.Controls.Add(this.toolStripPrincipal);
            this.pnlDashboard.Controls.Add(this.picJujuba);
            this.pnlDashboard.Controls.Add(this.lblDesign);
            this.pnlDashboard.Controls.Add(this.lblRodape);
            this.pnlDashboard.Controls.Add(this.lblSubTitulo);
            this.pnlDashboard.Controls.Add(this.lblTitulo);
            this.pnlDashboard.Controls.Add(this.pnlLojinha);
            this.pnlDashboard.Controls.Add(this.pnlEventos);
            this.pnlDashboard.Controls.Add(this.pnlNovidades);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 24);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1284, 787);
            this.pnlDashboard.TabIndex = 100;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashboard_Paint);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.toolStripPrincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripPrincipal.BackgroundImage")));
            this.toolStripPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripPrincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEventos,
            this.tsbProdutos,
            this.tsbExercicios,
            this.tsbTrocarConta,
            this.tsbSair});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.Padding = new System.Windows.Forms.Padding(0, 10, 1, 0);
            this.toolStripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripPrincipal.Size = new System.Drawing.Size(132, 787);
            this.toolStripPrincipal.TabIndex = 104;
            this.toolStripPrincipal.Text = "toolStrip1";
            // 
            // tsbEventos
            // 
            this.tsbEventos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEventos.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tsbEventos.Image = ((System.Drawing.Image)(resources.GetObject("tsbEventos.Image")));
            this.tsbEventos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEventos.Name = "tsbEventos";
            this.tsbEventos.Size = new System.Drawing.Size(129, 41);
            this.tsbEventos.Text = "Eventos";
            this.tsbEventos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbEventos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEventos.Click += new System.EventHandler(this.tsbEventos_Click);
            // 
            // tsbProdutos
            // 
            this.tsbProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbProdutos.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tsbProdutos.Image = ((System.Drawing.Image)(resources.GetObject("tsbProdutos.Image")));
            this.tsbProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProdutos.Name = "tsbProdutos";
            this.tsbProdutos.Size = new System.Drawing.Size(129, 41);
            this.tsbProdutos.Text = "Produtos";
            this.tsbProdutos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbProdutos.Click += new System.EventHandler(this.tsbProdutos_Click);
            // 
            // tsbExercicios
            // 
            this.tsbExercicios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbExercicios.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tsbExercicios.Image = ((System.Drawing.Image)(resources.GetObject("tsbExercicios.Image")));
            this.tsbExercicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExercicios.Name = "tsbExercicios";
            this.tsbExercicios.Size = new System.Drawing.Size(129, 41);
            this.tsbExercicios.Text = "Exercícios";
            this.tsbExercicios.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbExercicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbExercicios.ToolTipText = "Mostra o exercício que eu mais gostei. Acesse todos pelo menu acima.";
            this.tsbExercicios.Click += new System.EventHandler(this.tsbExercicios_Click);
            // 
            // tsbTrocarConta
            // 
            this.tsbTrocarConta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbTrocarConta.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tsbTrocarConta.Image = ((System.Drawing.Image)(resources.GetObject("tsbTrocarConta.Image")));
            this.tsbTrocarConta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTrocarConta.Name = "tsbTrocarConta";
            this.tsbTrocarConta.Size = new System.Drawing.Size(129, 41);
            this.tsbTrocarConta.Text = "Trocar de conta";
            this.tsbTrocarConta.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbTrocarConta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbTrocarConta.Click += new System.EventHandler(this.tsbTrocarConta_Click);
            // 
            // tsbSair
            // 
            this.tsbSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbSair.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(129, 41);
            this.tsbSair.Text = "Sair";
            this.tsbSair.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // picJujuba
            // 
            this.picJujuba.BackColor = System.Drawing.Color.Transparent;
            this.picJujuba.Image = ((System.Drawing.Image)(resources.GetObject("picJujuba.Image")));
            this.picJujuba.Location = new System.Drawing.Point(1168, 748);
            this.picJujuba.Name = "picJujuba";
            this.picJujuba.Size = new System.Drawing.Size(35, 35);
            this.picJujuba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picJujuba.TabIndex = 111;
            this.picJujuba.TabStop = false;
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblDesign.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblDesign.Location = new System.Drawing.Point(1093, 768);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(69, 15);
            this.lblDesign.TabIndex = 110;
            this.lblDesign.Text = "Design by";
            // 
            // lblRodape
            // 
            this.lblRodape.AutoSize = true;
            this.lblRodape.BackColor = System.Drawing.Color.Transparent;
            this.lblRodape.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRodape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblRodape.Location = new System.Drawing.Point(461, 766);
            this.lblRodape.Name = "lblRodape";
            this.lblRodape.Size = new System.Drawing.Size(362, 18);
            this.lblRodape.TabIndex = 109;
            this.lblRodape.Text = "TechStart Júnior • Sistema interno de apoio ao cliente";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTitulo.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubTitulo.Location = new System.Drawing.Point(244, 156);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(924, 37);
            this.lblSubTitulo.TabIndex = 100;
            this.lblSubTitulo.Text = "Gerencie eventos, produtos da lojinha e confira as novidades da startup.";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(140, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1133, 65);
            this.lblTitulo.TabIndex = 99;
            this.lblTitulo.Text = "Bem-vindo à plataforma interna TechStart Júnior";
            // 
            // pnlLojinha
            // 
            this.pnlLojinha.Controls.Add(this.picLojinha);
            this.pnlLojinha.Controls.Add(this.lblLojinha);
            this.pnlLojinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLojinha.Location = new System.Drawing.Point(240, 228);
            this.pnlLojinha.Name = "pnlLojinha";
            this.pnlLojinha.Size = new System.Drawing.Size(250, 420);
            this.pnlLojinha.TabIndex = 106;
            this.pnlLojinha.Click += new System.EventHandler(this.pnlLojinha_Click);
            this.pnlLojinha.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLojinha_Paint);
            // 
            // picLojinha
            // 
            this.picLojinha.BackColor = System.Drawing.Color.Transparent;
            this.picLojinha.Image = ((System.Drawing.Image)(resources.GetObject("picLojinha.Image")));
            this.picLojinha.Location = new System.Drawing.Point(0, 97);
            this.picLojinha.Name = "picLojinha";
            this.picLojinha.Size = new System.Drawing.Size(250, 323);
            this.picLojinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLojinha.TabIndex = 113;
            this.picLojinha.TabStop = false;
            this.picLojinha.Click += new System.EventHandler(this.picLojinha_Click);
            // 
            // lblLojinha
            // 
            this.lblLojinha.AutoSize = true;
            this.lblLojinha.BackColor = System.Drawing.Color.Transparent;
            this.lblLojinha.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLojinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblLojinha.Location = new System.Drawing.Point(56, 58);
            this.lblLojinha.Name = "lblLojinha";
            this.lblLojinha.Size = new System.Drawing.Size(135, 19);
            this.lblLojinha.TabIndex = 109;
            this.lblLojinha.Text = "Lojinha TechStart";
            this.lblLojinha.Click += new System.EventHandler(this.lblLojinha_Click);
            // 
            // pnlEventos
            // 
            this.pnlEventos.Controls.Add(this.picEventos);
            this.pnlEventos.Controls.Add(this.lblEventos);
            this.pnlEventos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlEventos.Location = new System.Drawing.Point(584, 228);
            this.pnlEventos.Name = "pnlEventos";
            this.pnlEventos.Size = new System.Drawing.Size(250, 420);
            this.pnlEventos.TabIndex = 107;
            this.pnlEventos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEventos_Paint);
            this.pnlEventos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlEventos_MouseClick);
            // 
            // picEventos
            // 
            this.picEventos.BackColor = System.Drawing.Color.Transparent;
            this.picEventos.Image = ((System.Drawing.Image)(resources.GetObject("picEventos.Image")));
            this.picEventos.Location = new System.Drawing.Point(0, 97);
            this.picEventos.Name = "picEventos";
            this.picEventos.Size = new System.Drawing.Size(250, 323);
            this.picEventos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEventos.TabIndex = 113;
            this.picEventos.TabStop = false;
            this.picEventos.Click += new System.EventHandler(this.picEventos_Click);
            // 
            // lblEventos
            // 
            this.lblEventos.AutoSize = true;
            this.lblEventos.BackColor = System.Drawing.Color.Transparent;
            this.lblEventos.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblEventos.Location = new System.Drawing.Point(55, 58);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(140, 19);
            this.lblEventos.TabIndex = 110;
            this.lblEventos.Text = "Eventos TechStart";
            this.lblEventos.Click += new System.EventHandler(this.lblEventos_Click);
            // 
            // pnlNovidades
            // 
            this.pnlNovidades.Controls.Add(this.picNovidades);
            this.pnlNovidades.Controls.Add(this.lblNovidades);
            this.pnlNovidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlNovidades.Location = new System.Drawing.Point(922, 228);
            this.pnlNovidades.Name = "pnlNovidades";
            this.pnlNovidades.Size = new System.Drawing.Size(250, 420);
            this.pnlNovidades.TabIndex = 108;
            this.pnlNovidades.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNovidades_Paint);
            // 
            // picNovidades
            // 
            this.picNovidades.BackColor = System.Drawing.Color.Transparent;
            this.picNovidades.Image = ((System.Drawing.Image)(resources.GetObject("picNovidades.Image")));
            this.picNovidades.Location = new System.Drawing.Point(0, 97);
            this.picNovidades.Name = "picNovidades";
            this.picNovidades.Size = new System.Drawing.Size(250, 323);
            this.picNovidades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNovidades.TabIndex = 112;
            this.picNovidades.TabStop = false;
            // 
            // lblNovidades
            // 
            this.lblNovidades.AutoSize = true;
            this.lblNovidades.BackColor = System.Drawing.Color.Transparent;
            this.lblNovidades.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.lblNovidades.Location = new System.Drawing.Point(83, 58);
            this.lblNovidades.Name = "lblNovidades";
            this.lblNovidades.Size = new System.Drawing.Size(85, 19);
            this.lblNovidades.TabIndex = 111;
            this.lblNovidades.Text = "Novidades";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(8)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuPrincipal;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechStart - Painel Principal";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picJujuba)).EndInit();
            this.pnlLojinha.ResumeLayout(false);
            this.pnlLojinha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLojinha)).EndInit();
            this.pnlEventos.ResumeLayout(false);
            this.pnlEventos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEventos)).EndInit();
            this.pnlNovidades.ResumeLayout(false);
            this.pnlNovidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNovidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem mnuSistema;
        private System.Windows.Forms.ToolStripMenuItem mnuTrocarUsuario;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem mnuCadProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuCadEventos;
        private System.Windows.Forms.ToolStripMenuItem mnuConsultas;
        private System.Windows.Forms.ToolStripMenuItem mnuConProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnuConEventos;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.ToolStripMenuItem mnuExercicios;
        private System.Windows.Forms.ToolStripMenuItem mnuExer1;
        private System.Windows.Forms.ToolStripMenuItem mnuExer2;
        private System.Windows.Forms.ToolStripMenuItem mnuExer3;
        private System.Windows.Forms.ToolStripMenuItem mnuExer4;
        private System.Windows.Forms.ToolStripMenuItem mnuExer5;
        private System.Windows.Forms.ToolStripMenuItem mnuExer6;
        private System.Windows.Forms.ToolStripMenuItem mnuExer7;
        private System.Windows.Forms.ToolStripMenuItem mnuExer8;
        private System.Windows.Forms.ToolStripMenuItem mnuExer9;
        private System.Windows.Forms.ToolStripMenuItem mnuExer10;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.ToolStripButton tsbEventos;
        private System.Windows.Forms.ToolStripButton tsbProdutos;
        private System.Windows.Forms.ToolStripButton tsbExercicios;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.Panel pnlLojinha;
        private System.Windows.Forms.Panel pnlEventos;
        private System.Windows.Forms.Panel pnlNovidades;
        private System.Windows.Forms.Label lblNovidades;
        private System.Windows.Forms.Label lblEventos;
        private System.Windows.Forms.Label lblLojinha;
        private System.Windows.Forms.PictureBox picNovidades;
        private System.Windows.Forms.PictureBox picLojinha;
        private System.Windows.Forms.PictureBox picEventos;
        private System.Windows.Forms.Label lblRodape;
        private System.Windows.Forms.Label lblDesign;
        private System.Windows.Forms.PictureBox picJujuba;
        private System.Windows.Forms.ToolStripButton tsbTrocarConta;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
    }
}

