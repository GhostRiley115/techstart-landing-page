namespace TechStart.App
{
    partial class FrmConsultaEventos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaEventos));
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lvEventosConsulta = new System.Windows.Forms.ListView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(122)))));
            this.pnlDashboard.Controls.Add(this.lvEventosConsulta);
            this.pnlDashboard.Controls.Add(this.btnLimpar);
            this.pnlDashboard.Controls.Add(this.btnFiltrar);
            this.pnlDashboard.Controls.Add(this.txtBusca);
            this.pnlDashboard.Controls.Add(this.lblBuscar);
            this.pnlDashboard.Location = new System.Drawing.Point(-2, -3);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(465, 481);
            this.pnlDashboard.TabIndex = 0;
            this.pnlDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDashboard_Paint);
            // 
            // lvEventosConsulta
            // 
            this.lvEventosConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.lvEventosConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvEventosConsulta.ForeColor = System.Drawing.Color.White;
            this.lvEventosConsulta.FullRowSelect = true;
            this.lvEventosConsulta.GridLines = true;
            this.lvEventosConsulta.HideSelection = false;
            this.lvEventosConsulta.Location = new System.Drawing.Point(14, 118);
            this.lvEventosConsulta.Name = "lvEventosConsulta";
            this.lvEventosConsulta.Size = new System.Drawing.Size(434, 334);
            this.lvEventosConsulta.TabIndex = 5;
            this.lvEventosConsulta.UseCompatibleStateImageBehavior = false;
            this.lvEventosConsulta.View = System.Windows.Forms.View.Details;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(373, 60);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(292, 60);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(212, 34);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(236, 20);
            this.txtBusca.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblBuscar.Location = new System.Drawing.Point(37, 37);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(169, 17);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar por nome ou local:";
            // 
            // FrmConsultaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 476);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmConsultaEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Eventos";
            this.Load += new System.EventHandler(this.FrmConsultaEventos_Load);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.ListView lvEventosConsulta;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}