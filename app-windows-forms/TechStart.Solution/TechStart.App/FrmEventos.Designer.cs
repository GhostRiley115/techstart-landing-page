namespace TechStart.App
{
    partial class FrmEventos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvEventos = new System.Windows.Forms.ListView();
            this.grpDadosEvento = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dtpDataEvento = new System.Windows.Forms.DateTimePicker();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.txtNomeEvento = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.lblDataEvento = new System.Windows.Forms.Label();
            this.lblNomeEvento = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grpDadosEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lvEventos);
            this.panel1.Controls.Add(this.grpDadosEvento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 530);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lvEventos
            // 
            this.lvEventos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.lvEventos.ForeColor = System.Drawing.Color.White;
            this.lvEventos.FullRowSelect = true;
            this.lvEventos.GridLines = true;
            this.lvEventos.HideSelection = false;
            this.lvEventos.Location = new System.Drawing.Point(12, 269);
            this.lvEventos.Name = "lvEventos";
            this.lvEventos.Size = new System.Drawing.Size(670, 249);
            this.lvEventos.TabIndex = 6;
            this.lvEventos.UseCompatibleStateImageBehavior = false;
            this.lvEventos.View = System.Windows.Forms.View.Details;
            this.lvEventos.SelectedIndexChanged += new System.EventHandler(this.lvEventos_SelectedIndexChanged);
            // 
            // grpDadosEvento
            // 
            this.grpDadosEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.grpDadosEvento.Controls.Add(this.cmbTipo);
            this.grpDadosEvento.Controls.Add(this.btnSalvar);
            this.grpDadosEvento.Controls.Add(this.btnLimpar);
            this.grpDadosEvento.Controls.Add(this.dtpDataEvento);
            this.grpDadosEvento.Controls.Add(this.btnEditar);
            this.grpDadosEvento.Controls.Add(this.btnExcluir);
            this.grpDadosEvento.Controls.Add(this.txtDescricao);
            this.grpDadosEvento.Controls.Add(this.txtLocal);
            this.grpDadosEvento.Controls.Add(this.txtNomeEvento);
            this.grpDadosEvento.Controls.Add(this.lblDescricao);
            this.grpDadosEvento.Controls.Add(this.lblTipo);
            this.grpDadosEvento.Controls.Add(this.lblLocal);
            this.grpDadosEvento.Controls.Add(this.lblDataEvento);
            this.grpDadosEvento.Controls.Add(this.lblNomeEvento);
            this.grpDadosEvento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpDadosEvento.Location = new System.Drawing.Point(12, 12);
            this.grpDadosEvento.Name = "grpDadosEvento";
            this.grpDadosEvento.Size = new System.Drawing.Size(670, 251);
            this.grpDadosEvento.TabIndex = 0;
            this.grpDadosEvento.TabStop = false;
            this.grpDadosEvento.Text = "Dados do evento";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.cmbTipo.ForeColor = System.Drawing.Color.White;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(141, 102);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(407, 21);
            this.cmbTipo.TabIndex = 9;
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(6, 222);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(589, 222);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dtpDataEvento
            // 
            this.dtpDataEvento.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDataEvento.Location = new System.Drawing.Point(141, 50);
            this.dtpDataEvento.Name = "dtpDataEvento";
            this.dtpDataEvento.Size = new System.Drawing.Size(407, 20);
            this.dtpDataEvento.TabIndex = 8;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(198, 222);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(404, 222);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtDescricao.ForeColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(141, 129);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(407, 87);
            this.txtDescricao.TabIndex = 7;
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtLocal.ForeColor = System.Drawing.Color.White;
            this.txtLocal.Location = new System.Drawing.Point(141, 76);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(407, 20);
            this.txtLocal.TabIndex = 6;
            // 
            // txtNomeEvento
            // 
            this.txtNomeEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(22)))), ((int)(((byte)(40)))));
            this.txtNomeEvento.ForeColor = System.Drawing.Color.White;
            this.txtNomeEvento.Location = new System.Drawing.Point(141, 24);
            this.txtNomeEvento.Name = "txtNomeEvento";
            this.txtNomeEvento.Size = new System.Drawing.Size(407, 20);
            this.txtNomeEvento.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDescricao.Location = new System.Drawing.Point(11, 129);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(68, 17);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTipo.Location = new System.Drawing.Point(11, 106);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(37, 17);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLocal.Location = new System.Drawing.Point(11, 79);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(41, 17);
            this.lblLocal.TabIndex = 2;
            this.lblLocal.Text = "Local:";
            // 
            // lblDataEvento
            // 
            this.lblDataEvento.AutoSize = true;
            this.lblDataEvento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEvento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDataEvento.Location = new System.Drawing.Point(11, 50);
            this.lblDataEvento.Name = "lblDataEvento";
            this.lblDataEvento.Size = new System.Drawing.Size(39, 17);
            this.lblDataEvento.TabIndex = 1;
            this.lblDataEvento.Text = "Data:";
            // 
            // lblNomeEvento
            // 
            this.lblNomeEvento.AutoSize = true;
            this.lblNomeEvento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEvento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNomeEvento.Location = new System.Drawing.Point(11, 24);
            this.lblNomeEvento.Name = "lblNomeEvento";
            this.lblNomeEvento.Size = new System.Drawing.Size(114, 17);
            this.lblNomeEvento.TabIndex = 0;
            this.lblNomeEvento.Text = "Nome do evento:";
            // 
            // FrmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 530);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos TechStart";
            this.Load += new System.EventHandler(this.FrmEventos_Load);
            this.panel1.ResumeLayout(false);
            this.grpDadosEvento.ResumeLayout(false);
            this.grpDadosEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpDadosEvento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.Label lblDataEvento;
        private System.Windows.Forms.Label lblNomeEvento;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DateTimePicker dtpDataEvento;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.TextBox txtNomeEvento;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListView lvEventos;
    }
}